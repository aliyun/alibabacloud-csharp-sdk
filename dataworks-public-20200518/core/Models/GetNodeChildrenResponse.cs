// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetNodeChildrenResponse : TeaModel {
        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=true)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=true)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetNodeChildrenResponseData Data { get; set; }
        public class GetNodeChildrenResponseData : TeaModel {
            [NameInMap("Nodes")]
            [Validation(Required=true)]
            public List<GetNodeChildrenResponseDataNodes> Nodes { get; set; }
            public class GetNodeChildrenResponseDataNodes : TeaModel {
                public long? NodeId { get; set; }
                public string NodeName { get; set; }
                public string CronExpress { get; set; }
                public string SchedulerType { get; set; }
                public string ProgramType { get; set; }
                public string OwnerId { get; set; }
                public long? ProjectId { get; set; }
                public bool? Repeatability { get; set; }
                public int? Priority { get; set; }
                public long? BaselineId { get; set; }
            }
        };

    }

}
