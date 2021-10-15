// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListEcsInstancesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListEcsInstancesResponseBodyHeaders Headers { get; set; }
        public class ListEcsInstancesResponseBodyHeaders : TeaModel {
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }
        };

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListEcsInstancesResponseBodyResult> Result { get; set; }
        public class ListEcsInstancesResponseBodyResult : TeaModel {
            [NameInMap("cloudAssistantStatus")]
            [Validation(Required=false)]
            public string CloudAssistantStatus { get; set; }

            [NameInMap("ecsInstanceName")]
            [Validation(Required=false)]
            public string EcsInstanceName { get; set; }

            [NameInMap("ecsInstanceId")]
            [Validation(Required=false)]
            public string EcsInstanceId { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            [NameInMap("osType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("ipAddress")]
            [Validation(Required=false)]
            public List<ListEcsInstancesResponseBodyResultIpAddress> IpAddress { get; set; }
            public class ListEcsInstancesResponseBodyResultIpAddress : TeaModel {
                [NameInMap("ipType")]
                [Validation(Required=false)]
                public string IpType { get; set; }

                [NameInMap("host")]
                [Validation(Required=false)]
                public string Host { get; set; }

            }

            [NameInMap("collectors")]
            [Validation(Required=false)]
            public List<ListEcsInstancesResponseBodyResultCollectors> Collectors { get; set; }
            public class ListEcsInstancesResponseBodyResultCollectors : TeaModel {
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
                public List<ListEcsInstancesResponseBodyResultCollectorsConfigs> Configs { get; set; }
                public class ListEcsInstancesResponseBodyResultCollectorsConfigs : TeaModel {
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                }

                [NameInMap("extendConfigs")]
                [Validation(Required=false)]
                public List<ListEcsInstancesResponseBodyResultCollectorsExtendConfigs> ExtendConfigs { get; set; }
                public class ListEcsInstancesResponseBodyResultCollectorsExtendConfigs : TeaModel {
                    [NameInMap("enableMonitoring")]
                    [Validation(Required=false)]
                    public bool? EnableMonitoring { get; set; }

                    [NameInMap("groupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    [NameInMap("configType")]
                    [Validation(Required=false)]
                    public string ConfigType { get; set; }

                    [NameInMap("instanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    [NameInMap("protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    [NameInMap("userName")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("machines")]
                    [Validation(Required=false)]
                    public List<ListEcsInstancesResponseBodyResultCollectorsExtendConfigsMachines> Machines { get; set; }
                    public class ListEcsInstancesResponseBodyResultCollectorsExtendConfigsMachines : TeaModel {
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

}
