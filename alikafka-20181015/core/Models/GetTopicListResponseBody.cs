// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20181015.Models
{
    public class GetTopicListResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("TopicList")]
        [Validation(Required=false)]
        public GetTopicListResponseBodyTopicList TopicList { get; set; }
        public class GetTopicListResponseBodyTopicList : TeaModel {
            [NameInMap("TopicVO")]
            [Validation(Required=false)]
            public List<GetTopicListResponseBodyTopicListTopicVO> TopicVO { get; set; }
            public class GetTopicListResponseBodyTopicListTopicVO : TeaModel {
                public int? Status { get; set; }
                public string Remark { get; set; }
                public long? CreateTime { get; set; }
                public string Topic { get; set; }
                public string StatusName { get; set; }
                public string InstanceId { get; set; }
                public string RegionId { get; set; }
            }
        };

    }

}
