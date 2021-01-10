// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkelinkflowLinkflowProcessoperationlogResponseBody : TeaModel {
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
        public List<GetLinkelinkflowLinkflowProcessoperationlogResponseBodyData> Data { get; set; }
        public class GetLinkelinkflowLinkflowProcessoperationlogResponseBodyData : TeaModel {
            [NameInMap("ActivityId")]
            [Validation(Required=false)]
            public string ActivityId { get; set; }

            [NameInMap("ActivityName")]
            [Validation(Required=false)]
            public string ActivityName { get; set; }

            [NameInMap("ActivityType")]
            [Validation(Required=false)]
            public string ActivityType { get; set; }

            [NameInMap("Assignee")]
            [Validation(Required=false)]
            public string Assignee { get; set; }

            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("ProcessDefinitionId")]
            [Validation(Required=false)]
            public string ProcessDefinitionId { get; set; }

            [NameInMap("ProcessInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
