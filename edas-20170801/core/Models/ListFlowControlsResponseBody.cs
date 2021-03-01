// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListFlowControlsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("FlowControlsMap")]
        [Validation(Required=false)]
        public ListFlowControlsResponseBodyFlowControlsMap FlowControlsMap { get; set; }
        public class ListFlowControlsResponseBodyFlowControlsMap : TeaModel {
            [NameInMap("AppList")]
            [Validation(Required=false)]
            public ListFlowControlsResponseBodyFlowControlsMapAppList AppList { get; set; }
            public class ListFlowControlsResponseBodyFlowControlsMapAppList : TeaModel {
                [NameInMap("App")]
                [Validation(Required=false)]
                public List<ListFlowControlsResponseBodyFlowControlsMapAppListApp> App { get; set; }
                public class ListFlowControlsResponseBodyFlowControlsMapAppListApp : TeaModel {
                    [NameInMap("SlbId")]
                    [Validation(Required=false)]
                    public string SlbId { get; set; }

                    [NameInMap("ExtSlbIp")]
                    [Validation(Required=false)]
                    public string ExtSlbIp { get; set; }

                    [NameInMap("HealthCheckUrl")]
                    [Validation(Required=false)]
                    public string HealthCheckUrl { get; set; }

                    [NameInMap("Owner")]
                    [Validation(Required=false)]
                    public string Owner { get; set; }

                    [NameInMap("SlbPort")]
                    [Validation(Required=false)]
                    public int? SlbPort { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    [NameInMap("ApplicationType")]
                    [Validation(Required=false)]
                    public string ApplicationType { get; set; }

                    [NameInMap("ExtSlbId")]
                    [Validation(Required=false)]
                    public string ExtSlbId { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    [NameInMap("RunningInstanceCount")]
                    [Validation(Required=false)]
                    public int? RunningInstanceCount { get; set; }

                    [NameInMap("SlbIp")]
                    [Validation(Required=false)]
                    public string SlbIp { get; set; }

                    [NameInMap("BuildPackageId")]
                    [Validation(Required=false)]
                    public long? BuildPackageId { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("Dockerize")]
                    [Validation(Required=false)]
                    public bool? Dockerize { get; set; }

                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    [NameInMap("InstanceCount")]
                    [Validation(Required=false)]
                    public int? InstanceCount { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("ClusterType")]
                    [Validation(Required=false)]
                    public int? ClusterType { get; set; }

                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public int? Memory { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                }

            }
            [NameInMap("InterfaceMethods")]
            [Validation(Required=false)]
            public ListFlowControlsResponseBodyFlowControlsMapInterfaceMethods InterfaceMethods { get; set; }
            public class ListFlowControlsResponseBodyFlowControlsMapInterfaceMethods : TeaModel {
                [NameInMap("InterfaceMethod")]
                [Validation(Required=false)]
                public List<ListFlowControlsResponseBodyFlowControlsMapInterfaceMethodsInterfaceMethod> InterfaceMethod { get; set; }
                public class ListFlowControlsResponseBodyFlowControlsMapInterfaceMethodsInterfaceMethod : TeaModel {
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Methods")]
                    [Validation(Required=false)]
                    public ListFlowControlsResponseBodyFlowControlsMapInterfaceMethodsInterfaceMethodMethods Methods { get; set; }
                    public class ListFlowControlsResponseBodyFlowControlsMapInterfaceMethodsInterfaceMethodMethods : TeaModel {
                        [NameInMap("Method")]
                        [Validation(Required=false)]
                        public List<string> Method { get; set; }
                    };

                }

            }
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public ListFlowControlsResponseBodyFlowControlsMapRuleList RuleList { get; set; }
            public class ListFlowControlsResponseBodyFlowControlsMapRuleList : TeaModel {
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                [NameInMap("TotalSize")]
                [Validation(Required=false)]
                public int? TotalSize { get; set; }

                [NameInMap("RuleResultList")]
                [Validation(Required=false)]
                public ListFlowControlsResponseBodyFlowControlsMapRuleListRuleResultList RuleResultList { get; set; }
                public class ListFlowControlsResponseBodyFlowControlsMapRuleListRuleResultList : TeaModel {
                    [NameInMap("Rule")]
                    [Validation(Required=false)]
                    public List<ListFlowControlsResponseBodyFlowControlsMapRuleListRuleResultListRule> Rule { get; set; }
                    public class ListFlowControlsResponseBodyFlowControlsMapRuleListRuleResultListRule : TeaModel {
                        public long? UpdateTime { get; set; }
                        public string RuleType { get; set; }
                        public int? State { get; set; }
                        public long? CreateTime { get; set; }
                        public string ConsumerAppId { get; set; }
                        public string RuleId { get; set; }
                        public string Strategy { get; set; }
                        public string Resource { get; set; }
                        public string AppId { get; set; }
                        public string Granularity { get; set; }
                        public int? Threshold { get; set; }
                        public string Id { get; set; }
                    }
                };

                [NameInMap("pageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
