// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the stack group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14A07460-EBE7-47CA-9757-12CC4761D47A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details of the stack group.</para>
        /// </summary>
        [NameInMap("StackGroup")]
        [Validation(Required=false)]
        public GetStackGroupResponseBodyStackGroup StackGroup { get; set; }
        public class GetStackGroupResponseBodyStackGroup : TeaModel {
            /// <summary>
            /// <para>The parameters of the stack group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunROSStackGroupAdministrationRole</para>
            /// </summary>
            [NameInMap("AdministrationRoleName")]
            [Validation(Required=false)]
            public string AdministrationRoleName { get; set; }

            /// <summary>
            /// <para>Indicates whether automatic deployment is enabled.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Automatic deployment is enabled. If a member account is added to the folder to which the stack group belongs after automatic deployment is enabled, the stack group deploys its stack instances in the specified region where the added account is deployed. If the account is deleted from the folder, the stack instances in the specified region are deleted from the stack group.</description></item>
            /// <item><description>false: Automatic deployment is disabled. After automatic deployment is disabled, the stack instances remain unchanged when the member account in the folder is changed.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("AutoDeployment")]
            [Validation(Required=false)]
            public GetStackGroupResponseBodyStackGroupAutoDeployment AutoDeployment { get; set; }
            public class GetStackGroupResponseBodyStackGroupAutoDeployment : TeaModel {
                /// <summary>
                /// <para>Indicates whether stacks in the member account are retained when the member account is deleted from the folder.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The stacks are retained.</description></item>
                /// <item><description>false: The stacks are deleted.</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is returned only when the Enabled parameter is set to true.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The folder IDs of the resource directory. This parameter is used to deploy stack instances within all the accounts in the folders.</para>
                /// <remarks>
                /// <para> This parameter is returned only when the PermissionModel parameter is set to SERVICE_MANAGED.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("RetainStacksOnAccountRemoval")]
                [Validation(Required=false)]
                public bool? RetainStacksOnAccountRemoval { get; set; }

            }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The name of the stack group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>StackGroup Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The template body.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunROSStackGroupExecutionRole</para>
            /// </summary>
            [NameInMap("ExecutionRoleName")]
            [Validation(Required=false)]
            public string ExecutionRoleName { get; set; }

            /// <summary>
            /// <para>The key of the parameter.</para>
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
            /// <para>The information about automatic deployment settings.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the PermissionModel parameter is set to SERVICE_MANAGED.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SELF_MANAGED</para>
            /// </summary>
            [NameInMap("PermissionModel")]
            [Validation(Required=false)]
            public string PermissionModel { get; set; }

            /// <summary>
            /// <para>The folder IDs of the resource directory. This parameter is used to deploy stack instances within all the accounts in the folders.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the PermissionModel parameter is set to SERVICE_MANAGED.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("RdFolderIds")]
            [Validation(Required=false)]
            public List<string> RdFolderIds { get; set; }

            /// <summary>
            /// <para>The permission model.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SELF_MANAGED: the self-managed permission model</description></item>
            /// <item><description>SERVICE_MANAGED: the service-managed permission model</description></item>
            /// </list>
            /// <remarks>
            /// <para> For more information about the permission models of stack groups, see <a href="https://help.aliyun.com/document_detail/154578.html">Overview</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmxazb4ph6aiy****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The time when drift detection was performed on the stack group.</para>
            /// </summary>
            [NameInMap("StackGroupDriftDetectionDetail")]
            [Validation(Required=false)]
            public GetStackGroupResponseBodyStackGroupStackGroupDriftDetectionDetail StackGroupDriftDetectionDetail { get; set; }
            public class GetStackGroupResponseBodyStackGroupStackGroupDriftDetectionDetail : TeaModel {
                /// <summary>
                /// <para>The number of stack instances that have drifted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CancelledStackInstancesCount")]
                [Validation(Required=false)]
                public int? CancelledStackInstancesCount { get; set; }

                /// <summary>
                /// <para>The drift status of the stack group.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DRIFTED: At least one stack instance in the stack group has drifted.</description></item>
                /// <item><description>NOT_CHECKED: No drift detection is completed on the stack group.</description></item>
                /// <item><description>IN_SYNC: All the stack instances in the stack group are being synchronized.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>COMPLETED</para>
                /// </summary>
                [NameInMap("DriftDetectionStatus")]
                [Validation(Required=false)]
                public string DriftDetectionStatus { get; set; }

                /// <summary>
                /// <para>The number of stack instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-02-27T07:47:47</para>
                /// </summary>
                [NameInMap("DriftDetectionTime")]
                [Validation(Required=false)]
                public string DriftDetectionTime { get; set; }

                /// <summary>
                /// <para>The ID of the resource group. This parameter is specified when you create the stack group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DriftedStackInstancesCount")]
                [Validation(Required=false)]
                public int? DriftedStackInstancesCount { get; set; }

                /// <summary>
                /// <para>The status of drift detection on the stack group.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>COMPLETED: Drift detection is performed and completed on all stack instances.</description></item>
                /// <item><description>FAILED: Drift detection is performed. The number of stack instances that failed the drift detection exceeds the specified threshold.</description></item>
                /// <item><description>PARTIAL_SUCCESS: Drift detection is performed. The number of stack instances that failed the drift detection does not exceed the specified threshold.</description></item>
                /// <item><description>IN_PROGRESS: Drift detection is being performed on the stack group.</description></item>
                /// <item><description>STOPPED: Drift detection is canceled for the stack group.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FailedStackInstancesCount")]
                [Validation(Required=false)]
                public int? FailedStackInstancesCount { get; set; }

                /// <summary>
                /// <para>The number of stack instances that were being synchronized.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InProgressStackInstancesCount")]
                [Validation(Required=false)]
                public int? InProgressStackInstancesCount { get; set; }

                /// <summary>
                /// <para>The number of stack instances for which drift detection was canceled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InSyncStackInstancesCount")]
                [Validation(Required=false)]
                public int? InSyncStackInstancesCount { get; set; }

                /// <summary>
                /// <para>The number of stack instances on which drift detection was being performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DRIFTED</para>
                /// </summary>
                [NameInMap("StackGroupDriftStatus")]
                [Validation(Required=false)]
                public string StackGroupDriftStatus { get; set; }

                /// <summary>
                /// <para>The number of stack instances that failed drift detection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TotalStackInstancesCount")]
                [Validation(Required=false)]
                public int? TotalStackInstancesCount { get; set; }

            }

            /// <summary>
            /// <para>The status of the stack group.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ACTIVE</description></item>
            /// <item><description>DELETED</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>fd0ddef9-9540-4b42-a464-94f77835****</para>
            /// </summary>
            [NameInMap("StackGroupId")]
            [Validation(Required=false)]
            public string StackGroupId { get; set; }

            /// <summary>
            /// <para>The name of the RAM role that is specified for the execution account when you create the self-managed stack group. The administrator role AliyunROSStackGroupAdministrationRole assumes the execution role. If this parameter is not specified, the default value AliyunROSStackGroupExecutionRole is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyStackGroup</para>
            /// </summary>
            [NameInMap("StackGroupName")]
            [Validation(Required=false)]
            public string StackGroupName { get; set; }

            /// <summary>
            /// <para>The name of the RAM role that is specified for the administrator account in Resource Orchestration Service (ROS) when you create the self-managed stack group. If this parameter is not specified, the default value AliyunROSStackGroupAdministrationRole is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The structure that contains the template body.</para>
            /// <remarks>
            /// <para>We recommend that you use TemplateContent instead of TemplateBody.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;}</para>
            /// </summary>
            [NameInMap("TemplateBody")]
            [Validation(Required=false)]
            public string TemplateBody { get; set; }

            /// <summary>
            /// <para>The JSON-formatted structure that contains the template body. For more information, see <a href="https://help.aliyun.com/document_detail/28857.html">Template syntax</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;
            /// }</para>
            /// </summary>
            [NameInMap("TemplateContent")]
            [Validation(Required=false)]
            public string TemplateContent { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
