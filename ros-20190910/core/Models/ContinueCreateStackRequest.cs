// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ContinueCreateStackRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether only to validate the stack in the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: only validates the stack.</description></item>
        /// <item><description>false (default): validates and continues to create the stack.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The mode in which ROS continues to create the stack. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Recreate (default)</para>
        /// <para>If you set this parameter to Recreate, ROS continues to create only the following types of resources:</para>
        /// <list type="bullet">
        /// <item><description>Resources that fail to be created</description></item>
        /// <item><description>Resources that you specify for RecreatingResources.N</description></item>
        /// <item><description>Dependencies of the resources that you specify for RecreatingResources.N</description></item>
        /// <item><description>Resources that you have not created</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>RecreatingResources.N, TemplateBody, TemplateURL, and Parameters take effect only when Mode is set to Recreate.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Ignore</para>
        /// <list type="bullet">
        /// <item><description>ROS ignores and discards resources that fail to be created and you have not created, and considers that the stack is successfully created.</description></item>
        /// <item><description>The body of the template that you use to create the stack is changed.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This mode is available only for ROS stacks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Recreate</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The maximum number of concurrent operations that can be performed on resources.</para>
        /// <para>By default, this parameter is empty. You can set this parameter to an integer that is greater than or equal to 0.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you set this parameter to an integer that is greater than 0, the integer is used.</description></item>
        /// <item><description>If you set this parameter to 0, no limit is imposed on ROS stacks. However, the default value in Terraform is used for Terraform stacks. In most cases, the default value in Terraform is 10.</description></item>
        /// <item><description>If you leave this parameter empty, the value that you specified for this parameter in the previous request is used. If you left this parameter empty in the previous request, no limit is imposed on ROS stacks. However, the default value in Terraform is used for Terraform stacks. In most cases, the default value in Terraform is 10.</description></item>
        /// <item><description>If you set this parameter to a specific value, ROS associates the value with the stack. The value affects subsequent operations on the stack.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Parallelism")]
        [Validation(Required=false)]
        public long? Parallelism { get; set; }

        /// <summary>
        /// <para>The template parameters that you want to use to override specific parameters.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<ContinueCreateStackRequestParameters> Parameters { get; set; }
        public class ContinueCreateStackRequestParameters : TeaModel {
            /// <summary>
            /// <para>The name of template parameter N that you want to use to override a specific parameter. If you do not specify the name and value of a template parameter, ROS uses the name and value specified in the previous operation that was performed to create the stack. Maximum value of N: 200.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when Mode is set to Recreate.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Amount</para>
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// <para>The value of template parameter N that you want to use to override a specific parameter. Maximum value of N: 200.</para>
            /// <para>For ROS stacks, the template parameters that you use to override specific parameters are subject to the following limits:</para>
            /// <list type="bullet">
            /// <item><description>You cannot change the condition values in the Conditions section of a template from true to false or from false to true.</description></item>
            /// <item><description>The template parameters can be referenced only by resources that ROS continues to create.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter takes effect only when Mode is set to Recreate.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// <para>The name of the RAM role. Resource Orchestration Service (ROS) assumes the RAM role to create the stack and uses the credentials of the role to call the APIs of Alibaba Cloud services.\
        /// ROS assumes the RAM role to perform operations on the stack. If you have permissions to perform operations on the stack but do not have permissions to use the RAM role, ROS still assumes the RAM role. You must make sure that the least privileges are granted to the RAM role.\
        /// If you do not specify this parameter, ROS assumes the existing role that is associated with the stack. If no roles are available, ROS uses a temporary credential that is generated from the credentials of your account.\
        /// The name of the RAM role can be up to 64 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-role</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The options that ROS adopts when ROS continues to create the stack.</para>
        /// </summary>
        [NameInMap("RecreatingOptions")]
        [Validation(Required=false)]
        public List<string> RecreatingOptions { get; set; }

        /// <summary>
        /// <para>The resources that ROS continues to create after the resources failed to be created. You can add new resources to the resources that ROS continues to create. ROS continues to create all dependencies of the new resources.</para>
        /// <remarks>
        /// <para>This parameter is available only for ROS stacks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>WebServer</para>
        /// </summary>
        [NameInMap("RecreatingResources")]
        [Validation(Required=false)]
        public List<string> RecreatingResources { get; set; }

        /// <summary>
        /// <para>The region ID of the stack. You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The stack ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</para>
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// <para>The structure that contains the template body. The template body must be 1 to 524,288 bytes in length.\
        /// If the length of the template body exceeds the upper limit, we recommend that you add parameters to the HTTP POST request body to prevent request failures caused by excessively long URLs.</para>
        /// <para>A ROS template is subject to the following limits:</para>
        /// <list type="bullet">
        /// <item><description><para>You can modify only the following sections in the template: Description, Metadata, Resources, and Outputs.</para>
        /// </description></item>
        /// <item><description><para>You cannot add sections to or remove sections from the template.</para>
        /// </description></item>
        /// <item><description><para>The Resources section is subject to the following limits:</para>
        /// <list type="bullet">
        /// <item><description>You cannot delete the resources or change the template body for the resources that you do not want to continue to create.</description></item>
        /// <item><description>You can delete the resources or change the template body for the resources that you want to continue to create.</description></item>
        /// <item><description>You can add resources to this section.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when Mode is set to Recreate.</description></item>
        /// <item><description>You can specify only one of the following parameters: TemplateBody, TemplateURL, and TemplateId. If you do not specify the parameters, the existing template is used.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;}</para>
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The template ID. This parameter applies to shared and private templates.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect when <c>Mode</c> is set to <c>Recreate</c>. When you specify TemplateId of a template, the template is subject to the limits that are described for <c>TemplateBody</c> in this topic.</description></item>
        /// <item><description>You can specify only one of the following parameters: <c>TemplateBody</c>, <c>TemplateURL</c>, and <c>TemplateId</c>. If you do not specify the parameters, the existing template is used.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5ecd1e10-b0e9-4389-a565-e4c15efc****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an Object Storage Service (OSS) bucket, such as oss://ros/template/demo or oss://ros/template/demo?RegionId=cn-hangzhou. The template body can be up to 524,288 bytes in length.</para>
        /// <para>If you do not specify the region ID of the OSS bucket, the value of RegionId is used.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when Mode is set to Recreate. When you specify TemplateURL of a template, the template is subject to the limits that are described for TemplateBody in this topic.</description></item>
        /// <item><description>You can specify only one of the following parameters: TemplateBody, TemplateURL, and TemplateId. If you do not specify the parameters, the existing template is used.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros-template/demo</para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>The version of the template. This parameter takes effect only when TemplateId is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
