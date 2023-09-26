// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetStrategyTemplateDetailResponseBody : TeaModel {
        /// <summary>
        /// The response code. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The details of the template.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetStrategyTemplateDetailResponseBodyData Data { get; set; }
        public class GetStrategyTemplateDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The configuration of the rule.
            /// </summary>
            [NameInMap("AlarmDetail")]
            [Validation(Required=false)]
            public GetStrategyTemplateDetailResponseBodyDataAlarmDetail AlarmDetail { get; set; }
            public class GetStrategyTemplateDetailResponseBodyDataAlarmDetail : TeaModel {
                /// <summary>
                /// The configuration of the baseline.
                /// </summary>
                [NameInMap("Baseline")]
                [Validation(Required=false)]
                public GetStrategyTemplateDetailResponseBodyDataAlarmDetailBaseline Baseline { get; set; }
                public class GetStrategyTemplateDetailResponseBodyDataAlarmDetailBaseline : TeaModel {
                    /// <summary>
                    /// The baseline items.
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetStrategyTemplateDetailResponseBodyDataAlarmDetailBaselineItem> Item { get; set; }
                    public class GetStrategyTemplateDetailResponseBodyDataAlarmDetailBaselineItem : TeaModel {
                        /// <summary>
                        /// The unique identifier of the baseline check item.
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// The name of the baseline check item.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// The severities of the baselines. Valid values:
                    /// 
                    /// *   **high**
                    /// *   **medium**
                    /// *   **low**
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public List<string> RiskLevel { get; set; }

                }

                /// <summary>
                /// The configuration of the alert rule for the malicious sample.
                /// </summary>
                [NameInMap("MaliciousFile")]
                [Validation(Required=false)]
                public GetStrategyTemplateDetailResponseBodyDataAlarmDetailMaliciousFile MaliciousFile { get; set; }
                public class GetStrategyTemplateDetailResponseBodyDataAlarmDetailMaliciousFile : TeaModel {
                    /// <summary>
                    /// The items on which malicious samples are detected.
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetStrategyTemplateDetailResponseBodyDataAlarmDetailMaliciousFileItem> Item { get; set; }
                    public class GetStrategyTemplateDetailResponseBodyDataAlarmDetailMaliciousFileItem : TeaModel {
                        /// <summary>
                        /// The unique identifier of the malicious sample.
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// The name of the malicious sample.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// The severities of the malicious samples.
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public List<string> RiskLevel { get; set; }

                }

                /// <summary>
                /// The configuration of the vulnerability detection rule.
                /// </summary>
                [NameInMap("Vul")]
                [Validation(Required=false)]
                public GetStrategyTemplateDetailResponseBodyDataAlarmDetailVul Vul { get; set; }
                public class GetStrategyTemplateDetailResponseBodyDataAlarmDetailVul : TeaModel {
                    /// <summary>
                    /// The items on which vulnerabilities are detected.
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetStrategyTemplateDetailResponseBodyDataAlarmDetailVulItem> Item { get; set; }
                    public class GetStrategyTemplateDetailResponseBodyDataAlarmDetailVulItem : TeaModel {
                        /// <summary>
                        /// The ID of the vulnerability.
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// The alias of the vulnerability.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// The severities of the vulnerabilities.
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public List<string> RiskLevel { get; set; }

                }

            }

            /// <summary>
            /// The cluster ID.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The name of the cluster.
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// The description of the rule.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The names of images.
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public List<string> ImageName { get; set; }

            /// <summary>
            /// The tags that are added to the containers.
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public List<string> Label { get; set; }

            /// <summary>
            /// Indicates whether the rule supports malicious Internet images. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("MaliciousImage")]
            [Validation(Required=false)]
            public bool? MaliciousImage { get; set; }

            /// <summary>
            /// The namespaces.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public List<string> Namespace { get; set; }

            /// <summary>
            /// The action on requests. Valid values:
            /// 
            /// *   **1**: trigger alerts
            /// *   **2**: block
            /// *   **3**: allow
            /// </summary>
            [NameInMap("RuleAction")]
            [Validation(Required=false)]
            public int? RuleAction { get; set; }

            /// <summary>
            /// The ID of the rule.
            /// </summary>
            [NameInMap("StrategyId")]
            [Validation(Required=false)]
            public long? StrategyId { get; set; }

            /// <summary>
            /// The name of the rule.
            /// </summary>
            [NameInMap("StrategyName")]
            [Validation(Required=false)]
            public string StrategyName { get; set; }

            /// <summary>
            /// The ID of the template.
            /// </summary>
            [NameInMap("StrategyTemplateId")]
            [Validation(Required=false)]
            public long? StrategyTemplateId { get; set; }

            /// <summary>
            /// Indicates whether the rule supports unscanned images. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("UnScanedImage")]
            [Validation(Required=false)]
            public bool? UnScanedImage { get; set; }

            /// <summary>
            /// The whitelists of tags that are added to images.
            /// </summary>
            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public List<string> WhiteList { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
