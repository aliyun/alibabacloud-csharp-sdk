// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeGroupMonitoringAgentProcessResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

        [NameInMap("Processes")]
        [Validation(Required=false)]
        public DescribeGroupMonitoringAgentProcessResponseBodyProcesses Processes { get; set; }
        public class DescribeGroupMonitoringAgentProcessResponseBodyProcesses : TeaModel {
            [NameInMap("Process")]
            [Validation(Required=false)]
            public List<DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcess> Process { get; set; }
            public class DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcess : TeaModel {
                public string ProcessName { get; set; }
                public string MatchExpressFilterRelation { get; set; }
                public string GroupId { get; set; }
                public string Id { get; set; }
                public DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessMatchExpress MatchExpress { get; set; }
                public class DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessMatchExpress : TeaModel {
                    [NameInMap("MatchExpress")]
                    [Validation(Required=false)]
                    public List<DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessMatchExpressMatchExpress> MatchExpress { get; set; }
                    public class DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessMatchExpressMatchExpress : TeaModel {
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Function")]
                        [Validation(Required=false)]
                        public string Function { get; set; }

                    }

                }
                public DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessAlertConfig AlertConfig { get; set; }
                public class DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessAlertConfig : TeaModel {
                    [NameInMap("AlertConfig")]
                    [Validation(Required=false)]
                    public List<DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessAlertConfigAlertConfig> AlertConfig { get; set; }
                    public class DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessAlertConfigAlertConfig : TeaModel {
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        [NameInMap("SilenceTime")]
                        [Validation(Required=false)]
                        public string SilenceTime { get; set; }

                        [NameInMap("Webhook")]
                        [Validation(Required=false)]
                        public string Webhook { get; set; }

                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public string Times { get; set; }

                        [NameInMap("EscalationsLevel")]
                        [Validation(Required=false)]
                        public string EscalationsLevel { get; set; }

                        [NameInMap("NoEffectiveInterval")]
                        [Validation(Required=false)]
                        public string NoEffectiveInterval { get; set; }

                        [NameInMap("EffectiveInterval")]
                        [Validation(Required=false)]
                        public string EffectiveInterval { get; set; }

                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                    }

                }
            }
        };

    }

}
