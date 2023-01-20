using Lab13.Utils;

namespace Lab13.Models {
    public class QuizAnswerModel {
        [LessThanOrNull(101, ErrorMessage = "Здесь не может быть такого большого числа")]
        public int? Answer { get; set; }
    }
}
