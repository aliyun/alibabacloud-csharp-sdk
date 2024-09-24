// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ValidateTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>No description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The outputs of the template.</para>
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public List<ValidateTemplateResponseBodyOutputs> Outputs { get; set; }
        public class ValidateTemplateResponseBodyOutputs : TeaModel {
            /// <summary>
            /// <para>The description of the template output.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The instance ID of my ECS.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The alias of the template output.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Instance ID</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>The name of the template output.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance_id</para>
            /// </summary>
            [NameInMap("OutputKey")]
            [Validation(Required=false)]
            public string OutputKey { get; set; }

        }

        /// <summary>
        /// <para>The parameters that are defined in the Parameters section of the template.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Parameters { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B288A0BE-D927-4888-B0F7-B35EF84B6E6F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource types that are used in the template.</para>
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public ValidateTemplateResponseBodyResourceTypes ResourceTypes { get; set; }
        public class ValidateTemplateResponseBodyResourceTypes : TeaModel {
            /// <summary>
            /// <para>The DataSource resource types that are used in the template. The value is deduplicated.</para>
            /// </summary>
            [NameInMap("DataSources")]
            [Validation(Required=false)]
            public List<string> DataSources { get; set; }

            /// <summary>
            /// <para>The regular resource types that are used in the template. The value is deduplicated.</para>
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<string> Resources { get; set; }

        }

        /// <summary>
        /// <para>The regular resources that are defined in the template.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For a Resource Orchestration Service (ROS) template, the resource whose definition contains <c>Count</c> is not displayed as a list.</description></item>
        /// <item><description>For a Terraform template, the resource whose definition contains <c>count</c> or <c>for_each</c> is not displayed as a list.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ValidateTemplateResponseBodyResources> Resources { get; set; }
        public class ValidateTemplateResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>The pattern in which the logical IDs of regular resources are formed.</para>
            /// <para>If resources are defined in a ROS template, the following rules apply:</para>
            /// <list type="bullet">
            /// <item><description>Resource whose definition does not contain <c>Count</c>: If the resource name defined in the template is <c>server</c>, the values of LogicalResourceIdPattern and <c>ResourcePath</c> are both <c>server</c>.``</description></item>
            /// <item><description>Resource whose definition contains <c>Count</c>: If the resource name defined in the template is <c>server</c>, the value of LogicalResourceIdPattern is <c>server[*]</c>, and the value of <c>ResourcePath</c> is <c>server</c>.</description></item>
            /// </list>
            /// <para>If resources and <a href="https://www.terraform.io/language/modules">modules</a> are defined in a Terraform template, the following rules apply:</para>
            /// <list type="bullet">
            /// <item><description>Resource and module whose definitions do not contain <a href="https://www.terraform.io/language/meta-arguments/count"><c>count</c></a> or <a href="https://www.terraform.io/language/meta-arguments/for_each"><c>for_each</c></a>: If the resource name defined in the template is <c>server</c>, the values of LogicalResourceIdPattern and <c>ResourcePath</c> are both <c>server</c>.``</description></item>
            /// <item><description>Resource and module whose definitions contain <a href="https://www.terraform.io/language/meta-arguments/count"><c>count</c></a> or <a href="https://www.terraform.io/language/meta-arguments/for_each"><c>for_each</c></a>: If the resource name defined in the template is <c>server</c>, the value of LogicalResourceIdPattern is <c>server[*]</c>, and the value of <c>ResourcePath</c> is <c>server</c>.</description></item>
            /// </list>
            /// <para>Examples of LogicalResourceIdPattern for resources in a Terraform template:</para>
            /// <list type="bullet">
            /// <item><description><para>Valid values of LogicalResourceIdPattern if a resource belongs to the root module:</para>
            /// <list type="bullet">
            /// <item><description><c>server</c>: In this case, <c>count</c> and <c>for_each</c> are not contained in the resource. The value of <c>ResourcePath</c> is <c>server</c>.</description></item>
            /// <item><description><c>server[*]</c>: In this case, <c>count</c> or <c>for_each</c> is contained in the resource. The value of <c>ResourcePath</c> is <c>server</c>.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Valid values of LogicalResourceIdPattern if a resource belongs to a child module:</para>
            /// <list type="bullet">
            /// <item><description><c>app.server</c>: In this case, <c>count</c> and <c>for_each</c> are not contained in the <c>app</c> module and the <c>server</c> resource. The value of <c>ResourcePath</c> is <c>app.server</c>.````</description></item>
            /// <item><description><c>app.server[*]</c>: In this case, <c>count</c> or <c>for_each</c> is contained in the <c>server</c> resource, but <c>count</c> and <c>for_each</c> are not contained in the <c>app</c> module. The value of <c>ResourcePath</c> is <c>app.server</c>.</description></item>
            /// <item><description><c>app[*].server</c>: In this case, <c>count</c> or <c>for_each</c> is contained in the <c>app</c> module, but <c>count</c> and <c>for_each</c> are not contained in the <c>server</c> resource. The value of <c>ResourcePath</c> is <c>app.server</c>.</description></item>
            /// <item><description><c>app[*].server[*]</c>: In this case, <c>count</c> or <c>for_each</c> is contained in the <c>app</c> module and the <c>server</c> resource. The value of <c>ResourcePath</c> is <c>app.server</c>.````</description></item>
            /// <item><description><c>app.app_group[*].server</c>: In this case, <c>count</c> or <c>for_each</c> is contained in the <c>app_group</c> module, but <c>count</c> and <c>for_each</c> are not contained in the <c>app</c> module and the <c>server</c> resource. The value of <c>ResourcePath</c> is <c>app.app_group.server</c>. The <c>app_group</c> module is a child module of the <c>app</c> module.````</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>server</para>
            /// </summary>
            [NameInMap("LogicalResourceIdPattern")]
            [Validation(Required=false)]
            public string LogicalResourceIdPattern { get; set; }

            /// <summary>
            /// <para>The path of the regular resource. In most cases, the path of a regular resource is the same as the resource name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>server</para>
            /// </summary>
            [NameInMap("ResourcePath")]
            [Validation(Required=false)]
            public string ResourcePath { get; set; }

            /// <summary>
            /// <para>The regular resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN::ECS::InstanceGroup</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>The information about the stack update. This parameter cannot be returned if the value of UpdateInfoOptions contains Disabled.</para>
        /// </summary>
        [NameInMap("UpdateInfo")]
        [Validation(Required=false)]
        public ValidateTemplateResponseBodyUpdateInfo UpdateInfo { get; set; }
        public class ValidateTemplateResponseBodyUpdateInfo : TeaModel {
            /// <summary>
            /// <para>The parameters that can be modified.</para>
            /// </summary>
            [NameInMap("ParametersAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersAllowedToBeModified { get; set; }

            /// <summary>
            /// <para>The parameters whose changes cause service interruptions.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is supported only for a small number of resource types.</description></item>
            /// <item><description>This parameter is valid only for updates on ROS stacks.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersCauseInterruptionIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersCauseInterruptionIfModified { get; set; }

            /// <summary>
            /// <para>The parameters whose changes trigger replacement updates for resources.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter can be returned only if the value of UpdateInfoOptions contains EnableReplacement.</description></item>
            /// <item><description>This parameter is valid only for updates on ROS stacks.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersCauseReplacementIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersCauseReplacementIfModified { get; set; }

            /// <summary>
            /// <para>The parameters that can be modified under specific conditions.</para>
            /// </summary>
            [NameInMap("ParametersConditionallyAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersConditionallyAllowedToBeModified { get; set; }

            /// <summary>
            /// <para>The parameters whose changes cause service interruptions under specific conditions.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is supported only for a small number of resource types.</description></item>
            /// <item><description>This parameter is valid only for updates on ROS stacks.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersConditionallyCauseInterruptionIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersConditionallyCauseInterruptionIfModified { get; set; }

            /// <summary>
            /// <para>The parameters whose changes trigger replacement updates for resources under specific conditions.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter can be returned only if the value of UpdateInfoOptions contains EnableReplacement.</description></item>
            /// <item><description>This parameter is valid only for updates on ROS stacks.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersConditionallyCauseReplacementIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersConditionallyCauseReplacementIfModified { get; set; }

            /// <summary>
            /// <para>The parameters that cannot be modified.</para>
            /// </summary>
            [NameInMap("ParametersNotAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersNotAllowedToBeModified { get; set; }

            /// <summary>
            /// <para>The parameters that can be modified under uncertain conditions.</para>
            /// </summary>
            [NameInMap("ParametersUncertainlyAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersUncertainlyAllowedToBeModified { get; set; }

            /// <summary>
            /// <para>The parameters whose changes cause service interruptions under uncertain conditions.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is supported only for a small number of resource types.</description></item>
            /// <item><description>This parameter is valid only for updates on ROS stacks.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersUncertainlyCauseInterruptionIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersUncertainlyCauseInterruptionIfModified { get; set; }

            /// <summary>
            /// <para>The parameters whose changes trigger replacement updates for resources under uncertain conditions.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter can be returned only if the value of UpdateInfoOptions contains EnableReplacement.</description></item>
            /// <item><description>This parameter is valid only for updates on ROS stacks.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersUncertainlyCauseReplacementIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersUncertainlyCauseReplacementIfModified { get; set; }

        }

    }

}
