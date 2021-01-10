// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkelinkflowLinkflowStartformmodelResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Current")]
        [Validation(Required=false)]
        public long? Current { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetLinkelinkflowLinkflowStartformmodelResponseBodyData Data { get; set; }
        public class GetLinkelinkflowLinkflowStartformmodelResponseBodyData : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("FormInstanceId")]
            [Validation(Required=false)]
            public string FormInstanceId { get; set; }
            [NameInMap("FormModel")]
            [Validation(Required=false)]
            public string FormModel { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("ProcessDefinitionId")]
            [Validation(Required=false)]
            public string ProcessDefinitionId { get; set; }
            [NameInMap("ProcessInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }
            [NameInMap("ScopeDefinitionId")]
            [Validation(Required=false)]
            public string ScopeDefinitionId { get; set; }
            [NameInMap("ScopeId")]
            [Validation(Required=false)]
            public string ScopeId { get; set; }
            [NameInMap("ScopeType")]
            [Validation(Required=false)]
            public string ScopeType { get; set; }
            [NameInMap("SelectedOutcome")]
            [Validation(Required=false)]
            public string SelectedOutcome { get; set; }
            [NameInMap("SubmittedBy")]
            [Validation(Required=false)]
            public string SubmittedBy { get; set; }
            [NameInMap("SubmittedDate")]
            [Validation(Required=false)]
            public long? SubmittedDate { get; set; }
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }
            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }
        };

    }

}
