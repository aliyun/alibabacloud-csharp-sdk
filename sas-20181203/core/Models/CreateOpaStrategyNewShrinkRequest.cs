// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateOpaStrategyNewShrinkRequest : TeaModel {
        /// <summary>
        /// The risks that you want to detect by using the rule.
        /// </summary>
        [NameInMap("AlarmDetail")]
        [Validation(Required=false)]
        public string AlarmDetailShrink { get; set; }

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
        public List<CreateOpaStrategyNewShrinkRequestScopes> Scopes { get; set; }
        public class CreateOpaStrategyNewShrinkRequestScopes : TeaModel {
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
