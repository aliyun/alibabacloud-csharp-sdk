// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CreateDataTasksRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<CreateDataTasksRequestBody> Body { get; set; }
        public class CreateDataTasksRequestBody : TeaModel {
            [NameInMap("migrateConfig")]
            [Validation(Required=false)]
            public CreateDataTasksRequestBodyMigrateConfig MigrateConfig { get; set; }
            public class CreateDataTasksRequestBodyMigrateConfig : TeaModel {
                [NameInMap("sourceFilterParams")]
                [Validation(Required=false)]
                public string SourceFilterParams { get; set; }

            }

            [NameInMap("sinkCluster")]
            [Validation(Required=false)]
            public CreateDataTasksRequestBodySinkCluster SinkCluster { get; set; }
            public class CreateDataTasksRequestBodySinkCluster : TeaModel {
                [NameInMap("dataSourceType")]
                [Validation(Required=false)]
                public string DataSourceType { get; set; }

                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                [NameInMap("mapping")]
                [Validation(Required=false)]
                public string Mapping { get; set; }

                [NameInMap("password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                [NameInMap("routing")]
                [Validation(Required=false)]
                public string Routing { get; set; }

                [NameInMap("settings")]
                [Validation(Required=false)]
                public string Settings { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            [NameInMap("sourceCluster")]
            [Validation(Required=false)]
            public CreateDataTasksRequestBodySourceCluster SourceCluster { get; set; }
            public class CreateDataTasksRequestBodySourceCluster : TeaModel {
                [NameInMap("dataSourceType")]
                [Validation(Required=false)]
                public string DataSourceType { get; set; }

                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                [NameInMap("password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

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

            }

        }

    }

}
