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
        /// > This parameter is deprecated.
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
        /// The names of the images.
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
        public List<CreateOpaStrategyNewRequestScopes> Scopes { get; set; }
        public class CreateOpaStrategyNewRequestScopes : TeaModel {
            /// <summary>
            /// The rule instance ID in the cluster.
            /// 
            /// > This parameter is invalid when you create a rule.
            /// </summary>
            [NameInMap("AckPolicyInstanceId")]
            [Validation(Required=false)]
            public string AckPolicyInstanceId { get; set; }

            /// <summary>
            /// Specifies whether to include all namespaces. Valid values:
            /// 
            /// *   **1**: yes
            /// *   **0**: no
            /// </summary>
            [NameInMap("AllNamespace")]
            [Validation(Required=false)]
            public int? AllNamespace { get; set; }

            /// <summary>
            /// The ID of the cluster in the rule.
            /// 
            /// >  You can call the [DescribeGroupedContainerInstances](~~421736~~) operation to query the IDs of clusters.
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
        /// >  You can call the [ListOpaClusterStrategyNew](~~2623574~~) operation to query the IDs of rules.
        /// 
        /// > This parameter is invalid when you create a rule.
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
