namespace LD47.Engine
{
	struct InputStates<T>
	{
		public InputStates(T previousState, T currentState)
		{
			Previous = previousState;
			Current = currentState;
		}

		public T Previous { get; }

		public T Current { get; }

		public InputStates<T> Next(T newCurrentState) =>
			new InputStates<T>(Current, newCurrentState);
	}
}
