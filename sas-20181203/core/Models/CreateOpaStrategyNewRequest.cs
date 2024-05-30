// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateOpaStrategyNewRequest : TeaModel {
        /// <summary>
        /// The risks that you want to detect by using the rule.
        /// </summary>
        [NameInMap("AlarmDetail")]
        [Validation(Required=false)]
        public CreateOpaStrategyNewRequestAlarmDetail AlarmDetail { get; set; }
        public class CreateOpaStrategyNewRequestAlarmDetail : TeaModel {
            /// <summary>
            /// The baseline risks.
            /// </summary>
            [NameInMap("Baseline")]
            [Validation(Required=false)]
            public CreateOpaStrategyNewRequestAlarmDetailBaseline Baseline { get; set; }
            public class CreateOpaStrategyNewRequestAlarmDetailBaseline : TeaModel {
                /// <summary>
                /// The baseline check items.
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<CreateOpaStrategyNewRequestAlarmDetailBaselineItem> Item { get; set; }
                public class CreateOpaStrategyNewRequestAlarmDetailBaselineItem : TeaModel {
                    /// <summary>
                    /// The ID of the baseline check item.
                    /// 
                    /// >  You can call the [GetOpaClusterBaseLineList](https://help.aliyun.com/document_detail/2539883.html) operation to query the ID.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// The name of the baseline check item.
                    /// 
                    /// >  You can call the [GetOpaClusterBaseLineList](https://help.aliyun.com/document_detail/2539883.html) operation to query the name.
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
            public CreateOpaStrategyNewRequestAlarmDetailBuildRisk BuildRisk { get; set; }
            public class CreateOpaStrategyNewRequestAlarmDetailBuildRisk : TeaModel {
                /// <summary>
                /// The configuration of image build risk.
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<CreateOpaStrategyNewRequestAlarmDetailBuildRiskItem> Item { get; set; }
                public class CreateOpaStrategyNewRequestAlarmDetailBuildRiskItem : TeaModel {
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
            /// The malicious sample risks.
            /// </summary>
            [NameInMap("MaliciousFile")]
            [Validation(Required=false)]
            public CreateOpaStrategyNewRequestAlarmDetailMaliciousFile MaliciousFile { get; set; }
            public class CreateOpaStrategyNewRequestAlarmDetailMaliciousFile : TeaModel {
                /// <summary>
                /// The malicious samples.
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<CreateOpaStrategyNewRequestAlarmDetailMaliciousFileItem> Item { get; set; }
                public class CreateOpaStrategyNewRequestAlarmDetailMaliciousFileItem : TeaModel {
                    /// <summary>
                    /// The ID of the malicious sample.
                    /// 
                    /// >  You can call the [DescribeMatchedMaliciousNames](~~DescribeMatchedMaliciousNames~~) operation to query the ID.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// The name of the malicious sample.
                    /// 
                    /// >  You can call the [DescribeMatchedMaliciousNames](~~DescribeMatchedMaliciousNames~~) operation to query the name.
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
            public CreateOpaStrategyNewRequestAlarmDetailSensitiveFile SensitiveFile { get; set; }
            public class CreateOpaStrategyNewRequestAlarmDetailSensitiveFile : TeaModel {
                /// <summary>
                /// The configuration of sensitive file.
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<CreateOpaStrategyNewRequestAlarmDetailSensitiveFileItem> Item { get; set; }
                public class CreateOpaStrategyNewRequestAlarmDetailSensitiveFileItem : TeaModel {
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
            /// The vulnerability risks.
            /// </summary>
            [NameInMap("Vul")]
            [Validation(Required=false)]
            public CreateOpaStrategyNewRequestAlarmDetailVul Vul { get; set; }
            public class CreateOpaStrategyNewRequestAlarmDetailVul : TeaModel {
                /// <summary>
                /// The vulnerabilities.
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<CreateOpaStrategyNewRequestAlarmDetailVulItem> Item { get; set; }
                public class CreateOpaStrategyNewRequestAlarmDetailVulItem : TeaModel {
                    /// <summary>
                    /// The ID of the vulnerability.
                    /// 
                    /// >  You can call the [DescribeVulListPage](https://help.aliyun.com/document_detail/471928.html) operation to query the ID.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// The name of the vulnerability.
                    /// 
                    /// >  You can call the [DescribeVulListPage](https://help.aliyun.com/document_detail/471928.html) operation to query the name.
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
                public List<CreateOpaStrategyNewRequestAlarmDetailVulRiskClass> RiskClass { get; set; }
                public class CreateOpaStrategyNewRequestAlarmDetailVulRiskClass : TeaModel {
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
        /// 
        /// > This parameter is deprecated.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The cluster name.
        /// 
        /// > This parameter is deprecated.
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// The rule description.
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
        /// The container tags.
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public List<string> Label { get; set; }

        /// <summary>
        /// Specifies whether the rule supports malicious Internet images. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("MaliciousImage")]
        [Validation(Required=false)]
        public bool? MaliciousImage { get; set; }

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
        /// The application scope of the rule.
        /// </summary>
        [NameInMap("Scopes")]
        [Validation(Required=false)]
        public List<CreateOpaStrategyNewRequestScopes> Scopes { get; set; }
        public class CreateOpaStrategyNewRequestScopes : TeaModel {
            /// <summary>
            /// The ID of the cluster node to which the rule is applied.
            /// 
            /// > This parameter is not required when you create the instance.
            /// </summary>
            [NameInMap("AckPolicyInstanceId")]
            [Validation(Required=false)]
            public string AckPolicyInstanceId { get; set; }

            /// <summary>
            /// Specifies whether to include all namespaces. Valid values:
            /// 
            /// *   **1**: includes all namespaces.
            /// *   **0**: does not include all namespaces.
            /// </summary>
            [NameInMap("AllNamespace")]
            [Validation(Required=false)]
            public int? AllNamespace { get; set; }

            /// <summary>
            /// The ID of the cluster that is specified in the rule.
            /// 
            /// >  You can call the [DescribeGroupedContainerInstances](https://help.aliyun.com/document_detail/421736.html) operation to query the cluster ID.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The namespaces.
            /// 
            /// > This parameter is valid only when the AllNamespace parameter is set to 0.
            /// </summary>
            [NameInMap("NamespaceList")]
            [Validation(Required=false)]
            public List<string> NamespaceList { get; set; }

        }

        /// <summary>
        /// The rule ID.
        /// 
        /// >  You can call the [ListOpaClusterStrategyNew](https://help.aliyun.com/document_detail/2623574.html) operation to query the rule ID.
        /// 
        /// > This parameter is invalid when you create a rule.
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
        /// 
        /// >  You can call the [GetOpaStrategyTemplateSummary](https://help.aliyun.com/document_detail/2539952.html) operation to query the ID of the rule template.
        /// </summary>
        [NameInMap("StrategyTemplateId")]
        [Validation(Required=false)]
        public long? StrategyTemplateId { get; set; }

        /// <summary>
        /// Specifies whether the rule supports unscanned images. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("UnScanedImage")]
        [Validation(Required=false)]
        public bool? UnScanedImage { get; set; }

        /// <summary>
        /// The whitelist.
        /// </summary>
        [NameInMap("WhiteList")]
        [Validation(Required=false)]
        public List<string> WhiteList { get; set; }

    }

}
