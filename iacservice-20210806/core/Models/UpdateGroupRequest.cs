// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class UpdateGroupRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically delete the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoDestroy")]
        [Validation(Required=false)]
        public bool? AutoDestroy { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the automatic trigger policy. Valid values: - <b>true</b>: enabled. - <b>false</b>: disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoTrigger")]
        [Validation(Required=false)]
        public bool? AutoTrigger { get; set; }

        /// <summary>
        /// <para>The idempotency token. Format: [0-9a-zA-Z-]{1,64}. We recommend that you use a UUID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a65451293e64979ba7a4b573950217fe</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The group description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly use the group configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("forcedSetting")]
        [Validation(Required=false)]
        public bool? ForcedSetting { get; set; }

        /// <summary>
        /// <para>The group name.</para>
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
        public List<UpdateGroupRequestNotifyConfig> NotifyConfig { get; set; }
        public class UpdateGroupRequestNotifyConfig : TeaModel {
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
        /// <para>The RAM role (1-128 characters). The system assumes this role to execute the template when a new job is triggered. This parameter is required when the job trigger method is not manual.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
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
        /// <para>The export path for the execution report. OSS paths are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("reportExportPath")]
        [Validation(Required=false)]
        public string ReportExportPath { get; set; }

        /// <summary>
        /// <para>The Terraform Provider version. Select a Terraform Provider version. Nodes in the group execute plans based on the specified Terraform Provider version. The version configured on a node takes higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.183.0</para>
        /// </summary>
        [NameInMap("terraformProviderVersion")]
        [Validation(Required=false)]
        public string TerraformProviderVersion { get; set; }

        /// <summary>
        /// <para>The trigger policy. This parameter cannot be empty when autoTrigger is set to true.</para>
        /// </summary>
        [NameInMap("triggerConfig")]
        [Validation(Required=false)]
        public List<UpdateGroupRequestTriggerConfig> TriggerConfig { get; set; }
        public class UpdateGroupRequestTriggerConfig : TeaModel {
            /// <summary>
            /// <para>The trigger strategy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ProviderNewVersion: triggered when a new Provider version is released.</description></item>
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
            /// <para>The policy value that must be maintained for scheduled triggers. This value is a cron expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 * * * ？</para>
            /// </summary>
            [NameInMap("triggerValue")]
            [Validation(Required=false)]
            public string TriggerValue { get; set; }

        }

        /// <summary>
        /// <para>The resource type that triggers execution. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Task: regular node.</description></item>
        /// <item><description>SceneTestingTask: scenario-based testing node.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("triggerResourceType")]
        [Validation(Required=false)]
        public List<string> TriggerResourceType { get; set; }

    }

}
