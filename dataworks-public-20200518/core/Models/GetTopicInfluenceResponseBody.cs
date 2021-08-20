// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetTopicInfluenceResponseBody : TeaModel {
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTopicInfluenceResponseBodyData Data { get; set; }
        public class GetTopicInfluenceResponseBodyData : TeaModel {
            [NameInMap("TopicId")]
            [Validation(Required=false)]
            public long? TopicId { get; set; }
            [NameInMap("Influences")]
            [Validation(Required=false)]
            public List<GetTopicInfluenceResponseBodyDataInfluences> Influences { get; set; }
            public class GetTopicInfluenceResponseBodyDataInfluences : TeaModel {
                public string Status { get; set; }
                public string Owner { get; set; }
                public string BaselineName { get; set; }
                public long? BaselineId { get; set; }
                public long? Bizdate { get; set; }
                public long? Buffer { get; set; }
                public long? ProjectId { get; set; }
                public int? Priority { get; set; }
                public int? InGroupId { get; set; }
            }
        };

    }

}
