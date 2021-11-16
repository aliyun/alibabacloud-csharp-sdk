// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetNodeResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetNodeResponseBodyData Data { get; set; }
        public class GetNodeResponseBodyData : TeaModel {
            [NameInMap("BaselineId")]
            [Validation(Required=false)]
            public long? BaselineId { get; set; }
            [NameInMap("BusinessId")]
            [Validation(Required=false)]
            public long? BusinessId { get; set; }
            [NameInMap("Connection")]
            [Validation(Required=false)]
            public string Connection { get; set; }
            [NameInMap("CronExpress")]
            [Validation(Required=false)]
            public string CronExpress { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("DqcDescription")]
            [Validation(Required=false)]
            public string DqcDescription { get; set; }
            [NameInMap("DqcType")]
            [Validation(Required=false)]
            public int? DqcType { get; set; }
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }
            [NameInMap("ParamValues")]
            [Validation(Required=false)]
            public string ParamValues { get; set; }
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }
            [NameInMap("ProgramType")]
            [Validation(Required=false)]
            public string ProgramType { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }
            [NameInMap("RelatedFlowId")]
            [Validation(Required=false)]
            public long? RelatedFlowId { get; set; }
            [NameInMap("RepeatInterval")]
            [Validation(Required=false)]
            public long? RepeatInterval { get; set; }
            [NameInMap("Repeatability")]
            [Validation(Required=false)]
            public string Repeatability { get; set; }
            [NameInMap("ResGroupName")]
            [Validation(Required=false)]
            public string ResGroupName { get; set; }
            [NameInMap("SchedulerType")]
            [Validation(Required=false)]
            public string SchedulerType { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
