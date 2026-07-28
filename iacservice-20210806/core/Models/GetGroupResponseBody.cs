// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The group.</para>
        /// </summary>
        [NameInMap("group")]
        [Validation(Required=false)]
        public GetGroupResponseBodyGroup Group { get; set; }
        public class GetGroupResponseBodyGroup : TeaModel {
            /// <summary>
            /// <para>Indicates whether automatic deletion is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("autoDestroy")]
            [Validation(Required=false)]
            public bool? AutoDestroy { get; set; }

            /// <summary>
            /// <para>Indicates whether automatic triggering is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("autoTrigger")]
            [Validation(Required=false)]
            public bool? AutoTrigger { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-21T10:57:11Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The group description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the group configuration is forcibly used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("forcedSetting")]
            [Validation(Required=false)]
            public bool? ForcedSetting { get; set; }

            /// <summary>
            /// <para>The group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>g-14e80de4866bf7ffed0bab6154d738</para>
            /// </summary>
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The notification configuration.</para>
            /// </summary>
            [NameInMap("notifyConfig")]
            [Validation(Required=false)]
            public List<GetGroupResponseBodyGroupNotifyConfig> NotifyConfig { get; set; }
            public class GetGroupResponseBodyGroupNotifyConfig : TeaModel {
                /// <summary>
                /// <para>The path configuration for notifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("notifyPath")]
                [Validation(Required=false)]
                public string NotifyPath { get; set; }

                /// <summary>
                /// <para>The notification type. Valid values:
                /// DingDing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DingDing</para>
                /// </summary>
                [NameInMap("notifyType")]
                [Validation(Required=false)]
                public string NotifyType { get; set; }

            }

            /// <summary>
            /// <para>The list of notification operation types.</para>
            /// </summary>
            [NameInMap("notifyOperationTypes")]
            [Validation(Required=false)]
            public List<string> NotifyOperationTypes { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>p-4267dcfbf1b6d126edcadf0e949</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The RAM role (1 to 128 characters). The system assumes this role to execute the template when a new job is triggered. This parameter is required when the job trigger mode is not manual.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ramRoleName</para>
            /// </summary>
            [NameInMap("ramRole")]
            [Validation(Required=false)]
            public string RamRole { get; set; }

            /// <summary>
            /// <para>The list of report export field options.</para>
            /// </summary>
            [NameInMap("reportExportField")]
            [Validation(Required=false)]
            public List<string> ReportExportField { get; set; }

            /// <summary>
            /// <para>The export address for the execution report. OSS addresses are supported. Format: https://<OSS bucket address>/<path>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("reportExportPath")]
            [Validation(Required=false)]
            public string ReportExportPath { get; set; }

            /// <summary>
            /// <para>The number of tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("taskCnt")]
            [Validation(Required=false)]
            public long? TaskCnt { get; set; }

            /// <summary>
            /// <para>The Terraform provider version. Select a Terraform provider version. Tasks in the group are executed based on the specified Terraform provider version. The version configured on a task takes higher priority. This version may conflict with the Terraform provider version specified in the module.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.191.0</para>
            /// </summary>
            [NameInMap("terraformProviderVersion")]
            [Validation(Required=false)]
            public string TerraformProviderVersion { get; set; }

            /// <summary>
            /// <para>The trigger policy. This parameter cannot be empty when autoTrigger is set to true.</para>
            /// </summary>
            [NameInMap("triggerConfig")]
            [Validation(Required=false)]
            public List<GetGroupResponseBodyGroupTriggerConfig> TriggerConfig { get; set; }
            public class GetGroupResponseBodyGroupTriggerConfig : TeaModel {
                /// <summary>
                /// <para>The trigger strategy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ProviderNewVersion: triggered when a new provider version is released</description></item>
                /// <item><description>Cron: triggered on a schedule.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Cron</para>
                /// </summary>
                [NameInMap("triggerStrategy")]
                [Validation(Required=false)]
                public string TriggerStrategy { get; set; }

                /// <summary>
                /// <para>The policy value that must be maintained for scheduled triggering. This value is a cron expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 8 * * ?</para>
                /// </summary>
                [NameInMap("triggerValue")]
                [Validation(Required=false)]
                public string TriggerValue { get; set; }

            }

            /// <summary>
            /// <para>The resource type that triggers execution. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Task: regular task</description></item>
            /// <item><description>SceneTestingTask: scenario-based testing task.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("triggerResourceType")]
            [Validation(Required=false)]
            public List<string> TriggerResourceType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6ED9F71-7FA8-598E-B64D-4606FB3FCCC9</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
