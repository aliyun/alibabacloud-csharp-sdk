// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeGroupMonitoringAgentProcessResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status codes.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Request is not authorization.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("Processes")]
        [Validation(Required=false)]
        public DescribeGroupMonitoringAgentProcessResponseBodyProcesses Processes { get; set; }
        public class DescribeGroupMonitoringAgentProcessResponseBodyProcesses : TeaModel {
            [NameInMap("Process")]
            [Validation(Required=false)]
            public List<DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcess> Process { get; set; }
            public class DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcess : TeaModel {
                [NameInMap("AlertConfig")]
                [Validation(Required=false)]
                public DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessAlertConfig AlertConfig { get; set; }
                public class DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessAlertConfig : TeaModel {
                    [NameInMap("AlertConfig")]
                    [Validation(Required=false)]
                    public List<DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessAlertConfigAlertConfig> AlertConfig { get; set; }
                    public class DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessAlertConfigAlertConfig : TeaModel {
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        [NameInMap("EffectiveInterval")]
                        [Validation(Required=false)]
                        public string EffectiveInterval { get; set; }

                        [NameInMap("EscalationsLevel")]
                        [Validation(Required=false)]
                        public string EscalationsLevel { get; set; }

                        [NameInMap("NoEffectiveInterval")]
                        [Validation(Required=false)]
                        public string NoEffectiveInterval { get; set; }

                        [NameInMap("SilenceTime")]
                        [Validation(Required=false)]
                        public string SilenceTime { get; set; }

                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        [NameInMap("TargetList")]
                        [Validation(Required=false)]
                        public DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessAlertConfigAlertConfigTargetList TargetList { get; set; }
                        public class DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessAlertConfigAlertConfigTargetList : TeaModel {
                            [NameInMap("Target")]
                            [Validation(Required=false)]
                            public List<DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessAlertConfigAlertConfigTargetListTarget> Target { get; set; }
                            public class DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessAlertConfigAlertConfigTargetListTarget : TeaModel {
                                [NameInMap("Arn")]
                                [Validation(Required=false)]
                                public string Arn { get; set; }

                                [NameInMap("Id")]
                                [Validation(Required=false)]
                                public string Id { get; set; }

                                [NameInMap("JsonParmas")]
                                [Validation(Required=false)]
                                public string JsonParmas { get; set; }

                                [NameInMap("Level")]
                                [Validation(Required=false)]
                                public string Level { get; set; }

                            }

                        }

                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public string Times { get; set; }

                        [NameInMap("Webhook")]
                        [Validation(Required=false)]
                        public string Webhook { get; set; }

                    }

                }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("MatchExpress")]
                [Validation(Required=false)]
                public DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessMatchExpress MatchExpress { get; set; }
                public class DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessMatchExpress : TeaModel {
                    [NameInMap("MatchExpress")]
                    [Validation(Required=false)]
                    public List<DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessMatchExpressMatchExpress> MatchExpress { get; set; }
                    public class DescribeGroupMonitoringAgentProcessResponseBodyProcessesProcessMatchExpressMatchExpress : TeaModel {
                        [NameInMap("Function")]
                        [Validation(Required=false)]
                        public string Function { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("MatchExpressFilterRelation")]
                [Validation(Required=false)]
                public string MatchExpressFilterRelation { get; set; }

                [NameInMap("ProcessName")]
                [Validation(Required=false)]
                public string ProcessName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7985D471-3FA8-4EE9-8F4B-45C19DF3D36F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
