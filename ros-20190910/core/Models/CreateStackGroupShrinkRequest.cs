// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateStackGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The RAM role for the administrator account in a self-managed stack group. ROS assumes this role to perform operations. Default: AliyunROSStackGroupAdministrationRole.</para>
        /// <para>1 to 64 characters. Can contain letters, digits, and hyphens (-).</para>
        /// <remarks>
        /// <para>This parameter is required when PermissionModel is set to SELF_MANAGED.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunROSStackGroupAdministrationRole</para>
        /// </summary>
        [NameInMap("AdministrationRoleName")]
        [Validation(Required=false)]
        public string AdministrationRoleName { get; set; }

        /// <summary>
        /// <para>The automatic deployment settings.</para>
        /// <remarks>
        /// <para>You must specify this parameter if PermissionModel is set to SERVICE_MANAGED.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Enabled&quot;: true, &quot;RetainStacksOnAccountRemoval&quot;: true}</para>
        /// </summary>
        [NameInMap("AutoDeployment")]
        [Validation(Required=false)]
        public string AutoDeploymentShrink { get; set; }

        /// <summary>
        /// <para>The options for the stack group. Maximum: one option.</para>
        /// </summary>
        [NameInMap("Capabilities")]
        [Validation(Required=false)]
        public List<string> Capabilities { get; set; }

        /// <summary>
        /// <para>The client token for idempotency. Must be unique across requests. Can contain letters, digits, underscores (_), and hyphens (-), up to 64 characters. <a href="https://help.aliyun.com/document_detail/134212.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The stack group description. 1 to 256 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StackGroup Description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The RAM role for the execution account in a self-managed stack group. The administrator role assumes this role to perform stack operations. Default: AliyunROSStackGroupExecutionRole.</para>
        /// <para>1 to 64 characters. Can contain letters, digits, and hyphens (-).</para>
        /// <remarks>
        /// <para>This parameter is required when PermissionModel is set to SELF_MANAGED.</para>
        /// </remarks>
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
        public List<CreateStackGroupShrinkRequestParameters> Parameters { get; set; }
        public class CreateStackGroupShrinkRequestParameters : TeaModel {
            /// <summary>
            /// <para>The key of parameter N. If not specified, ROS uses the default name and value defined in the template.</para>
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
        /// <item><description><para>SELF_MANAGED (default): Create RAM roles for the administrator and execution accounts and establish a trust relationship between them.</para>
        /// </description></item>
        /// <item><description><para>SERVICE_MANAGED: ROS automatically creates service-linked roles for the administrator and execution accounts.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>To use SERVICE_MANAGED, your account must be the management account or a delegated administrator account of a resource directory with trusted access enabled. <a href="https://help.aliyun.com/document_detail/308253.html">Manage a delegated administrator account</a> and <a href="https://help.aliyun.com/document_detail/298229.html">Enable trusted access</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SELF_MANAGED</para>
        /// </summary>
        [NameInMap("PermissionModel")]
        [Validation(Required=false)]
        public string PermissionModel { get; set; }

        /// <summary>
        /// <para>The region ID of the stack group. Call <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> to query available regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. Defaults to the default resource group. <a href="https://help.aliyun.com/document_detail/94475.html">Resource groups</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph6aiy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The stack ARN in the format acs:ros:${RegionId}:${AccountId}:stack/${StackId}. The stack group uses the template and parameters of this stack.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Only supported in self-managed permission mode.</para>
        /// </description></item>
        /// <item><description><para>If StackArn is specified, Parameters must not be specified.</para>
        /// </description></item>
        /// <item><description><para>You must specify <b>only one</b> of TemplateBody, TemplateURL, TemplateId, or StackArn.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ros:cn-hangzhou:175458000000****:stack/4a65f506-c3cc-43b6-af06-3f000000****</para>
        /// </summary>
        [NameInMap("StackArn")]
        [Validation(Required=false)]
        public string StackArn { get; set; }

        /// <summary>
        /// <para>The stack group name. Must be unique within a region. 1 to 255 characters. Can contain letters, digits, hyphens (-), and underscores (_). Must start with a letter or digit.</para>
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
        public List<CreateStackGroupShrinkRequestTags> Tags { get; set; }
        public class CreateStackGroupShrinkRequestTags : TeaModel {
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

        /// <summary>
        /// <para>The template body. 1 to 524,288 bytes. For large templates, pass the body in the HTTP POST request body to avoid URL length limits.</para>
        /// <remarks>
        /// <para>Specify exactly one of TemplateBody, TemplateURL, and TemplateId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ROSTemplateFormatVersion&quot;:&quot;2015-09-01&quot;}</para>
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The template ID. Applies to shared and private templates.</para>
        /// <remarks>
        /// <para>Specify exactly one of TemplateBody, TemplateURL, and TemplateId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5ecd1e10-b0e9-4389-a565-e4c15efc****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The URL of the template file. Supports HTTP, HTTPS, and OSS URLs. 1 to 524,288 bytes. Examples: oss\://ros/template/demo, oss\://ros/template/demo?RegionId=cn-hangzhou. If no region ID is specified for the OSS bucket, the RegionId value applies.</para>
        /// <remarks>
        /// <para>Specify exactly one of TemplateBody, TemplateURL, and TemplateId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros-template/demo</para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>The template version. Defaults to the latest version.</para>
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
