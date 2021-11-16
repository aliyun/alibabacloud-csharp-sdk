// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListTopicsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTopicsResponseBodyData Data { get; set; }
        public class ListTopicsResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Topics")]
            [Validation(Required=false)]
            public List<ListTopicsResponseBodyDataTopics> Topics { get; set; }
            public class ListTopicsResponseBodyDataTopics : TeaModel {
                public long? AddTime { get; set; }
                public long? FixTime { get; set; }
                public long? HappenTime { get; set; }
                public long? InstanceId { get; set; }
                public long? NodeId { get; set; }
                public string NodeName { get; set; }
                public string NodeOwner { get; set; }
                public long? ProjectId { get; set; }
                public long? TopicId { get; set; }
                public string TopicName { get; set; }
                public string TopicStatus { get; set; }
                public string TopicType { get; set; }
            }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
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
