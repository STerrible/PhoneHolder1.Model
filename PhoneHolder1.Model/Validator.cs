namespace PhoneHolder.Model
{
    /// <summary>
    /// Класс для валидации параметров.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Валидация одного параметра.
        /// </summary>
        /// <typeparam name="T">Тип параметра.</typeparam>
        /// <param name="parameter">Параметр для обозначения границ.</param>
        /// <param name="value">Значение для проверки.</param>
        /// <returns>True - если значение в диапазоне, иначе - False.</returns>
        public static bool ValidateParameter<T>(Parameter<T> parameter, T value) where T : IComparable<T>
        {
            return parameter.MaxValue.CompareTo(value) >= 0 && parameter.MinValue.CompareTo(value) <= 0;
        }
    }
}
