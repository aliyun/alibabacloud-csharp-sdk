// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class CreateTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The content of the template.</para>
        /// <para>For more information about the template syntax, see <a href="https://help.aliyun.com/document_detail/184397.html">Structure of Terraform templates</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;,
        ///   &quot;Transform&quot;: &quot;Aliyun::Terraform-v1.1&quot;,
        ///   &quot;Workspace&quot;: {
        ///     &quot;main.tf&quot;: &quot;variable  \&quot;name\&quot; {  default = \&quot;auto_provisioning_group\&quot;}&quot;
        ///   },
        ///   &quot;Outputs&quot;: {}
        /// }</para>
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The type of the product template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RosTerraformTemplate: the Terraform template that is supported by Resource Orchestration Service (ROS).</description></item>
        /// <item><description>RosStandardTemplate: the standard ROS template.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RosTerraformTemplate</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// <para>The variable settings of the Terraform template. You can configure the variables in a structured manner. Service Catalog applies the variable settings to the template.</para>
        /// <remarks>
        /// <para> The variables must be defined in the Terraform template.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TerraformVariables")]
        [Validation(Required=false)]
        public List<CreateTemplateRequestTerraformVariables> TerraformVariables { get; set; }
        public class CreateTemplateRequestTerraformVariables : TeaModel {
            /// <summary>
            /// <para>The description of the variable.</para>
            /// <para>For more information about the format of variable descriptions, see <a href="https://help.aliyun.com/document_detail/322216.html">Methods and suggestions for Terraform code development</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;Label&quot;: { &quot;en&quot;: &quot;Instance Type&quot; }, &quot;AllowedValues&quot;: [ &quot;ecs.s6-c1m1.small&quot;, &quot;ecs.s6-c1m2.large&quot;, &quot;ecs.s6-c1m2.xlarge&quot; ] }</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the variable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance_type</para>
            /// </summary>
            [NameInMap("VariableName")]
            [Validation(Required=false)]
            public string VariableName { get; set; }

        }

    }

}
