// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class UpdateStackGroupRequest : TeaModel {
        /// <summary>
        /// <para>The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an Alibaba Cloud Object Storage Service (OSS) bucket. The template body must be 1 to 524,288 bytes in length. Examples: oss://ros/template/demo and oss://ros/template/demo?RegionId=cn-hangzhou. If you do not specify the region ID of the OSS bucket, the value of the RegionId parameter is used.</para>
        /// <remarks>
        /// <para> You must specify only one of the TemplateBody, TemplateURL, and TemplateId parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;12****&quot;]</para>
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public List<string> AccountIds { get; set; }

        /// <summary>
        /// <para>The key of parameter N. If you do not specify the key and value of the parameter, ROS uses the default key and value in the template.</para>
        /// <para>Maximum value of N: 200.</para>
        /// <remarks>
        /// <para> The Parameters parameter is optional. If you set the Parameters parameter, you must set the Parameters.N.ParameterKey parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunROSStackGroupAdministrationRole</para>
        /// </summary>
        [NameInMap("AdministrationRoleName")]
        [Validation(Required=false)]
        public string AdministrationRoleName { get; set; }

        /// <summary>
        /// <para>The IDs of the folders in the resource directory. You can specify up to five folder IDs.</para>
        /// <para>You can create stacks within all members in the specified folders. If you create stacks in the Root folder, the stacks are created within all members in the resource directory.</para>
        /// <remarks>
        /// <para> To view the folder IDs, go to the <b>Overview</b> page in the <b>Resource Management</b> console. For more information, see <a href="https://help.aliyun.com/document_detail/111223.html">View the basic information of a folder</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Enabled&quot;: true, &quot;RetainStacksOnAccountRemoval&quot;: true}</para>
        /// </summary>
        [NameInMap("AutoDeployment")]
        [Validation(Required=false)]
        public UpdateStackGroupRequestAutoDeployment AutoDeployment { get; set; }
        public class UpdateStackGroupRequestAutoDeployment : TeaModel {
            /// <summary>
            /// <para>The IDs of the members in the resource directory. You can specify a maximum of 20 member IDs.</para>
            /// <remarks>
            /// <para> To view the member IDs, go to the <b>Overview</b> page in the <b>Resource Management</b> console. For more information, see <a href="https://help.aliyun.com/document_detail/111624.html">View the detailed information of a member</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The IDs of the members in the resource directory. You can specify a maximum of 20 member IDs.</para>
            /// <remarks>
            /// <para> To view the member IDs, go to the <b>Overview</b> page in the <b>Resource Management</b> console. For more information, see <a href="https://help.aliyun.com/document_detail/111624.html">View the detailed information of a member</a>.</para>
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
        /// <para>The option for the stack group. You can specify up to one option.</para>
        /// </summary>
        [NameInMap("Capabilities")]
        [Validation(Required=false)]
        public List<string> Capabilities { get; set; }

        /// <summary>
        /// <para>The ID of the template. This parameter applies to shared and private templates.</para>
        /// <remarks>
        /// <para> You must specify only one of the TemplateBody, TemplateURL, and TemplateId parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DeploymentOptions")]
        [Validation(Required=false)]
        public List<string> DeploymentOptions { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;RdFolderIds&quot;: [&quot;fd-4PvlVLOL8v&quot;]}</para>
        /// </summary>
        [NameInMap("DeploymentTargets")]
        [Validation(Required=false)]
        public UpdateStackGroupRequestDeploymentTargets DeploymentTargets { get; set; }
        public class UpdateStackGroupRequestDeploymentTargets : TeaModel {
            /// <summary>
            /// <para>The list of one or more Alibaba Cloud accounts with which you want to share or unshare the template.</para>
            /// </summary>
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<string> AccountIds { get; set; }

            /// <summary>
            /// <para>The ID of the operation.</para>
            /// </summary>
            [NameInMap("RdFolderIds")]
            [Validation(Required=false)]
            public List<string> RdFolderIds { get; set; }

        }

        /// <summary>
        /// <para>The structure that contains the template body. The template body must be 1 to 524,288 bytes in length. If the length of the template body exceeds the upper limit, we recommend that you add parameters to the HTTP POST request body to prevent request failures caused by excessively long URLs.</para>
        /// <remarks>
        /// <para> You must specify only one of the TemplateBody, TemplateURL, and TemplateId parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>My Stack Group</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The value of parameter N.</para>
        /// <para>Maximum value of N: 200.</para>
        /// <remarks>
        /// <para> The Parameters parameter is optional. If you set the Parameters parameter, you must set the Parameters.N.ParameterValue parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunROSStackGroupExecutionRole</para>
        /// </summary>
        [NameInMap("ExecutionRoleName")]
        [Validation(Required=false)]
        public string ExecutionRoleName { get; set; }

        /// <summary>
        /// <para>The version of the template. If you do not specify a version, the latest version is used.</para>
        /// <remarks>
        /// <para> This parameter takes effect only if the TemplateId parameter is set.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Update stack instances in hangzhou</para>
        /// </summary>
        [NameInMap("OperationDescription")]
        [Validation(Required=false)]
        public string OperationDescription { get; set; }

        /// <summary>
        /// <para>The list of parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;FailureToleranceCount&quot;: 1,&quot;MaxConcurrentCount&quot;: 2}</para>
        /// </summary>
        [NameInMap("OperationPreferences")]
        [Validation(Required=false)]
        public Dictionary<string, object> OperationPreferences { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic deployment.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables automatic deployment. If you add a member to the folder to which the stack group belongs after you enable automatic deployment, the stack group deploys its stack instances within the member. If you remove a member from the folder, the stack group deletes stack instances that are deployed within the member.</description></item>
        /// <item><description>false: disables automatic deployment. After you disable automatic deployment, the stack instances remain unchanged even if members in the folder change.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<UpdateStackGroupRequestParameters> Parameters { get; set; }
        public class UpdateStackGroupRequestParameters : TeaModel {
            /// <summary>
            /// <para>Specifies whether to retain stacks in a member when you remove the member from the folder.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: retains the stacks.</description></item>
            /// <item><description>false: deletes the stacks.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is required if the Enabled parameter is set to true.</para>
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
            /// <para>The folders in which you want to use service-managed permissions to update stacks.</para>
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
        /// <para>The folder IDs in the resource directory. You can specify a maximum of five folder IDs.</para>
        /// <para>You must set at least one of the RdFolderIds and AccountIds parameters. The parameters are subject to the following items:</para>
        /// <list type="bullet">
        /// <item><description>If you set only the RdFolderIds parameter, stacks are deployed within all the members in the specified folders. If you specify the Root folder, ROS deploys the stacks within all the members in the resource directory.</description></item>
        /// <item><description>If you set only the AccountIds parameter, stacks are deployed within the specified members.</description></item>
        /// <item><description>If you set both parameters, the accounts specified by AccountIds must be contained in the folders specified by RdFolderIds.</description></item>
        /// </list>
        /// <remarks>
        /// <para> To view the folder IDs, go to the <b>Overview</b> page in the <b>Resource Management</b> console. For more information, see <a href="https://help.aliyun.com/document_detail/111223.html">View the basic information of a folder</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SELF_MANAGED</para>
        /// </summary>
        [NameInMap("PermissionModel")]
        [Validation(Required=false)]
        public string PermissionModel { get; set; }

        /// <summary>
        /// <para>The region IDs of stack instances. You can specify a maximum of 20 region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The description of the operation to update the stack group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cn-hangzhou&quot;, &quot;cn-beijing&quot;]</para>
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public List<string> RegionIds { get; set; }

        /// <summary>
        /// <para>The region IDs of stack instances. You can specify a maximum of 20 region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyStackGroup</para>
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The permission model.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SELF_MANAGED: the self-managed permission model. This is the default value. If you use the self-managed model for the stack group, you must create RAM roles for the administrator and execution accounts, and establish a trust relationship between the accounts to deploy stacks within the execution account.</description></item>
        /// <item><description>SERVICE_MANAGED: the service-managed permission model. If you use the service-managed model for the stack group, ROS creates service-linked roles for the administrator and execution accounts, and the administrator account uses its role to deploy stacks within the execution account.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If stack instances have been created in the stack group, you cannot switch the permission mode of the stack group.</description></item>
        /// <item><description>If you want to use the service-managed permission model to deploy stacks, your account must be the management account or a delegated administrator account of your resource directory and the trusted access feature is enabled for the account. For more information, see <a href="https://help.aliyun.com/document_detail/308253.html">Step 1: (Optional) Create a delegated administrator account</a> and <a href="https://help.aliyun.com/document_detail/298229.html">Step 2: Enable trusted access</a>.</description></item>
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
        /// <para>The name of the RAM role to be assumed by the administrator role AliyunROSStackGroupAdministrationRole. This parameter is required if you want to grant self-managed permissions to the stack group. If you do not specify a value for this parameter, the default value AliyunROSStackGroupExecutionRole is used. You can use this role in ROS to perform operations on the stacks that correspond to stack instances in the stack group.</para>
        /// <para>The name must be 1 to 64 characters in length, and can contain letters, digits, and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros-template/demo</para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>The information about automatic deployment settings.</para>
        /// <remarks>
        /// <para> This parameter is required only if the PermissionModel parameter is set to SERVICE_MANAGED.</para>
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
