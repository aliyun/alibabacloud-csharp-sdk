// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ValidateTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the stack template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>No description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of template outputs.</para>
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
        /// <para>The list of input parameters.</para>
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
        /// <para>The information about the resource types that are used in the template.</para>
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public ValidateTemplateResponseBodyResourceTypes ResourceTypes { get; set; }
        public class ValidateTemplateResponseBodyResourceTypes : TeaModel {
            /// <summary>
            /// <para>The list of data source resource types. Duplicates are removed.</para>
            /// </summary>
            [NameInMap("DataSources")]
            [Validation(Required=false)]
            public List<string> DataSources { get; set; }

            /// <summary>
            /// <para>The list of regular resource types. Duplicates are removed.</para>
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<string> Resources { get; set; }

        }

        /// <summary>
        /// <para>The list of regular resources that are defined in the template.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>For ROS templates, resources whose definitions contain the <c>Count</c> field are not expanded.</para>
        /// </description></item>
        /// <item><description><para>For Terraform templates, resources whose definitions contain <c>count</c> or <c>for_each</c> are not expanded.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ValidateTemplateResponseBodyResources> Resources { get; set; }
        public class ValidateTemplateResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>The string pattern for the logical ID of the regular resource.</para>
            /// <para>For ROS templates, the following two cases exist:</para>
            /// <list type="bullet">
            /// <item><description><para>The resource definition does not contain the <c>Count</c> field: If the resource name defined in the template is <c>server</c>, the value of this parameter is <c>server</c>, and the value of <c>ResourcePath</c> is <c>server</c>.</para>
            /// </description></item>
            /// <item><description><para>The resource definition contains the <c>Count</c> field: If the resource name defined in the template is <c>server</c>, the value of this parameter is <c>server[*]</c>, and the value of <c>ResourcePath</c> is <c>server</c>.</para>
            /// </description></item>
            /// </list>
            /// <para>For resources and <a href="https://www.terraform.io/language/modules">modules</a> in Terraform templates, the following two cases exist:</para>
            /// <list type="bullet">
            /// <item><description><para>The definition does not contain <a href="https://www.terraform.io/language/meta-arguments/count"><c>count</c></a> or <a href="https://www.terraform.io/language/meta-arguments/for_each"><c>for_each</c></a>: If the name is <c>server</c>, the value of this parameter is <c>server</c>, and the value of <c>ResourcePath</c> is <c>server</c>.</para>
            /// </description></item>
            /// <item><description><para>The definition contains <a href="https://www.terraform.io/language/meta-arguments/count"><c>count</c></a> or <a href="https://www.terraform.io/language/meta-arguments/for_each"><c>for_each</c></a>: If the name is <c>server</c>, the value of this parameter is <c>server[*]</c>, and the value of <c>ResourcePath</c> is <c>server</c>.</para>
            /// </description></item>
            /// </list>
            /// <para>The following examples show the values for Terraform templates:</para>
            /// <list type="bullet">
            /// <item><description><para>Resources in the root module:</para>
            /// <list type="bullet">
            /// <item><description><para><c>server</c>: <c>count</c> and <c>for_each</c> are not used. The value of <c>ResourcePath</c> is <c>server</c>.</para>
            /// </description></item>
            /// <item><description><para><c>server[*]</c>: <c>count</c> or <c>for_each</c> is used. The value of <c>ResourcePath</c> is <c>server</c>.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Resources in a child module:</para>
            /// <list type="bullet">
            /// <item><description><para><c>app.server</c>: The <c>app</c> module does not use <c>count</c> or <c>for_each</c>, and the <c>server</c> resource does not use <c>count</c> or <c>for_each</c>. The value of <c>ResourcePath</c> is <c>app.server</c>.</para>
            /// </description></item>
            /// <item><description><para><c>app.server[*]</c>: The <c>app</c> module does not use <c>count</c> or <c>for_each</c>, but the <c>server</c> resource uses <c>count</c> or <c>for_each</c>. The value of <c>ResourcePath</c> is <c>app.server</c>.</para>
            /// </description></item>
            /// <item><description><para><c>app[*].server</c>: The <c>app</c> module uses <c>count</c> or <c>for_each</c>, but the <c>server</c> resource does not use <c>count</c> or <c>for_each</c>. The value of <c>ResourcePath</c> is <c>app.server</c>.</para>
            /// </description></item>
            /// <item><description><para><c>app[*].server[*]</c>: The <c>app</c> module uses <c>count</c> or <c>for_each</c>, and the <c>server</c> resource uses <c>count</c> or <c>for_each</c>. The value of <c>ResourcePath</c> is <c>app.server</c>.</para>
            /// </description></item>
            /// <item><description><para><c>app.app_group[*].server</c>: The <c>app</c> module does not use <c>count</c> or <c>for_each</c>, the <c>app_group</c> module uses <c>count</c> or <c>for_each</c> (the <c>app_group</c> module is a child module of the <c>app</c> module), and the <c>server</c> resource does not use <c>count</c> or <c>for_each</c>. The value of <c>ResourcePath</c> is <c>app.app_group.server</c>.</para>
            /// </description></item>
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
            /// <para>The path of the regular resource. The path is usually the same as the resource name.</para>
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
        /// <para>The information about the stack update. This parameter is not returned if Disabled is specified for UpdateInfoOptions.</para>
        /// </summary>
        [NameInMap("UpdateInfo")]
        [Validation(Required=false)]
        public ValidateTemplateResponseBodyUpdateInfo UpdateInfo { get; set; }
        public class ValidateTemplateResponseBodyUpdateInfo : TeaModel {
            /// <summary>
            /// <para>The list of parameters that can be modified.</para>
            /// </summary>
            [NameInMap("ParametersAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersAllowedToBeModified { get; set; }

            /// <summary>
            /// <para>The list of parameters that cause resource interruptions if they are modified.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter is supported for only a few resource types.</para>
            /// </description></item>
            /// <item><description><para>This parameter is applicable only to ROS stacks.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersCauseInterruptionIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersCauseInterruptionIfModified { get; set; }

            /// <summary>
            /// <para>The list of parameters that cause replacement updates if they are modified.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter is returned only if EnableReplacement is specified for UpdateInfoOptions.</para>
            /// </description></item>
            /// <item><description><para>This parameter is applicable only to ROS stacks.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersCauseReplacementIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersCauseReplacementIfModified { get; set; }

            /// <summary>
            /// <para>The list of parameters that may be allowed to be modified.</para>
            /// </summary>
            [NameInMap("ParametersConditionallyAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersConditionallyAllowedToBeModified { get; set; }

            /// <summary>
            /// <para>The list of parameters that may cause resource interruptions if they are modified.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter is supported for only a few resource types.</para>
            /// </description></item>
            /// <item><description><para>This parameter is applicable only to ROS stacks.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersConditionallyCauseInterruptionIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersConditionallyCauseInterruptionIfModified { get; set; }

            /// <summary>
            /// <para>The list of parameters that may cause replacement updates if they are modified.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter is returned only if EnableReplacement is specified for UpdateInfoOptions.</para>
            /// </description></item>
            /// <item><description><para>This parameter is applicable only to ROS stacks.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersConditionallyCauseReplacementIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersConditionallyCauseReplacementIfModified { get; set; }

            /// <summary>
            /// <para>The list of parameters that cannot be modified.</para>
            /// </summary>
            [NameInMap("ParametersNotAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersNotAllowedToBeModified { get; set; }

            /// <summary>
            /// <para>The list of parameters whose modification permissions are uncertain.</para>
            /// </summary>
            [NameInMap("ParametersUncertainlyAllowedToBeModified")]
            [Validation(Required=false)]
            public List<string> ParametersUncertainlyAllowedToBeModified { get; set; }

            /// <summary>
            /// <para>The list of parameters that cause resource interruptions under uncertain conditions if they are modified.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter is supported for only a few resource types.</para>
            /// </description></item>
            /// <item><description><para>This parameter is applicable only to ROS stacks.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersUncertainlyCauseInterruptionIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersUncertainlyCauseInterruptionIfModified { get; set; }

            /// <summary>
            /// <para>The list of parameters that cause replacement updates under uncertain conditions if they are modified.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter is returned only if EnableReplacement is specified for UpdateInfoOptions.</para>
            /// </description></item>
            /// <item><description><para>This parameter is applicable only to ROS stacks.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ParametersUncertainlyCauseReplacementIfModified")]
            [Validation(Required=false)]
            public List<string> ParametersUncertainlyCauseReplacementIfModified { get; set; }

        }

    }

}
