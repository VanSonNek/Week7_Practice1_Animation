using UnityEngine;

[RequireComponent(typeof(Animator))]
public sealed class DanceToggle : MonoBehaviour
{
    private static readonly int IsDancing = Animator.StringToHash("IsDancing");
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
#if ENABLE_INPUT_SYSTEM
        var keyboard = UnityEngine.InputSystem.Keyboard.current;
        if (keyboard != null && keyboard.spaceKey.wasPressedThisFrame)
            ToggleDance();
#elif ENABLE_LEGACY_INPUT_MANAGER
        if (Input.GetKeyDown(KeyCode.Space))
            ToggleDance();
#endif
    }

    private void OnGUI()
    {
        if (animator == null || animator.runtimeAnimatorController == null)
            return;

        GUI.Box(new Rect(16, 16, 300, 90), "Practice 1 - Mixamo Animation");
        GUI.Label(new Rect(28, 42, 276, 22), "Space: toggle Idle / Swing Dancing");
        if (GUI.Button(new Rect(28, 68, 276, 26),
            animator.GetBool(IsDancing) ? "Switch to Idle" : "Start Swing Dancing"))
            ToggleDance();
    }

    private void ToggleDance()
    {
        animator.SetBool(IsDancing, !animator.GetBool(IsDancing));
    }
}
