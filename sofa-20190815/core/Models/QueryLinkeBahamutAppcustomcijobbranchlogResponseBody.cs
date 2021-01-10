// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeBahamutAppcustomcijobbranchlogResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorMsgParamsMap")]
        [Validation(Required=false)]
        public string ErrorMsgParamsMap { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryLinkeBahamutAppcustomcijobbranchlogResponseBodyResult> Result { get; set; }
        public class QueryLinkeBahamutAppcustomcijobbranchlogResponseBodyResult : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("Branch")]
            [Validation(Required=false)]
            public string Branch { get; set; }

            [NameInMap("CommitMessage")]
            [Validation(Required=false)]
            public string CommitMessage { get; set; }

            [NameInMap("Context")]
            [Validation(Required=false)]
            public string Context { get; set; }

            [NameInMap("Created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

            [NameInMap("CustomCIId")]
            [Validation(Required=false)]
            public string CustomCIId { get; set; }

            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            [NameInMap("ExecutionDate")]
            [Validation(Required=false)]
            public long? ExecutionDate { get; set; }

            [NameInMap("ExecutionId")]
            [Validation(Required=false)]
            public long? ExecutionId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IsLatest")]
            [Validation(Required=false)]
            public bool? IsLatest { get; set; }

            [NameInMap("LastCommitId")]
            [Validation(Required=false)]
            public string LastCommitId { get; set; }

            [NameInMap("LastExecuted")]
            [Validation(Required=false)]
            public long? LastExecuted { get; set; }

            [NameInMap("LastExecuteCost")]
            [Validation(Required=false)]
            public long? LastExecuteCost { get; set; }

            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public long? LastModified { get; set; }

            [NameInMap("PipelineInstanceId")]
            [Validation(Required=false)]
            public long? PipelineInstanceId { get; set; }

            [NameInMap("PipelineTemplateId")]
            [Validation(Required=false)]
            public long? PipelineTemplateId { get; set; }

            [NameInMap("PipelineTemplateName")]
            [Validation(Required=false)]
            public string PipelineTemplateName { get; set; }

            [NameInMap("Quality")]
            [Validation(Required=false)]
            public string Quality { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
