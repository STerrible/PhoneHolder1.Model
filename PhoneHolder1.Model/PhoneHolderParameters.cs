using System;
using System.ComponentModel.DataAnnotations;

namespace PhoneHolder.Model
{
    /// <summary>
    /// Класс параметров держателя для телефона.
    /// </summary>
    public class PhoneHolderParameters
    {
        // Приватные поля параметров
        private Parameter<float> _height;
        private Parameter<float> _tiltAngle;
        private Parameter<float> _baseWidth;
        private Parameter<float> _clampWidth;
        private Parameter<float> _holderWidth;

        /// <summary>
        /// Конструктор с инициализацией параметров.
        /// </summary>
        public PhoneHolderParameters()
        {
            _height = new Parameter<float>(Constants.MIN_HEIGHT, 100.0f, Constants.MAX_HEIGHT);
            _tiltAngle = new Parameter<float>(Constants.MIN_TILT_ANGLE, 45.0f, Constants.MAX_TILT_ANGLE);
            _baseWidth = new Parameter<float>(Constants.MIN_BASE_WIDTH, 60.0f, Constants.MAX_BASE_WIDTH);
            _clampWidth = new Parameter<float>(Constants.MIN_CLAMP_WIDTH, 30.0f, Constants.MAX_CLAMP_WIDTH);
            _holderWidth = new Parameter<float>(Constants.MIN_HOLDER_WIDTH, 40.0f, Constants.MAX_HOLDER_WIDTH);
        }

        /// <summary>
        /// Свойство для высоты держателя с валидацией.
        /// </summary>
        public float Height
        {
            get => _height.Value;
            set
            {
                if (Validator.ValidateParameter(_height, value))
                {
                    _height.Value = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Высота держателя должна быть в диапазоне [{Constants.MIN_HEIGHT} - {Constants.MAX_HEIGHT}] мм.");
                }
            }
        }

        /// <summary>
        /// Свойство для угла наклона с валидацией.
        /// </summary>
        public float TiltAngle
        {
            get => _tiltAngle.Value;
            set
            {
                if (Validator.ValidateParameter(_tiltAngle, value))
                {
                    _tiltAngle.Value = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Угол наклона должен быть в диапазоне [{Constants.MIN_TILT_ANGLE} - {Constants.MAX_TILT_ANGLE}] градусов.");
                }
            }
        }

        /// <summary>
        /// Свойство для ширины основания с валидацией.
        /// </summary>
        public float BaseWidth
        {
            get => _baseWidth.Value;
            set
            {
                if (Validator.ValidateParameter(_baseWidth, value))
                {
                    _baseWidth.Value = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Ширина основания должна быть в диапазоне [{Constants.MIN_BASE_WIDTH} - {Constants.MAX_BASE_WIDTH}] мм.");
                }
            }
        }

        /// <summary>
        /// Свойство для ширины зажима с валидацией и зависимостью от ширины держателей.
        /// </summary>
        public float ClampWidth
        {
            get => _clampWidth.Value;
            set
            {
                if (Validator.ValidateParameter(_clampWidth, value) && (value < HolderWidth))
                {
                    _clampWidth.Value = value;
                }
                else
                {
                    throw new ArgumentException($"Ширина зажима должна быть в диапазоне [{Constants.MIN_CLAMP_WIDTH} - {Constants.MAX_CLAMP_WIDTH}] мм и меньше ширины держателей ({HolderWidth} мм).");
                }
            }
        }

        /// <summary>
        /// Свойство для ширины держателей с валидацией.
        /// </summary>
        public float HolderWidth
        {
            get => _holderWidth.Value;
            set
            {
                if (Validator.ValidateParameter(_holderWidth, value))
                {
                    _holderWidth.Value = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Ширина держателей должна быть в диапазоне [{Constants.MIN_HOLDER_WIDTH} - {Constants.MAX_HOLDER_WIDTH}] мм.");
                }
            }
        }
    }
}
