// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListMqttRootTopicsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RootTopics")]
        [Validation(Required=false)]
        public ListMqttRootTopicsResponseBodyRootTopics RootTopics { get; set; }
        public class ListMqttRootTopicsResponseBodyRootTopics : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListMqttRootTopicsResponseBodyRootTopicsList> List { get; set; }
            public class ListMqttRootTopicsResponseBodyRootTopicsList : TeaModel {
                public int? CreateTime { get; set; }
                public string RootTopic { get; set; }
                public string Type { get; set; }
                public string QueueName { get; set; }
                public string AppKey { get; set; }
            }
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public ListMqttRootTopicsResponseBodyRootTopicsPagination Pagination { get; set; }
            public class ListMqttRootTopicsResponseBodyRootTopicsPagination : TeaModel {
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                [NameInMap("TotalPageCount")]
                [Validation(Required=false)]
                public int? TotalPageCount { get; set; }

                [NameInMap("PageIndex")]
                [Validation(Required=false)]
                public int? PageIndex { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

            }
        };

    }

}
