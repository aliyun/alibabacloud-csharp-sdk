// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateOpaStrategyNewRequest : TeaModel {
        /// <summary>
        /// The risks that you want to detect by using the rule on images.
        /// </summary>
        [NameInMap("AlarmDetail")]
        [Validation(Required=false)]
        public UpdateOpaStrategyNewRequestAlarmDetail AlarmDetail { get; set; }
        public class UpdateOpaStrategyNewRequestAlarmDetail : TeaModel {
            /// <summary>
            /// The baseline risks.
            /// </summary>
            [NameInMap("Baseline")]
            [Validation(Required=false)]
            public UpdateOpaStrategyNewRequestAlarmDetailBaseline Baseline { get; set; }
            public class UpdateOpaStrategyNewRequestAlarmDetailBaseline : TeaModel {
                /// <summary>
                /// The baseline check items.
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<UpdateOpaStrategyNewRequestAlarmDetailBaselineItem> Item { get; set; }
                public class UpdateOpaStrategyNewRequestAlarmDetailBaselineItem : TeaModel {
                    /// <summary>
                    /// The ID of the baseline check item.
                    /// 
                    /// >  You can call the [GetOpaClusterBaseLineList](~~2539883~~) operation to query the IDs of check items.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// The name of the baseline check item.
                    /// 
                    /// >  You can call the [GetOpaClusterBaseLineList](~~2539883~~) operation to query the names of check items.
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
            public UpdateOpaStrategyNewRequestAlarmDetailMaliciousFile MaliciousFile { get; set; }
            public class UpdateOpaStrategyNewRequestAlarmDetailMaliciousFile : TeaModel {
                /// <summary>
                /// The malicious samples.
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<UpdateOpaStrategyNewRequestAlarmDetailMaliciousFileItem> Item { get; set; }
                public class UpdateOpaStrategyNewRequestAlarmDetailMaliciousFileItem : TeaModel {
                    /// <summary>
                    /// The ID of the malicious sample.
                    /// 
                    /// >  You can call the [DescribeMatchedMaliciousNames](~~DescribeMatchedMaliciousNames~~) operation to query the IDs of malicious samples.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// The name of the malicious sample.
                    /// 
                    /// >  You can call the [DescribeMatchedMaliciousNames](~~DescribeMatchedMaliciousNames~~) operation to query the names of malicious samples.
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
            public UpdateOpaStrategyNewRequestAlarmDetailVul Vul { get; set; }
            public class UpdateOpaStrategyNewRequestAlarmDetailVul : TeaModel {
                /// <summary>
                /// The vulnerabilities.
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public List<UpdateOpaStrategyNewRequestAlarmDetailVulItem> Item { get; set; }
                public class UpdateOpaStrategyNewRequestAlarmDetailVulItem : TeaModel {
                    /// <summary>
                    /// The ID of the vulnerability.
                    /// 
                    /// >  You can call the [DescribeVulListPage](~~471928~~) operation to query the IDs of vulnerabilities.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// The name of the vulnerability.
                    /// 
                    /// >  You can call the [DescribeVulListPage](~~471928~~) operation to query the names of vulnerabilities.
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
        /// The ID of the cluster.
        /// 
        /// > This parameter is deprecated. We recommend that you use the Scopes parameter to specify the clusters in which the rule takes effect.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The name of the cluster.
        /// 
        /// > This parameter is deprecated.
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
        /// The names of the images in the rule.
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public List<string> ImageName { get; set; }

        /// <summary>
        /// The tags that are added to the images in the rule.
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
        /// The effective scope of the rule.
        /// </summary>
        [NameInMap("Scopes")]
        [Validation(Required=false)]
        public List<UpdateOpaStrategyNewRequestScopes> Scopes { get; set; }
        public class UpdateOpaStrategyNewRequestScopes : TeaModel {
            /// <summary>
            /// The instance ID of the rule in the cluster.
            /// 
            /// >  You can call the [GetOpaStrategyDetailNew](~~GetOpaStrategyDetailNew~~) operation to query the instance IDs of rules.
            /// </summary>
            [NameInMap("AckPolicyInstanceId")]
            [Validation(Required=false)]
            public string AckPolicyInstanceId { get; set; }

            /// <summary>
            /// Specifies whether to include all namespaces.
            /// 
            /// *   **0**: no
            /// *   **1**: yes
            /// </summary>
            [NameInMap("AllNamespace")]
            [Validation(Required=false)]
            public int? AllNamespace { get; set; }

            /// <summary>
            /// The ID of the container cluster.
            /// 
            /// >  You can call the [DescribeGroupedContainerInstances](~~DescribeGroupedContainerInstances~~) operation to query the IDs of container clusters.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The namespaces.
            /// 
            /// > This parameter is valid only when AllNamespace is set to 0.
            /// </summary>
            [NameInMap("NamespaceList")]
            [Validation(Required=false)]
            public List<string> NamespaceList { get; set; }

        }

        /// <summary>
        /// The ID of the rule.
        /// 
        /// >  You can call the \[ListOpaClusterStrategyNew]\(~~2623574~~) operation to query the IDs of rules.
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
        /// The ID of the rule template.
        /// 
        /// >  You can call the [GetOpaStrategyTemplateSummary](~~2539952~~) operation to query the IDs of rule templates.
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
