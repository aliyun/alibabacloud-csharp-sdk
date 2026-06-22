// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateOpaStrategyNewShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The alert content details included in the policy.</para>
        /// </summary>
        [NameInMap("AlarmDetail")]
        [Validation(Required=false)]
        public string AlarmDetailShrink { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>Notice: This parameter is deprecated. Use the Scopes parameter to specify the scope of clusters to which the policy applies..</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>c870ec78ecbcb41d2a35c679823ef****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The cluster name.</para>
        /// <remarks>
        /// <para>Notice: This parameter is deprecated..</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>docker-law</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The policy description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4566</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of image names included in the policy.</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public List<string> ImageName { get; set; }

        /// <summary>
        /// <para>The list of image tags included in the policy.</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public List<string> Label { get; set; }

        /// <summary>
        /// <para>Specifies whether the policy supports Internet malicious images. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Supported.</description></item>
        /// <item><description><b>false</b>: Not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MaliciousImage")]
        [Validation(Required=false)]
        public bool? MaliciousImage { get; set; }

        /// <summary>
        /// <para>The action to take when the policy is hit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Alert.</description></item>
        /// <item><description><b>2</b>: Block.</description></item>
        /// <item><description><b>3</b>: Allow.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleAction")]
        [Validation(Required=false)]
        public int? RuleAction { get; set; }

        /// <summary>
        /// <para>The scope of the policy.</para>
        /// </summary>
        [NameInMap("Scopes")]
        [Validation(Required=false)]
        public List<UpdateOpaStrategyNewShrinkRequestScopes> Scopes { get; set; }
        public class UpdateOpaStrategyNewShrinkRequestScopes : TeaModel {
            /// <summary>
            /// <para>The policy instance ID in the cluster.</para>
            /// <remarks>
            /// <para>Call the <a href="~~GetOpaStrategyDetailNew~~">GetOpaStrategyDetailNew</a> operation to obtain this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ack-1</para>
            /// </summary>
            [NameInMap("AckPolicyInstanceId")]
            [Validation(Required=false)]
            public string AckPolicyInstanceId { get; set; }

            /// <summary>
            /// <para>Specifies whether all namespaces are included. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No.</description></item>
            /// <item><description><b>1</b>: Yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AllNamespace")]
            [Validation(Required=false)]
            public int? AllNamespace { get; set; }

            /// <summary>
            /// <para>The ID of the container cluster.</para>
            /// <remarks>
            /// <para>Call the <a href="~~DescribeGroupedContainerInstances~~">DescribeGroupedContainerInstances</a> operation to obtain this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cdcb56a931c**</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The list of namespaces.</para>
            /// <remarks>
            /// <para>Notice: This parameter takes effect only when AllNamespace is set to 0..</para>
            /// </remarks>
            /// </summary>
            [NameInMap("NamespaceList")]
            [Validation(Required=false)]
            public List<string> NamespaceList { get; set; }

        }

        /// <summary>
        /// <para>The policy ID.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2623574.html">ListOpaClusterStrategyNew</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1003</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public long? StrategyId { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

        /// <summary>
        /// <para>The policy template ID.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/2539952.html">GetOpaStrategyTemplateSummary</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>109</para>
        /// </summary>
        [NameInMap("StrategyTemplateId")]
        [Validation(Required=false)]
        public long? StrategyTemplateId { get; set; }

        /// <summary>
        /// <para>Specifies whether the policy supports unscanned images. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Supported.</description></item>
        /// <item><description><b>false</b>: Not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UnScanedImage")]
        [Validation(Required=false)]
        public bool? UnScanedImage { get; set; }

        /// <summary>
        /// <para>The whitelist.</para>
        /// </summary>
        [NameInMap("WhiteList")]
        [Validation(Required=false)]
        public List<string> WhiteList { get; set; }

    }

}
