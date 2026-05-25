using System.ComponentModel.DataAnnotations;
using QuestionService.Validators;

namespace QuestionService.DTOs;

public record QuestionDto(
	[Required] string Title,
	[Required] string Content,
	[Required] [TagListValidator(1,5)] List<string> Tags
);
