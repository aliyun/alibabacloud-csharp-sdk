// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetOpaStrategyDetailNewResponseBody : TeaModel {
        /// <summary>
        /// The status code returned. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOpaStrategyDetailNewResponseBodyData Data { get; set; }
        public class GetOpaStrategyDetailNewResponseBodyData : TeaModel {
            /// <summary>
            /// The rule configuration.
            /// </summary>
            [NameInMap("AlarmDetail")]
            [Validation(Required=false)]
            public GetOpaStrategyDetailNewResponseBodyDataAlarmDetail AlarmDetail { get; set; }
            public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetail : TeaModel {
                /// <summary>
                /// The baseline check configuration.
                /// </summary>
                [NameInMap("Baseline")]
                [Validation(Required=false)]
                public GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBaseline Baseline { get; set; }
                public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBaseline : TeaModel {
                    /// <summary>
                    /// The information about the baseline check item.
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBaselineItem> Item { get; set; }
                    public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBaselineItem : TeaModel {
                        /// <summary>
                        /// The ID of the baseline check item.
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
                    /// The risk levels.
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public List<string> RiskLevel { get; set; }

                }

                /// <summary>
                /// The configuration of image build risk.
                /// </summary>
                [NameInMap("BuildRisk")]
                [Validation(Required=false)]
                public GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBuildRisk BuildRisk { get; set; }
                public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBuildRisk : TeaModel {
                    /// <summary>
                    /// The configuration of image build risk.
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBuildRiskItem> Item { get; set; }
                    public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailBuildRiskItem : TeaModel {
                        /// <summary>
                        /// The ID of the image build risk.
                        /// 
                        /// >  You can call the [ListImageBuildRiskItem](~~ListImageBuildRiskItem~~) operation to query the ID of the malicious sample.
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// The name of the image build risk.
                        /// 
                        /// >  You can call the [ListImageBuildRiskItem](~~ListImageBuildRiskItem~~) operation to query the ID of the malicious sample.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// The risk levels.
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public List<string> RiskLevel { get; set; }

                }

                /// <summary>
                /// The configuration of malicious samples.
                /// </summary>
                [NameInMap("MaliciousFile")]
                [Validation(Required=false)]
                public GetOpaStrategyDetailNewResponseBodyDataAlarmDetailMaliciousFile MaliciousFile { get; set; }
                public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailMaliciousFile : TeaModel {
                    /// <summary>
                    /// The information about the malicious sample.
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetOpaStrategyDetailNewResponseBodyDataAlarmDetailMaliciousFileItem> Item { get; set; }
                    public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailMaliciousFileItem : TeaModel {
                        /// <summary>
                        /// The ID of the malicious sample.
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
                    /// The risk levels.
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public List<string> RiskLevel { get; set; }

                }

                /// <summary>
                /// The configuration of sensitive file.
                /// </summary>
                [NameInMap("SensitiveFile")]
                [Validation(Required=false)]
                public GetOpaStrategyDetailNewResponseBodyDataAlarmDetailSensitiveFile SensitiveFile { get; set; }
                public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailSensitiveFile : TeaModel {
                    /// <summary>
                    /// The configuration of sensitive file.
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetOpaStrategyDetailNewResponseBodyDataAlarmDetailSensitiveFileItem> Item { get; set; }
                    public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailSensitiveFileItem : TeaModel {
                        /// <summary>
                        /// The ID of the sensitive files.
                        /// 
                        /// >  You can call the [GetSensitiveDefineRuleConfig](~~GetSensitiveDefineRuleConfig~~) operation to query the ID of the malicious sample.
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// The name of the sensitive files.
                        /// 
                        /// >  You can call the [GetSensitiveDefineRuleConfig](~~GetSensitiveDefineRuleConfig~~) operation to query the ID of the malicious sample.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// The risk levels.
                    /// </summary>
                    [NameInMap("RiskLevel")]
                    [Validation(Required=false)]
                    public List<string> RiskLevel { get; set; }

                }

                /// <summary>
                /// The vulnerability configuration.
                /// </summary>
                [NameInMap("Vul")]
                [Validation(Required=false)]
                public GetOpaStrategyDetailNewResponseBodyDataAlarmDetailVul Vul { get; set; }
                public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailVul : TeaModel {
                    /// <summary>
                    /// The information about the vulnerability.
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public List<GetOpaStrategyDetailNewResponseBodyDataAlarmDetailVulItem> Item { get; set; }
                    public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailVulItem : TeaModel {
                        /// <summary>
                        /// The ID of the vulnerability.
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// The name of the vulnerability.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// Risk type of vulnerability.
                    /// </summary>
                    [NameInMap("RiskClass")]
                    [Validation(Required=false)]
                    public List<GetOpaStrategyDetailNewResponseBodyDataAlarmDetailVulRiskClass> RiskClass { get; set; }
                    public class GetOpaStrategyDetailNewResponseBodyDataAlarmDetailVulRiskClass : TeaModel {
                        /// <summary>
                        /// The ID of the vulnerability types. Valid values:
                        /// 
                        /// *   **cve**: system vulnerability
                        /// *   **app**: application vulnerability
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// The name of the vulnerability. Valid values:
                        /// 
                        /// *   **system vulnerability**
                        /// *   **application vulnerability**
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// The risk levels.
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
            /// The cluster name.
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// The page number. Default value: **1**. Pages start from page 1.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The description.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The image names.
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public List<string> ImageName { get; set; }

            /// <summary>
            /// The image tags.
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public List<string> Label { get; set; }

            /// <summary>
            /// The language of the content within the request and response. Default value: **zh**. Valid values:
            /// 
            /// *   **zh**: Chinese
            /// *   **en**: English
            /// </summary>
            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

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
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The action that is performed when the rule is hit. Valid values:
            /// 
            /// *   **1**: trigger alerts
            /// *   **2**: block
            /// *   **3**: allow
            /// </summary>
            [NameInMap("RuleAction")]
            [Validation(Required=false)]
            public int? RuleAction { get; set; }

            /// <summary>
            /// The application scope.
            /// </summary>
            [NameInMap("Scopes")]
            [Validation(Required=false)]
            public List<GetOpaStrategyDetailNewResponseBodyDataScopes> Scopes { get; set; }
            public class GetOpaStrategyDetailNewResponseBodyDataScopes : TeaModel {
                /// <summary>
                /// The rule instance ID of the cluster.
                /// </summary>
                [NameInMap("AckPolicyInstanceId")]
                [Validation(Required=false)]
                public string AckPolicyInstanceId { get; set; }

                /// <summary>
                /// Indicates whether all namespaces are included. Valid values:
                /// 
                /// *   **1**: yes
                /// *   **0**: no
                /// </summary>
                [NameInMap("AllNamespace")]
                [Validation(Required=false)]
                public int? AllNamespace { get; set; }

                /// <summary>
                /// The cluster ID.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The namespaces.
                /// </summary>
                [NameInMap("NamespaceList")]
                [Validation(Required=false)]
                public List<string> NamespaceList { get; set; }

            }

            /// <summary>
            /// The rule ID.
            /// </summary>
            [NameInMap("StrategyId")]
            [Validation(Required=false)]
            public long? StrategyId { get; set; }

            /// <summary>
            /// The rule name.
            /// </summary>
            [NameInMap("StrategyName")]
            [Validation(Required=false)]
            public string StrategyName { get; set; }

            /// <summary>
            /// The ID of the rule template.
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
            /// The image tags that are added to the whitelist.
            /// </summary>
            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public List<string> WhiteList { get; set; }

        }

        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
