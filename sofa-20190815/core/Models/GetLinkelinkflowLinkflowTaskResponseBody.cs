// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkelinkflowLinkflowTaskResponseBody : TeaModel {
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
        public GetLinkelinkflowLinkflowTaskResponseBodyData Data { get; set; }
        public class GetLinkelinkflowLinkflowTaskResponseBodyData : TeaModel {
            [NameInMap("AssignedUser")]
            [Validation(Required=false)]
            public string AssignedUser { get; set; }
            [NameInMap("Assignee")]
            [Validation(Required=false)]
            public string Assignee { get; set; }
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }
            [NameInMap("Finished")]
            [Validation(Required=false)]
            public bool? Finished { get; set; }
            [NameInMap("FormKey")]
            [Validation(Required=false)]
            public string FormKey { get; set; }
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
            [NameInMap("ProcessInstance")]
            [Validation(Required=false)]
            public string ProcessInstance { get; set; }
            [NameInMap("ProcessInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }
            [NameInMap("Candidates")]
            [Validation(Required=false)]
            public List<string> Candidates { get; set; }
            [NameInMap("CandidateGroups")]
            [Validation(Required=false)]
            public List<string> CandidateGroups { get; set; }
            [NameInMap("CandidateGroupUsers")]
            [Validation(Required=false)]
            public List<string> CandidateGroupUsers { get; set; }
            [NameInMap("CandidateUsers")]
            [Validation(Required=false)]
            public List<string> CandidateUsers { get; set; }
        };

    }

}
