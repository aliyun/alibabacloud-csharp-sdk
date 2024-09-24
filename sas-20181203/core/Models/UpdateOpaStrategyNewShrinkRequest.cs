// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateOpaStrategyNewShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The risks that you want to detect by using the rule.</para>
        /// </summary>
        [NameInMap("AlarmDetail")]
        [Validation(Required=false)]
        public string AlarmDetailShrink { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>This parameter is deprecated. You can use the Scopes parameter to specify a scope in which cluster parameters take effect.</para>
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
        /// <para>This parameter is deprecated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>docker-law</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The rule description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4566</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The image names.</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public List<string> ImageName { get; set; }

        /// <summary>
        /// <para>The image tags.</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public List<string> Label { get; set; }

        /// <summary>
        /// <para>Specifies whether the rule supports malicious Internet images. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MaliciousImage")]
        [Validation(Required=false)]
        public bool? MaliciousImage { get; set; }

        /// <summary>
        /// <para>The action that is performed when the rule is hit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: alert</description></item>
        /// <item><description><b>2</b>: block</description></item>
        /// <item><description><b>3</b>: allow</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleAction")]
        [Validation(Required=false)]
        public int? RuleAction { get; set; }

        /// <summary>
        /// <para>The application scope.</para>
        /// </summary>
        [NameInMap("Scopes")]
        [Validation(Required=false)]
        public List<UpdateOpaStrategyNewShrinkRequestScopes> Scopes { get; set; }
        public class UpdateOpaStrategyNewShrinkRequestScopes : TeaModel {
            /// <summary>
            /// <para>The ID of the cluster node to which the rule is applied.</para>
            /// <remarks>
            /// <para> You can call the <a href="~~GetOpaStrategyDetailNew~~">GetOpaStrategyDetailNew</a> operation to query the ID of the cluster node to which the rule is applied.</para>
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
            /// <item><description><b>0</b>: Not all namespaces are included.</description></item>
            /// <item><description><b>1</b>: All namespaces are included.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AllNamespace")]
            [Validation(Required=false)]
            public int? AllNamespace { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// <remarks>
            /// <para> You can call the <a href="~~DescribeGroupedContainerInstances~~">DescribeGroupedContainerInstances</a> operation to query the cluster ID.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cdcb56a931c**</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The namespaces.</para>
            /// <remarks>
            /// <para>This parameter is valid only when the AllNamespace parameter is set to 0.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("NamespaceList")]
            [Validation(Required=false)]
            public List<string> NamespaceList { get; set; }

        }

        /// <summary>
        /// <para>The ID of the rule.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2623574.html">ListOpaClusterStrategyNew</a> operation to query the ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1003</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public long? StrategyId { get; set; }

        /// <summary>
        /// <para>The rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

        /// <summary>
        /// <para>The ID of the rule template.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2539952.html">GetOpaStrategyTemplateSummary</a> operation to query the ID of the rule template.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>109</para>
        /// </summary>
        [NameInMap("StrategyTemplateId")]
        [Validation(Required=false)]
        public long? StrategyTemplateId { get; set; }

        /// <summary>
        /// <para>Specifies whether the rule supports unscanned images. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UnScanedImage")]
        [Validation(Required=false)]
        public bool? UnScanedImage { get; set; }

        /// <summary>
        /// <para>The whitelists.</para>
        /// </summary>
        [NameInMap("WhiteList")]
        [Validation(Required=false)]
        public List<string> WhiteList { get; set; }

    }

}
