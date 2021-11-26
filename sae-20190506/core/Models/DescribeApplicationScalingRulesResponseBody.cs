// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationScalingRulesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApplicationScalingRulesResponseBodyData Data { get; set; }
        public class DescribeApplicationScalingRulesResponseBodyData : TeaModel {
            [NameInMap("ApplicationScalingRules")]
            [Validation(Required=false)]
            public List<DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRules> ApplicationScalingRules { get; set; }
            public class DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRules : TeaModel {
                public string AppId { get; set; }
                public long? CreateTime { get; set; }
                public bool? ScaleRuleEnabled { get; set; }
                public string ScaleRuleName { get; set; }
                public string ScaleRuleType { get; set; }
                public DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesTimer Timer { get; set; }
                public class DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesTimer : TeaModel {
                    [NameInMap("BeginDate")]
                    [Validation(Required=false)]
                    public string BeginDate { get; set; }

                    [NameInMap("EndDate")]
                    [Validation(Required=false)]
                    public string EndDate { get; set; }

                    [NameInMap("Period")]
                    [Validation(Required=false)]
                    public string Period { get; set; }

                    [NameInMap("Schedules")]
                    [Validation(Required=false)]
                    public List<DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesTimerSchedules> Schedules { get; set; }
                    public class DescribeApplicationScalingRulesResponseBodyDataApplicationScalingRulesTimerSchedules : TeaModel {
                        [NameInMap("AtTime")]
                        [Validation(Required=false)]
                        public string AtTime { get; set; }

                        [NameInMap("MaxReplicas")]
                        [Validation(Required=false)]
                        public long? MaxReplicas { get; set; }

                        [NameInMap("MinReplicas")]
                        [Validation(Required=false)]
                        public long? MinReplicas { get; set; }

                        [NameInMap("TargetReplicas")]
                        [Validation(Required=false)]
                        public int? TargetReplicas { get; set; }

                    }

                }
                public long? UpdateTime { get; set; }
            }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
