// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class UpdateStackGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the destination accounts in which to deploy stacks in self-managed permission mode. You can specify a maximum of 50 destination account IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;12****&quot;]</para>
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public string AccountIdsShrink { get; set; }

        /// <summary>
        /// <para>The name of the RAM administrator role that is assumed by ROS. This parameter is required when you create a stack group that has self-managed permissions. If you do not specify a value, \<c>AliyunROSStackGroupAdministrationRole\\</c> is used as the default value. ROS assumes this role to perform operations on the stacks in the stack group. ROS uses the credentials of this role to assume the execution role (\<c>AliyunROSStackGroupExecutionRole\\</c>).</para>
        /// <para>The name must be 1 to 64 characters in length and can contain letters, digits, and hyphens (-).</para>
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
        /// <para>This parameter is required only when \<c>PermissionModel\\</c> is set to \<c>SERVICE_MANAGED\\</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Enabled&quot;: true, &quot;RetainStacksOnAccountRemoval&quot;: true}</para>
        /// </summary>
        [NameInMap("AutoDeployment")]
        [Validation(Required=false)]
        public string AutoDeploymentShrink { get; set; }

        /// <summary>
        /// <para>The options for the stack group. You can specify up to one option.</para>
        /// </summary>
        [NameInMap("Capabilities")]
        [Validation(Required=false)]
        public List<string> Capabilities { get; set; }

        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.<br>The token can be up to 64 characters in length and can contain letters, digits, hyphens (-), and underscores (_).<br>For more information, see <a href="https://help.aliyun.com/document_detail/134212.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The deployment options for a stack group with service-managed permissions. You can specify up to one deployment option.</para>
        /// </summary>
        [NameInMap("DeploymentOptions")]
        [Validation(Required=false)]
        public List<string> DeploymentOptions { get; set; }

        /// <summary>
        /// <para>The deployment targets to which you want to deploy stacks in service-managed permission mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;RdFolderIds&quot;: [&quot;fd-4PvlVLOL8v&quot;]}</para>
        /// </summary>
        [NameInMap("DeploymentTargets")]
        [Validation(Required=false)]
        public string DeploymentTargetsShrink { get; set; }

        /// <summary>
        /// <para>The description of the stack group.</para>
        /// <para>The description must be 1 to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My Stack Group</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the RAM execution role that is assumed by the administrator role (\<c>AliyunROSStackGroupAdministrationRole\\</c>). This parameter is required when you create a stack group that has self-managed permissions. If you do not specify a value, \<c>AliyunROSStackGroupExecutionRole\\</c> is used as the default value. ROS assumes this role to perform operations on the stacks in the stack group.</para>
        /// <para>The name must be 1 to 64 characters in length and can contain letters, digits, and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunROSStackGroupExecutionRole</para>
        /// </summary>
        [NameInMap("ExecutionRoleName")]
        [Validation(Required=false)]
        public string ExecutionRoleName { get; set; }

        /// <summary>
        /// <para>The description of the operation to update the stack group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Update stack instances in hangzhou</para>
        /// </summary>
        [NameInMap("OperationDescription")]
        [Validation(Required=false)]
        public string OperationDescription { get; set; }

        /// <summary>
        /// <para>The preferences for the stack group operation.</para>
        /// <para>The following parameters are included:</para>
        /// <list type="bullet">
        /// <item><description><para>FailureToleranceCount</para>
        /// <para>The number of accounts in each region where stack operation failures are allowed. If the number of failed operations in a region exceeds this value, Resource Orchestration Service (ROS) stops the operations in that region. If the operation is stopped in one region, the operation is not initiated in other regions.</para>
        /// <para>The value must be an integer from 0 to 20.</para>
        /// <para>If you do not specify this parameter, 0 is used as the default value.</para>
        /// </description></item>
        /// <item><description><para>FailureTolerancePercentage</para>
        /// <para>The percentage of accounts in each region where stack operation failures are allowed. If the percentage of failed operations in a region exceeds this value, ROS stops the operations in that region.</para>
        /// <para>The value must be an integer from 0 to 100. If the percentage is not an integer, ROS rounds down the percentage to the nearest integer.</para>
        /// <para>If you do not specify this parameter, 0 is used as the default value.</para>
        /// </description></item>
        /// <item><description><para>MaxConcurrentCount</para>
        /// <para>The maximum number of accounts in each region where stacks are deployed at the same time.</para>
        /// <para>The value must be an integer from 1 to 20.</para>
        /// <para>If you do not specify this parameter, 1 is used as the default value.</para>
        /// </description></item>
        /// <item><description><para>MaxConcurrentPercentage</para>
        /// <para>The maximum percentage of accounts in each region where stacks are deployed at the same time.</para>
        /// <para>The value must be an integer from 1 to 100. If the percentage is not an integer, ROS rounds down the percentage to the nearest integer.</para>
        /// <para>If you do not specify this parameter, 1 is used as the default value.</para>
        /// </description></item>
        /// <item><description><para>RegionConcurrencyType
        /// The concurrency type of deployment regions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SEQUENTIAL (default): Deploys stacks in the specified regions sequentially. At any given time, stacks are deployed in only one region.</para>
        /// </description></item>
        /// <item><description><para>PARALLEL: Deploys stacks in all the specified regions in parallel.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>Separate multiple parameters with commas (,).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You can specify only one of \<c>MaxConcurrentCount\\</c> and \<c>MaxConcurrentPercentage\\</c>.</para>
        /// </description></item>
        /// <item><description><para>You can specify only one of \<c>FailureToleranceCount\\</c> and \<c>FailureTolerancePercentage\\</c>.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;FailureToleranceCount&quot;: 1,&quot;MaxConcurrentCount&quot;: 2}</para>
        /// </summary>
        [NameInMap("OperationPreferences")]
        [Validation(Required=false)]
        public string OperationPreferencesShrink { get; set; }

        /// <summary>
        /// <para>The parameters of the stack group.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<UpdateStackGroupShrinkRequestParameters> Parameters { get; set; }
        public class UpdateStackGroupShrinkRequestParameters : TeaModel {
            /// <summary>
            /// <para>The key of the parameter. If you do not specify the key and value of a parameter, ROS uses the default name and value that are specified in the template.</para>
            /// <para>You can specify a maximum of 200 parameters.</para>
            /// <remarks>
            /// <para>The \<c>Parameters\\</c> parameter is optional. If you specify \<c>Parameters\\</c>, you must specify \<c>Parameters.N.ParameterKey\\</c>.</para>
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
            /// <para>The value of the parameter.</para>
            /// <para>You can specify a maximum of 200 parameters.</para>
            /// <remarks>
            /// <para>The \<c>Parameters\\</c> parameter is optional. If you specify \<c>Parameters\\</c>, you must specify \<c>Parameters.N.ParameterValue\\</c>.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// <para>The permission model.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SELF_MANAGED (default): Self-managed permissions. If you use this permission model, you must create RAM roles in the administrator and member accounts so that the accounts can be associated with each other. Then, you can deploy stacks in the member accounts.</para>
        /// </description></item>
        /// <item><description><para>SERVICE_MANAGED: Service-managed permissions. If you use this permission model, ROS creates service-linked roles for the administrator and member accounts. The administrator account uses the service-linked roles to deploy stacks in the member accounts.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If stack instances exist in the stack group, you cannot change the permission model.</para>
        /// </description></item>
        /// <item><description><para>If you use the service-managed permission model to deploy stacks, the current account must be the management account or a delegated administrator account of your resource directory, and trusted access must be enabled for the account. For more information, see <a href="https://help.aliyun.com/document_detail/308253.html">Set a delegated administrator account</a> and <a href="https://help.aliyun.com/document_detail/298229.html">Enable trusted access</a>.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SELF_MANAGED</para>
        /// </summary>
        [NameInMap("PermissionModel")]
        [Validation(Required=false)]
        public string PermissionModel { get; set; }

        /// <summary>
        /// <para>The ID of the region where the stack group is located. You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IDs of the regions where you want to deploy the stacks. You can specify a maximum of 20 region IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cn-hangzhou&quot;, &quot;cn-beijing&quot;]</para>
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public string RegionIdsShrink { get; set; }

        /// <summary>
        /// <para>The name of the stack group. The name must be unique within a region.<br>The name can be up to 255 characters in length and must start with a digit or a letter. The name can contain digits, letters, hyphens (-), and underscores (_).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyStackGroup</para>
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

        /// <summary>
        /// <para>The structure that contains the template body. The template body must be 1 to 524,288 bytes in length. If the length of the template body is large, pass the parameter in the request body using the HTTP POST and Body Param method to prevent request failures caused by an excessively long URL.</para>
        /// <remarks>
        /// <para>You can specify only one of the \<c>TemplateBody\\</c>, \<c>TemplateURL\\</c>, and \<c>TemplateId\\</c> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;}</para>
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The ID of the template. This parameter applies to shared templates and private templates.</para>
        /// <remarks>
        /// <para>You can specify only one of the \<c>TemplateBody\\</c>, \<c>TemplateURL\\</c>, and \<c>TemplateId\\</c> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5ecd1e10-b0e9-4389-a565-e4c15efc****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an Alibaba Cloud Object Storage Service (OSS) bucket. The template body must be 1 to 524,288 bytes in length. For example, the URL of an OSS bucket can be oss\://ros/template/demo or oss\://ros/template/demo?RegionId=cn-hangzhou. If you do not specify the region of the OSS bucket, the value of the \<c>RegionId\\</c> parameter is used.</para>
        /// <remarks>
        /// <para>You can specify only one of the \<c>TemplateBody\\</c>, \<c>TemplateURL\\</c>, and \<c>TemplateId\\</c> parameters.</para>
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
        /// <para>\<c>TemplateVersion\\</c> takes effect only when \<c>TemplateId\\</c> is specified.</para>
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
