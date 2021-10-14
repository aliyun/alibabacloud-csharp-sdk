// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListCollectorsResponseBody : TeaModel {
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListCollectorsResponseBodyHeaders Headers { get; set; }
        public class ListCollectorsResponseBodyHeaders : TeaModel {
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListCollectorsResponseBodyResult> Result { get; set; }
        public class ListCollectorsResponseBodyResult : TeaModel {
            [NameInMap("resId")]
            [Validation(Required=false)]
            public string ResId { get; set; }

            [NameInMap("gmtUpdateTime")]
            [Validation(Required=false)]
            public string GmtUpdateTime { get; set; }

            [NameInMap("dryRun")]
            [Validation(Required=false)]
            public bool? DryRun { get; set; }

            [NameInMap("ownerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("resType")]
            [Validation(Required=false)]
            public string ResType { get; set; }

            [NameInMap("resVersion")]
            [Validation(Required=false)]
            public string ResVersion { get; set; }

            [NameInMap("gmtCreatedTime")]
            [Validation(Required=false)]
            public string GmtCreatedTime { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("configs")]
            [Validation(Required=false)]
            public List<ListCollectorsResponseBodyResultConfigs> Configs { get; set; }
            public class ListCollectorsResponseBodyResultConfigs : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

            }

            [NameInMap("extendConfigs")]
            [Validation(Required=false)]
            public List<ListCollectorsResponseBodyResultExtendConfigs> ExtendConfigs { get; set; }
            public class ListCollectorsResponseBodyResultExtendConfigs : TeaModel {
                [NameInMap("successPodsCount")]
                [Validation(Required=false)]
                public string SuccessPodsCount { get; set; }

                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("userName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                [NameInMap("totalPodsCount")]
                [Validation(Required=false)]
                public string TotalPodsCount { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("kibanaHost")]
                [Validation(Required=false)]
                public string KibanaHost { get; set; }

                [NameInMap("enableMonitoring")]
                [Validation(Required=false)]
                public bool? EnableMonitoring { get; set; }

                [NameInMap("configType")]
                [Validation(Required=false)]
                public string ConfigType { get; set; }

                [NameInMap("instanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("groupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("machines")]
                [Validation(Required=false)]
                public List<ListCollectorsResponseBodyResultExtendConfigsMachines> Machines { get; set; }
                public class ListCollectorsResponseBodyResultExtendConfigsMachines : TeaModel {
                    [NameInMap("agentStatus")]
                    [Validation(Required=false)]
                    public string AgentStatus { get; set; }

                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                }

                [NameInMap("hosts")]
                [Validation(Required=false)]
                public List<string> Hosts { get; set; }

            }

            [NameInMap("collectorPaths")]
            [Validation(Required=false)]
            public List<string> CollectorPaths { get; set; }

        }

    }

}
