// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDataTasksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDataTasksResponseBodyResult> Result { get; set; }
        public class ListDataTasksResponseBodyResult : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("sinkCluster")]
            [Validation(Required=false)]
            public ListDataTasksResponseBodyResultSinkCluster SinkCluster { get; set; }
            public class ListDataTasksResponseBodyResultSinkCluster : TeaModel {
                [NameInMap("dataSourceType")]
                [Validation(Required=false)]
                public string DataSourceType { get; set; }
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }
                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }
                [NameInMap("vpcInstanceId")]
                [Validation(Required=false)]
                public string VpcInstanceId { get; set; }
                [NameInMap("vpcInstancePort")]
                [Validation(Required=false)]
                public string VpcInstancePort { get; set; }
            };

            [NameInMap("sourceCluster")]
            [Validation(Required=false)]
            public ListDataTasksResponseBodyResultSourceCluster SourceCluster { get; set; }
            public class ListDataTasksResponseBodyResultSourceCluster : TeaModel {
                [NameInMap("dataSourceType")]
                [Validation(Required=false)]
                public string DataSourceType { get; set; }
                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }
                [NameInMap("mapping")]
                [Validation(Required=false)]
                public string Mapping { get; set; }
                [NameInMap("routing")]
                [Validation(Required=false)]
                public string Routing { get; set; }
                [NameInMap("settings")]
                [Validation(Required=false)]
                public string Settings { get; set; }
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }
            };

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
