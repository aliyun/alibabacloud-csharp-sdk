// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateGroupRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to delete the group after creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoDestroy")]
        [Validation(Required=false)]
        public bool? AutoDestroy { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the automatic trigger policy. Valid values: <b>true</b>: Enabled. <b>false</b>: Disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoTrigger")]
        [Validation(Required=false)]
        public bool? AutoTrigger { get; set; }

        /// <summary>
        /// <para>The idempotency token. Format: [0-9a-zA-Z-]{1,64}. A UUID is recommended.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a65451293e64979ba7a4b573950217fe</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to force the use of the group configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("forcedSetting")]
        [Validation(Required=false)]
        public bool? ForcedSetting { get; set; }

        /// <summary>
        /// <para>The name of the group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The notification configuration.</para>
        /// </summary>
        [NameInMap("notifyConfig")]
        [Validation(Required=false)]
        public List<CreateGroupRequestNotifyConfig> NotifyConfig { get; set; }
        public class CreateGroupRequestNotifyConfig : TeaModel {
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
            /// <para>The notification type. Valid values: DingDing.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-433aead7560571a87349d054b4</para>
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The RAM role. Length: 1 to 128 characters. The system assumes this role to execute the template when a new job is triggered. This parameter is required when the job trigger method is not manual.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ramName</para>
        /// </summary>
        [NameInMap("ramRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        /// <summary>
        /// <para>The list of export fields for the report.</para>
        /// </summary>
        [NameInMap("reportExportField")]
        [Validation(Required=false)]
        public List<string> ReportExportField { get; set; }

        /// <summary>
        /// <para>The export address for the execution report. OSS addresses are supported. Format: https://<OSS bucket endpoint>/<path>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://test.oss-cn-hangzhou.aliyuncs.com/test/test">https://test.oss-cn-hangzhou.aliyuncs.com/test/test</a></para>
        /// </summary>
        [NameInMap("reportExportPath")]
        [Validation(Required=false)]
        public string ReportExportPath { get; set; }

        /// <summary>
        /// <para>The Terraform provider version. Select a Terraform provider version. The version configured on the task takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.189.0</para>
        /// </summary>
        [NameInMap("terraformProviderVersion")]
        [Validation(Required=false)]
        public string TerraformProviderVersion { get; set; }

        /// <summary>
        /// <para>The trigger policy. This parameter is required when autoTrigger is set to true.</para>
        /// </summary>
        [NameInMap("triggerConfig")]
        [Validation(Required=false)]
        public List<CreateGroupRequestTriggerConfig> TriggerConfig { get; set; }
        public class CreateGroupRequestTriggerConfig : TeaModel {
            /// <summary>
            /// <para>The trigger policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ProviderNewVersion: Triggered when a new provider version is released.</description></item>
            /// <item><description>Cron: Triggered on a schedule.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Cron</para>
            /// </summary>
            [NameInMap("triggerStrategy")]
            [Validation(Required=false)]
            public string TriggerStrategy { get; set; }

            /// <summary>
            /// <para>The policy value for scheduled triggers. Specify a cron expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 19 * * ？</para>
            /// </summary>
            [NameInMap("triggerValue")]
            [Validation(Required=false)]
            public string TriggerValue { get; set; }

        }

        /// <summary>
        /// <para>The resource type for triggered execution. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Task: Regular task.</description></item>
        /// <item><description>SceneTestingTask: Scenario-based testing task.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("triggerResourceType")]
        [Validation(Required=false)]
        public List<string> TriggerResourceType { get; set; }

    }

}
