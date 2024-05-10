// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateOpaStrategyNewRequest : TeaModel {
        /// <summary>
        /// The rule configuration.
        /// </summary>
        [NameInMap("AlarmDetail")]
        [Validation(Required=false)]
        public UpdateOpaStrategyNewRequestAlarmDetail AlarmDetail { get; set; }
        public class UpdateOpaStrategyNewRequestAlarmDetail : TeaModel {
            /// <summary>
            /// The baseline check configuration.
            /// </summary>
            [NameInMap("Baseline")]
            [Validation(Required=false)]
            public UpdateOpaStrategyNewRequestAlarmDetailBaseline Baseline { get; set; }
            public class UpdateOpaStrategyNewRequestAlarmDetailBaseline : TeaModel {
                /// <summary>
                /// The baseline check configuration.
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<UpdateOpaStrategyNewRequestAlarmDetailBaselineItem> Item { get; set; }
                public class UpdateOpaStrategyNewRequestAlarmDetailBaselineItem : TeaModel {
                    /// <summary>
                    /// The ID of the baseline check item.
                    /// 
                    /// >  You can call the [GetOpaClusterBaseLineList](https://help.aliyun.com/document_detail/2539883.html) operation to query the ID of the baseline check item.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// The name of the baseline check item.
                    /// 
                    /// >  You can call the [GetOpaClusterBaseLineList](https://help.aliyun.com/document_detail/2539883.html) operation to query the name of the baseline check item.
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
            public UpdateOpaStrategyNewRequestAlarmDetailBuildRisk BuildRisk { get; set; }
            public class UpdateOpaStrategyNewRequestAlarmDetailBuildRisk : TeaModel {
                /// <summary>
                /// The configuration of image build risk.
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<UpdateOpaStrategyNewRequestAlarmDetailBuildRiskItem> Item { get; set; }
                public class UpdateOpaStrategyNewRequestAlarmDetailBuildRiskItem : TeaModel {
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
            public UpdateOpaStrategyNewRequestAlarmDetailMaliciousFile MaliciousFile { get; set; }
            public class UpdateOpaStrategyNewRequestAlarmDetailMaliciousFile : TeaModel {
                /// <summary>
                /// The configuration of malicious samples.
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<UpdateOpaStrategyNewRequestAlarmDetailMaliciousFileItem> Item { get; set; }
                public class UpdateOpaStrategyNewRequestAlarmDetailMaliciousFileItem : TeaModel {
                    /// <summary>
                    /// The ID of the malicious sample.
                    /// 
                    /// >  You can call the [DescribeMatchedMaliciousNames](~~DescribeMatchedMaliciousNames~~) operation to query the ID of the malicious sample.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// The name of the malicious sample.
                    /// 
                    /// >  You can call the [DescribeMatchedMaliciousNames](~~DescribeMatchedMaliciousNames~~) operation to query the name of the malicious sample.
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
            public UpdateOpaStrategyNewRequestAlarmDetailSensitiveFile SensitiveFile { get; set; }
            public class UpdateOpaStrategyNewRequestAlarmDetailSensitiveFile : TeaModel {
                /// <summary>
                /// The configuration of sensitive file.
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<UpdateOpaStrategyNewRequestAlarmDetailSensitiveFileItem> Item { get; set; }
                public class UpdateOpaStrategyNewRequestAlarmDetailSensitiveFileItem : TeaModel {
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
            public UpdateOpaStrategyNewRequestAlarmDetailVul Vul { get; set; }
            public class UpdateOpaStrategyNewRequestAlarmDetailVul : TeaModel {
                /// <summary>
                /// The information about the vulnerability.
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<UpdateOpaStrategyNewRequestAlarmDetailVulItem> Item { get; set; }
                public class UpdateOpaStrategyNewRequestAlarmDetailVulItem : TeaModel {
                    /// <summary>
                    /// The vulnerability ID.
                    /// 
                    /// >  You can call the [DescribeVulListPage](https://help.aliyun.com/document_detail/471928.html) operation to query the vulnerability ID.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// The vulnerability name.
                    /// 
                    /// >  You can call the [DescribeVulListPage](https://help.aliyun.com/document_detail/471928.html) operation to query the vulnerability name.
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
                public List<UpdateOpaStrategyNewRequestAlarmDetailVulRiskClass> RiskClass { get; set; }
                public class UpdateOpaStrategyNewRequestAlarmDetailVulRiskClass : TeaModel {
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
        /// > This parameter is deprecated. You can use the Scopes parameter to specify a scope in which cluster parameters take effect.
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
        /// The image tags.
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
        /// *   **1**: alert
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
        public List<UpdateOpaStrategyNewRequestScopes> Scopes { get; set; }
        public class UpdateOpaStrategyNewRequestScopes : TeaModel {
            /// <summary>
            /// The ID of the cluster node to which the rule is applied.
            /// 
            /// >  You can call the [GetOpaStrategyDetailNew](~~GetOpaStrategyDetailNew~~) operation to query the ID of the cluster node to which the rule is applied.
            /// </summary>
            [NameInMap("AckPolicyInstanceId")]
            [Validation(Required=false)]
            public string AckPolicyInstanceId { get; set; }

            /// <summary>
            /// Specifies whether all namespaces are included. Valid values:
            /// 
            /// *   **0**: Not all namespaces are included.
            /// *   **1**: All namespaces are included.
            /// </summary>
            [NameInMap("AllNamespace")]
            [Validation(Required=false)]
            public int? AllNamespace { get; set; }

            /// <summary>
            /// The cluster ID.
            /// 
            /// >  You can call the [DescribeGroupedContainerInstances](~~DescribeGroupedContainerInstances~~) operation to query the cluster ID.
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
        /// The whitelists.
        /// </summary>
        [NameInMap("WhiteList")]
        [Validation(Required=false)]
        public List<string> WhiteList { get; set; }

    }

}
