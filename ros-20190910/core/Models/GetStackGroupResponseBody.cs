// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14A07460-EBE7-47CA-9757-12CC4761D47A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the stack group.</para>
        /// </summary>
        [NameInMap("StackGroup")]
        [Validation(Required=false)]
        public GetStackGroupResponseBodyStackGroup StackGroup { get; set; }
        public class GetStackGroupResponseBodyStackGroup : TeaModel {
            /// <summary>
            /// <para>The name of the RAM administrator role that is assumed by ROS. This parameter is specified when you create a stack group in self-managed permission mode. If you do not specify this parameter, the default value AliyunROSStackGroupAdministrationRole is returned.</para>
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
            /// <para>This parameter is returned only if PermissionModel is set to SERVICE_MANAGED.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("AutoDeployment")]
            [Validation(Required=false)]
            public GetStackGroupResponseBodyStackGroupAutoDeployment AutoDeployment { get; set; }
            public class GetStackGroupResponseBodyStackGroupAutoDeployment : TeaModel {
                /// <summary>
                /// <para>Indicates whether automatic deployment is enabled or disabled.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: Automatic deployment is enabled. If you add a new member account to the folder, the stack group automatically deploys stack instances in the specified region of the new account. If you remove a member account from the folder, the stack group automatically deletes stack instances from the specified region of the account.</para>
                /// </description></item>
                /// <item><description><para>false: Automatic deployment is disabled. After automatic deployment is disabled, the stack instances remain unchanged when the member accounts in the folder change.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>Indicates whether to retain the stacks in the member account when the member account is removed from the folder.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: retains the stacks.</para>
                /// </description></item>
                /// <item><description><para>false: deletes the stacks.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is returned only if Enabled is set to true.</para>
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
            /// <para>The time when the stack group was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-14T02:13:50</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the stack group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>StackGroup Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the RAM execution role that is assumed by the administrator role AliyunROSStackGroupAdministrationRole. This parameter is specified when you create a stack group in self-managed permission mode. If you do not specify this parameter, the default value AliyunROSStackGroupExecutionRole is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunROSStackGroupExecutionRole</para>
            /// </summary>
            [NameInMap("ExecutionRoleName")]
            [Validation(Required=false)]
            public string ExecutionRoleName { get; set; }

            /// <summary>
            /// <para>The list of the parameters of the stack group.</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<GetStackGroupResponseBodyStackGroupParameters> Parameters { get; set; }
            public class GetStackGroupResponseBodyStackGroupParameters : TeaModel {
                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Amount</para>
                /// </summary>
                [NameInMap("ParameterKey")]
                [Validation(Required=false)]
                public string ParameterKey { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("ParameterValue")]
                [Validation(Required=false)]
                public string ParameterValue { get; set; }

            }

            /// <summary>
            /// <para>The permission model.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>SELF_MANAGED: self-managed permissions.</para>
            /// </description></item>
            /// <item><description><para>SERVICE_MANAGED: service-managed permissions.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>For more information about the permission models of stack groups, refer to <a href="https://help.aliyun.com/document_detail/154578.html">Overview</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SELF_MANAGED</para>
            /// </summary>
            [NameInMap("PermissionModel")]
            [Validation(Required=false)]
            public string PermissionModel { get; set; }

            /// <summary>
            /// <para>The IDs of the folders in the resource directory. Stack instances are deployed in all the accounts in the folders.</para>
            /// <remarks>
            /// <para>This parameter is returned only if PermissionModel is set to SERVICE_MANAGED.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("RdFolderIds")]
            [Validation(Required=false)]
            public List<string> RdFolderIds { get; set; }

            /// <summary>
            /// <para>The ID of the resource group. This value is determined by the resource group ID that you specify when you create the stack group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmxazb4ph6aiy****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The details of the last successful drift detection operation on the stack group.</para>
            /// </summary>
            [NameInMap("StackGroupDriftDetectionDetail")]
            [Validation(Required=false)]
            public GetStackGroupResponseBodyStackGroupStackGroupDriftDetectionDetail StackGroupDriftDetectionDetail { get; set; }
            public class GetStackGroupResponseBodyStackGroupStackGroupDriftDetectionDetail : TeaModel {
                /// <summary>
                /// <para>The number of stack instances for which the drift detection operation was canceled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CancelledStackInstancesCount")]
                [Validation(Required=false)]
                public int? CancelledStackInstancesCount { get; set; }

                /// <summary>
                /// <para>The drift detection status of the stack group.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>COMPLETED: The drift detection operation is completed for the stack group. All stack instances have been successfully drift-detected.</para>
                /// </description></item>
                /// <item><description><para>FAILED: The drift detection operation is completed for the stack group. The number of stack instances that failed the drift detection exceeds the specified threshold.</para>
                /// </description></item>
                /// <item><description><para>PARTIAL_SUCCESS: The drift detection operation is completed for the stack group. The drift detection operation failed for some stack instances, but the number of failures did not exceed the threshold.</para>
                /// </description></item>
                /// <item><description><para>IN_PROGRESS: The drift detection operation is in progress for the stack group.</para>
                /// </description></item>
                /// <item><description><para>STOPPED: The drift detection operation on the stack group was canceled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>COMPLETED</para>
                /// </summary>
                [NameInMap("DriftDetectionStatus")]
                [Validation(Required=false)]
                public string DriftDetectionStatus { get; set; }

                /// <summary>
                /// <para>The time when the drift detection operation was performed on the stack group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-02-27T07:47:47</para>
                /// </summary>
                [NameInMap("DriftDetectionTime")]
                [Validation(Required=false)]
                public string DriftDetectionTime { get; set; }

                /// <summary>
                /// <para>The number of stack instances that are in the DRIFTED state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DriftedStackInstancesCount")]
                [Validation(Required=false)]
                public int? DriftedStackInstancesCount { get; set; }

                /// <summary>
                /// <para>The number of stack instances for which the drift detection operation failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FailedStackInstancesCount")]
                [Validation(Required=false)]
                public int? FailedStackInstancesCount { get; set; }

                /// <summary>
                /// <para>The number of stack instances on which a drift detection operation is in progress.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InProgressStackInstancesCount")]
                [Validation(Required=false)]
                public int? InProgressStackInstancesCount { get; set; }

                /// <summary>
                /// <para>The number of stack instances that are in the IN_SYNC state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InSyncStackInstancesCount")]
                [Validation(Required=false)]
                public int? InSyncStackInstancesCount { get; set; }

                /// <summary>
                /// <para>The drift status of the stack group.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>DRIFTED: At least one stack instance has drifted.</para>
                /// </description></item>
                /// <item><description><para>NOT_CHECKED: No successful drift detection has been performed on the stack group.</para>
                /// </description></item>
                /// <item><description><para>IN_SYNC: All stack instances are in the IN_SYNC state.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DRIFTED</para>
                /// </summary>
                [NameInMap("StackGroupDriftStatus")]
                [Validation(Required=false)]
                public string StackGroupDriftStatus { get; set; }

                /// <summary>
                /// <para>The number of stack instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TotalStackInstancesCount")]
                [Validation(Required=false)]
                public int? TotalStackInstancesCount { get; set; }

            }

            /// <summary>
            /// <para>The ID of the stack group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd0ddef9-9540-4b42-a464-94f77835****</para>
            /// </summary>
            [NameInMap("StackGroupId")]
            [Validation(Required=false)]
            public string StackGroupId { get; set; }

            /// <summary>
            /// <para>The name of the stack group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyStackGroup</para>
            /// </summary>
            [NameInMap("StackGroupName")]
            [Validation(Required=false)]
            public string StackGroupName { get; set; }

            /// <summary>
            /// <para>The status of the stack group.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ACTIVE: The stack group is active.</para>
            /// </description></item>
            /// <item><description><para>DELETED: The stack group is deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The structure of the template body.</para>
            /// <remarks>
            /// <para>We recommend that you do not use this parameter. Use TemplateContent instead.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;}</para>
            /// </summary>
            [NameInMap("TemplateBody")]
            [Validation(Required=false)]
            public string TemplateBody { get; set; }

            /// <summary>
            /// <para>The structure of the template body. The structure is in the JSON format. For more information, refer to <a href="https://help.aliyun.com/document_detail/28857.html">Template syntax</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;
            /// }</para>
            /// </summary>
            [NameInMap("TemplateContent")]
            [Validation(Required=false)]
            public string TemplateContent { get; set; }

            /// <summary>
            /// <para>The time when the stack group was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-15T02:01:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
