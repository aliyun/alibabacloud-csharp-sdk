// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CreateDataTasksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<CreateDataTasksResponseBodyResult> Result { get; set; }
        public class CreateDataTasksResponseBodyResult : TeaModel {
            [NameInMap("sourceCluster")]
            [Validation(Required=false)]
            public CreateDataTasksResponseBodyResultSourceCluster SourceCluster { get; set; }
            public class CreateDataTasksResponseBodyResultSourceCluster : TeaModel {
                [NameInMap("password")]
                [Validation(Required=false)]
                public string Password { get; set; }
                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }
                [NameInMap("vpcInstanceId")]
                [Validation(Required=false)]
                public string VpcInstanceId { get; set; }
                [NameInMap("vpcInstancePort")]
                [Validation(Required=false)]
                public int? VpcInstancePort { get; set; }
                [NameInMap("dataSourceType")]
                [Validation(Required=false)]
                public string DataSourceType { get; set; }
            };

            [NameInMap("sinkCluster")]
            [Validation(Required=false)]
            public CreateDataTasksResponseBodyResultSinkCluster SinkCluster { get; set; }
            public class CreateDataTasksResponseBodyResultSinkCluster : TeaModel {
                [NameInMap("password")]
                [Validation(Required=false)]
                public string Password { get; set; }
                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }
                [NameInMap("settings")]
                [Validation(Required=false)]
                public string Settings { get; set; }
                [NameInMap("mapping")]
                [Validation(Required=false)]
                public string Mapping { get; set; }
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }
                [NameInMap("routing")]
                [Validation(Required=false)]
                public string Routing { get; set; }
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }
                [NameInMap("vpcInstancePort")]
                [Validation(Required=false)]
                public string VpcInstancePort { get; set; }
                [NameInMap("vpcInstanceId")]
                [Validation(Required=false)]
                public string VpcInstanceId { get; set; }
                [NameInMap("dataSourceType")]
                [Validation(Required=false)]
                public string DataSourceType { get; set; }
            };

        }

    }

}
