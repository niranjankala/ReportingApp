//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sdlcRDLCReport
{
    using System;
    using System.Collections.Generic;
    
    public partial class CDPQuestionValidations
    {
        public System.Guid Id { get; set; }
        public System.Guid QuestionId { get; set; }
        public System.Guid ValidationId { get; set; }
        public string Value { get; set; }
    
        public virtual CDPQuestions CDPQuestions { get; set; }
        public virtual CDPValidationTypes CDPValidationTypes { get; set; }
    }
}
