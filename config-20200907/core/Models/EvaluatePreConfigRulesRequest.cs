// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class EvaluatePreConfigRulesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable rule templates. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables rule templates.</para>
        /// </description></item>
        /// <item><description><para>false (default): does not enable rule templates.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableManagedRules")]
        [Validation(Required=false)]
        public bool? EnableManagedRules { get; set; }

        /// <summary>
        /// <para>An array that contains the resources that you want to evaluate.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceEvaluateItems")]
        [Validation(Required=false)]
        public List<EvaluatePreConfigRulesRequestResourceEvaluateItems> ResourceEvaluateItems { get; set; }
        public class EvaluatePreConfigRulesRequestResourceEvaluateItems : TeaModel {
            /// <summary>
            /// <para>The logical ID of the resource.</para>
            /// <remarks>
            /// <para>If this parameter is empty, it is generated based on the Base64 value of <c>ResourceProperties</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ResourceLogicId-test</para>
            /// </summary>
            [NameInMap("ResourceLogicalId")]
            [Validation(Required=false)]
            public string ResourceLogicalId { get; set; }

            /// <summary>
            /// <para>The resource configuration items (properties of the resource to be created), such as the specifications, region, name, status, and port or network interface switch status of the resource.</para>
            /// <remarks>
            /// <para>The <c>ResourceType</c>, <c>Identifier</c>, and <c>ResourceProperties</c> parameters must be specified at the same time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ResourceGroupId&quot;:&quot;&quot;,&quot;Memory&quot;:8192,&quot;InstanceChargeType&quot;:&quot;PostPaid&quot;,&quot;Cpu&quot;:2}</para>
            /// </summary>
            [NameInMap("ResourceProperties")]
            [Validation(Required=false)]
            public string ResourceProperties { get; set; }

            /// <summary>
            /// <para>The type of the resource.</para>
            /// <para>For information about how to obtain the identifier of an evaluation rule, see <a href="https://help.aliyun.com/document_detail/467810.html">ListPreManagedRules</a>.</para>
            /// <remarks>
            /// <para>The <c>ResourceType</c>, <c>Identifier</c>, and <c>ResourceProperties</c> parameters must be specified at the same time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::ECS::Instance</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>An array that contains the evaluation rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<EvaluatePreConfigRulesRequestResourceEvaluateItemsRules> Rules { get; set; }
            public class EvaluatePreConfigRulesRequestResourceEvaluateItemsRules : TeaModel {
                /// <summary>
                /// <para>The identifier of the rule.</para>
                /// <para>For information about how to obtain the identifier of a rule, see <a href="https://help.aliyun.com/document_detail/467810.html">ListPreManagedRules</a>.</para>
                /// <remarks>
                /// <para>The <c>ResourceType</c>, <c>Identifier</c>, and <c>ResourceProperties</c> parameters must be specified at the same time.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>ecs-instance-deletion-protection-enabled</para>
                /// </summary>
                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// <para>The input parameters of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("InputParameters")]
                [Validation(Required=false)]
                public string InputParameters { get; set; }

            }

        }

        /// <summary>
        /// <para>The query start token</para>
        /// 
        /// <b>Example:</b>
        /// <para>ros</para>
        /// </summary>
        [NameInMap("ResourceTypeFormat")]
        [Validation(Required=false)]
        public string ResourceTypeFormat { get; set; }

    }

}
