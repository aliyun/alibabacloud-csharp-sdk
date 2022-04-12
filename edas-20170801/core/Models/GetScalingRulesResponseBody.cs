// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetScalingRulesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetScalingRulesResponseBodyData Data { get; set; }
        public class GetScalingRulesResponseBodyData : TeaModel {
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public int? ClusterType { get; set; }
            [NameInMap("OversoldFactor")]
            [Validation(Required=false)]
            public int? OversoldFactor { get; set; }
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public GetScalingRulesResponseBodyDataRuleList RuleList { get; set; }
            public class GetScalingRulesResponseBodyDataRuleList : TeaModel {
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public List<GetScalingRulesResponseBodyDataRuleListRule> Rule { get; set; }
                public class GetScalingRulesResponseBodyDataRuleListRule : TeaModel {
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    [NameInMap("Cond")]
                    [Validation(Required=false)]
                    public string Cond { get; set; }

                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public int? Duration { get; set; }

                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    [NameInMap("InstNum")]
                    [Validation(Required=false)]
                    public int? InstNum { get; set; }

                    [NameInMap("LoadNum")]
                    [Validation(Required=false)]
                    public int? LoadNum { get; set; }

                    [NameInMap("MetricType")]
                    [Validation(Required=false)]
                    public string MetricType { get; set; }

                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                    [NameInMap("MultiAzPolicy")]
                    [Validation(Required=false)]
                    public string MultiAzPolicy { get; set; }

                    [NameInMap("ResourceFrom")]
                    [Validation(Required=false)]
                    public string ResourceFrom { get; set; }

                    [NameInMap("Rt")]
                    [Validation(Required=false)]
                    public int? Rt { get; set; }

                    [NameInMap("SpecId")]
                    [Validation(Required=false)]
                    public string SpecId { get; set; }

                    [NameInMap("Step")]
                    [Validation(Required=false)]
                    public int? Step { get; set; }

                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                    [NameInMap("TemplateVersion")]
                    [Validation(Required=false)]
                    public int? TemplateVersion { get; set; }

                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                    [NameInMap("VSwitchIds")]
                    [Validation(Required=false)]
                    public string VSwitchIds { get; set; }

                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

            }
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
