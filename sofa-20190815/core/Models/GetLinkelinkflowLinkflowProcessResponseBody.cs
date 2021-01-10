// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkelinkflowLinkflowProcessResponseBody : TeaModel {
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
        public GetLinkelinkflowLinkflowProcessResponseBodyData Data { get; set; }
        public class GetLinkelinkflowLinkflowProcessResponseBodyData : TeaModel {
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }
            [NameInMap("DefinitionId")]
            [Validation(Required=false)]
            public string DefinitionId { get; set; }
            [NameInMap("DefinitionKey")]
            [Validation(Required=false)]
            public string DefinitionKey { get; set; }
            [NameInMap("Finished")]
            [Validation(Required=false)]
            public bool? Finished { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Starter")]
            [Validation(Required=false)]
            public string Starter { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }
            [NameInMap("StartUserId")]
            [Validation(Required=false)]
            public string StartUserId { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }
            [NameInMap("Variables")]
            [Validation(Required=false)]
            public string Variables { get; set; }
            [NameInMap("AssigneeUserIds")]
            [Validation(Required=false)]
            public List<string> AssigneeUserIds { get; set; }
            [NameInMap("CandidateUsers")]
            [Validation(Required=false)]
            public List<string> CandidateUsers { get; set; }
            [NameInMap("CandidateUserIds")]
            [Validation(Required=false)]
            public List<string> CandidateUserIds { get; set; }
        };

    }

}
