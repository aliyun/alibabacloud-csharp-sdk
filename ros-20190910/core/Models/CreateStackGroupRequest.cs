// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateStackGroupRequest : TeaModel {
        /// <summary>
        /// <para>The name of the RAM role that you specify for the administrator account when you create a self-managed stack group. ROS assumes the administrator role to perform operations. If you do not specify this parameter, AliyunROSStackGroupAdministrationRole is used as the default value. ROS uses the administrator role to assume the execution role AliyunROSStackGroupExecutionRole to perform operations on the stacks in the stack group.</para>
        /// <para>The name must be 1 to 64 characters in length and can contain letters, digits, and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunROSStackGroupAdministrationRole</para>
        /// </summary>
        [NameInMap("AdministrationRoleName")]
        [Validation(Required=false)]
        public string AdministrationRoleName { get; set; }

        /// <summary>
        /// <para>The information about automatic deployment settings.</para>
        /// <remarks>
        /// <para>You must specify this parameter if PermissionModel is set to SERVICE_MANAGED.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Enabled&quot;: true, &quot;RetainStacksOnAccountRemoval&quot;: true}</para>
        /// </summary>
        [NameInMap("AutoDeployment")]
        [Validation(Required=false)]
        public CreateStackGroupRequestAutoDeployment AutoDeployment { get; set; }
        public class CreateStackGroupRequestAutoDeployment : TeaModel {
            /// <summary>
            /// <para>Indicates whether automatic deployment is enabled.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Automatic deployment is enabled. If you add a member account to the folder to which the stack group belongs after you enable automatic deployment, ROS automatically adds the stacks in the stack group to the member account. If you remove a member account from the folder, ROS automatically deletes the stacks from the member account.</description></item>
            /// <item><description>false: Automatic deployment is disabled. After you disable automatic deployment, the stacks remain unchanged when you add member accounts to or remove member accounts from the folder.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>Indicates whether the stacks within a member account are retained when you remove the member account from the folder.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// <remarks>
            /// <para>You must specify RetainStacksOnAccountRemoval if Enabled is set to true.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RetainStacksOnAccountRemoval")]
            [Validation(Required=false)]
            public bool? RetainStacksOnAccountRemoval { get; set; }

        }

        /// <summary>
        /// <para>The options for the stack group. You can specify up to one option.</para>
        /// </summary>
        [NameInMap("Capabilities")]
        [Validation(Required=false)]
        public List<string> Capabilities { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.\
        /// The token can contain letters, digits, underscores (_), and hyphens (-) and cannot exceed 64 characters in length.\
        /// For more information, see <a href="https://help.aliyun.com/document_detail/134212.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the stack group.\
        /// The description must be 1 to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StackGroup Description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the RAM role that you specify for the execution account when you create a self-managed stack group. The administrator role AliyunROSStackGroupAdministrationRole assumes the execution role to perform operations. If you do not specify this parameter, AliyunROSStackGroupExecutionRole is used as the default value. ROS assumes the execution role to perform operations on the stacks in the stack group.</para>
        /// <para>The name must be 1 to 64 characters in length and can contain letters, digits, and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunROSStackGroupExecutionRole</para>
        /// </summary>
        [NameInMap("ExecutionRoleName")]
        [Validation(Required=false)]
        public string ExecutionRoleName { get; set; }

        /// <summary>
        /// <para>The parameters of the stack group.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<CreateStackGroupRequestParameters> Parameters { get; set; }
        public class CreateStackGroupRequestParameters : TeaModel {
            /// <summary>
            /// <para>The key of parameter N. If you do not specify the key and value of a parameter, ROS uses the default name and value that are defined in the template.</para>
            /// <para>Maximum value of N: 200.</para>
            /// <remarks>
            /// <para>Parameters is optional. If you specify Parameters, you must also specify Parameters.N.ParameterKey.</para>
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
            /// <para>The value of parameter N.</para>
            /// <para>Maximum value of N: 200.</para>
            /// <remarks>
            /// <para>Parameters is optional. If you specify Parameters, you must also specify Parameters.N.ParameterValue.</para>
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
        /// <para>The permission model of the stack group.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SELF_MANAGED (default): the self-managed permission model. If you create a self-managed stack group, you must create RAM roles within the administrator and execution accounts and establish a trust relationship between the accounts. Then, you can deploy stacks within the execution account.</description></item>
        /// <item><description>SERVICE_MANAGED: the service-managed permission model. If you create a service-managed stack group, ROS creates service-linked roles for the administrator and execution accounts, and the administrator account uses its role to deploy stacks within the execution account.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you want to use the service-managed permission model to deploy stacks, your account must be the management account or a delegated administrator account of your resource directory and the trusted access feature is enabled for the account. For more information, see <a href="https://help.aliyun.com/document_detail/308253.html">Manage a delegated administrator account</a> and <a href="https://help.aliyun.com/document_detail/298229.html">Enable trusted access</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SELF_MANAGED</para>
        /// </summary>
        [NameInMap("PermissionModel")]
        [Validation(Required=false)]
        public string PermissionModel { get; set; }

        /// <summary>
        /// <para>The region ID of the stack group. You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. If you do not specify this parameter, the stack group is added to the default resource group.\
        /// For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/94475.html">Resource groups</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph6aiy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("StackArn")]
        [Validation(Required=false)]
        public string StackArn { get; set; }

        /// <summary>
        /// <para>The name of the stack group. The name must be unique within a region.\
        /// The name can be up to 255 characters in length, and can contain digits, letters, hyphens (-), and underscores (_). It must start with a digit or a letter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyStackGroup</para>
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

        /// <summary>
        /// <para>The tags of the stack group.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateStackGroupRequestTags> Tags { get; set; }
        public class CreateStackGroupRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the stack group.</para>
            /// <remarks>
            /// <para>Tags is optional. If you want to specify Tags, you must also specify Tags.N.Key.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>usage</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the stack group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The ID of the template. This parameter applies to shared and private templates.</para>
        /// <remarks>
        /// <para>You must and can specify only one of the following parameters: TemplateBody, TemplateURL, and TemplateId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5ecd1e10-b0e9-4389-a565-e4c15efc****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an Alibaba Cloud Object Storage Service (OSS) bucket. The template body must be 1 to 524,288 bytes in length. Examples: oss://ros/template/demo and oss://ros/template/demo?RegionId=cn-hangzhou. If you do not specify the region ID of the OSS bucket, the value of RegionId is used.</para>
        /// <remarks>
        /// <para>You must and can specify only one of the following parameters: TemplateBody, TemplateURL, and TemplateId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros-template/demo</para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>The version of the template. If you do not specify this parameter, the latest version is used.</para>
        /// <remarks>
        /// <para>TemplateVersion takes effect only if you specify TemplateId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
