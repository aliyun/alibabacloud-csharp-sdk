// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetMsSgCircuitBreakerRuleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("StartIndex")]
        [Validation(Required=false)]
        public long? StartIndex { get; set; }

        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public long? TotalSize { get; set; }

        [NameInMap("RuleModels")]
        [Validation(Required=false)]
        public List<GetMsSgCircuitBreakerRuleResponseBodyRuleModels> RuleModels { get; set; }
        public class GetMsSgCircuitBreakerRuleResponseBodyRuleModels : TeaModel {
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("HttpMethod")]
            [Validation(Required=false)]
            public string HttpMethod { get; set; }

            [NameInMap("HttpPath")]
            [Validation(Required=false)]
            public string HttpPath { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("MethodName")]
            [Validation(Required=false)]
            public string MethodName { get; set; }

            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            [NameInMap("ResType")]
            [Validation(Required=false)]
            public string ResType { get; set; }

            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("TrafficType")]
            [Validation(Required=false)]
            public string TrafficType { get; set; }

            [NameInMap("AppNames")]
            [Validation(Required=false)]
            public List<string> AppNames { get; set; }

            [NameInMap("CircuitBreakerRuleItems")]
            [Validation(Required=false)]
            public List<GetMsSgCircuitBreakerRuleResponseBodyRuleModelsCircuitBreakerRuleItems> CircuitBreakerRuleItems { get; set; }
            public class GetMsSgCircuitBreakerRuleResponseBodyRuleModelsCircuitBreakerRuleItems : TeaModel {
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                [NameInMap("TrafficConditions")]
                [Validation(Required=false)]
                public List<GetMsSgCircuitBreakerRuleResponseBodyRuleModelsCircuitBreakerRuleItemsTrafficConditions> TrafficConditions { get; set; }
                public class GetMsSgCircuitBreakerRuleResponseBodyRuleModelsCircuitBreakerRuleItemsTrafficConditions : TeaModel {
                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    [NameInMap("Operation")]
                    [Validation(Required=false)]
                    public string Operation { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public List<string> Value { get; set; }

                }

                [NameInMap("Action")]
                [Validation(Required=false)]
                public GetMsSgCircuitBreakerRuleResponseBodyRuleModelsCircuitBreakerRuleItemsAction Action { get; set; }
                public class GetMsSgCircuitBreakerRuleResponseBodyRuleModelsCircuitBreakerRuleItemsAction : TeaModel {
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }
                    [NameInMap("Extension")]
                    [Validation(Required=false)]
                    public string Extension { get; set; }
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }
                };

                [NameInMap("Configs")]
                [Validation(Required=false)]
                public GetMsSgCircuitBreakerRuleResponseBodyRuleModelsCircuitBreakerRuleItemsConfigs Configs { get; set; }
                public class GetMsSgCircuitBreakerRuleResponseBodyRuleModelsCircuitBreakerRuleItemsConfigs : TeaModel {
                    [NameInMap("AverageRtThreshold")]
                    [Validation(Required=false)]
                    public long? AverageRtThreshold { get; set; }
                    [NameInMap("ErrorPercentThreshold")]
                    [Validation(Required=false)]
                    public long? ErrorPercentThreshold { get; set; }
                    [NameInMap("ProviderTimeout")]
                    [Validation(Required=false)]
                    public long? ProviderTimeout { get; set; }
                    [NameInMap("RequestVolumeThreshold")]
                    [Validation(Required=false)]
                    public long? RequestVolumeThreshold { get; set; }
                    [NameInMap("RpcTimeout")]
                    [Validation(Required=false)]
                    public long? RpcTimeout { get; set; }
                    [NameInMap("SleepWindow")]
                    [Validation(Required=false)]
                    public long? SleepWindow { get; set; }
                    [NameInMap("TotalMetricWindow")]
                    [Validation(Required=false)]
                    public long? TotalMetricWindow { get; set; }
                };

            }

            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<GetMsSgCircuitBreakerRuleResponseBodyRuleModelsConditions> Conditions { get; set; }
            public class GetMsSgCircuitBreakerRuleResponseBodyRuleModelsConditions : TeaModel {
                [NameInMap("Field")]
                [Validation(Required=false)]
                public string Field { get; set; }

                [NameInMap("Operation")]
                [Validation(Required=false)]
                public string Operation { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public List<string> Value { get; set; }

            }

            [NameInMap("Config")]
            [Validation(Required=false)]
            public GetMsSgCircuitBreakerRuleResponseBodyRuleModelsConfig Config { get; set; }
            public class GetMsSgCircuitBreakerRuleResponseBodyRuleModelsConfig : TeaModel {
                [NameInMap("AverageRtThreshold")]
                [Validation(Required=false)]
                public long? AverageRtThreshold { get; set; }
                [NameInMap("ErrorPercentThreshold")]
                [Validation(Required=false)]
                public long? ErrorPercentThreshold { get; set; }
                [NameInMap("ProviderTimeout")]
                [Validation(Required=false)]
                public long? ProviderTimeout { get; set; }
                [NameInMap("RequestVolumeThreshold")]
                [Validation(Required=false)]
                public long? RequestVolumeThreshold { get; set; }
                [NameInMap("RpcTimeout")]
                [Validation(Required=false)]
                public long? RpcTimeout { get; set; }
                [NameInMap("SleepWindow")]
                [Validation(Required=false)]
                public long? SleepWindow { get; set; }
                [NameInMap("TotalMetricWindow")]
                [Validation(Required=false)]
                public long? TotalMetricWindow { get; set; }
            };

        }

    }

}
