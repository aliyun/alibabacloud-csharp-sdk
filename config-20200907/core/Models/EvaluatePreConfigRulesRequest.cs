// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class EvaluatePreConfigRulesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the managed rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables the managed rule.</description></item>
        /// <item><description>false: does not enable the managed rule. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para> After you create an evaluation rule, a managed rule that has the same settings as the evaluation rule is created. After you create a resource, the managed rule can be used to continuously check the compliance of the resource.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableManagedRules")]
        [Validation(Required=false)]
        public bool? EnableManagedRules { get; set; }

        /// <summary>
        /// <para>The resources that you want to evaluate.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceEvaluateItems")]
        [Validation(Required=false)]
        public List<EvaluatePreConfigRulesRequestResourceEvaluateItems> ResourceEvaluateItems { get; set; }
        public class EvaluatePreConfigRulesRequestResourceEvaluateItems : TeaModel {
            /// <summary>
            /// <para>The logical ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ResourceLogicId-test</para>
            /// </summary>
            [NameInMap("ResourceLogicalId")]
            [Validation(Required=false)]
            public string ResourceLogicalId { get; set; }

            /// <summary>
            /// <para>The properties of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;ImageId&quot;: &quot;ubuntu_18_04_64_20G_alibase_20190624.vhd&quot;,
            ///     &quot;SecurityGroupId&quot;: &quot;sg-bp15ed6xe1yxeycg****&quot;,
            ///     &quot;HostName&quot;: &quot;LocalHostName&quot;,
            ///     &quot;RegionId&quot;: &quot;cn-hangzhou&quot;
            /// }</para>
            /// </summary>
            [NameInMap("ResourceProperties")]
            [Validation(Required=false)]
            public string ResourceProperties { get; set; }

            /// <summary>
            /// <para>The type of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::ECS::Instance</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The evaluation rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<EvaluatePreConfigRulesRequestResourceEvaluateItemsRules> Rules { get; set; }
            public class EvaluatePreConfigRulesRequestResourceEvaluateItemsRules : TeaModel {
                /// <summary>
                /// <para>The identifier of the evaluation rule.</para>
                /// <para>For more information about how to obtain the identifier of an evaluation rule, see <a href="https://help.aliyun.com/document_detail/467810.html">ListManagedRules</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs-instance-deletion-protection-enabled</para>
                /// </summary>
                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// <para>The input parameters of the evaluation rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("InputParameters")]
                [Validation(Required=false)]
                public string InputParameters { get; set; }

            }

        }

        [NameInMap("ResourceTypeFormat")]
        [Validation(Required=false)]
        public string ResourceTypeFormat { get; set; }

    }

}
