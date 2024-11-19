namespace PhoneHolder.Model
{
    /// <summary>
    /// Параметр держателя для телефона.
    /// </summary>
    public class Parameter<T>
    {
        /// <summary>
        /// Экземплярный, шаблонный конструктор класса параметра.
        /// </summary>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="value">Текущее значение.</param>
        /// <param name="max">Максимальное значение.</param>
        public Parameter(T min, T value, T max)
        {
            MinValue = min;
            Value = value;
            MaxValue = max;
        }

        /// <summary>
        /// Минимальное значение.
        /// </summary>
        public T MinValue { get; set; }

        /// <summary>
        /// Текущее значение.
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Максимальное значение.
        /// </summary>
        public T MaxValue { get; set; }
    }
}
