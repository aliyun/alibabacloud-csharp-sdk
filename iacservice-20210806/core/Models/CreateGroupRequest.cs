// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateGroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoDestroy")]
        [Validation(Required=false)]
        public bool? AutoDestroy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoTrigger")]
        [Validation(Required=false)]
        public bool? AutoTrigger { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a65451293e64979ba7a4b573950217fe</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("forcedSetting")]
        [Validation(Required=false)]
        public bool? ForcedSetting { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("notifyConfig")]
        [Validation(Required=false)]
        public List<CreateGroupRequestNotifyConfig> NotifyConfig { get; set; }
        public class CreateGroupRequestNotifyConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("notifyPath")]
            [Validation(Required=false)]
            public string NotifyPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DingDing</para>
            /// </summary>
            [NameInMap("notifyType")]
            [Validation(Required=false)]
            public string NotifyType { get; set; }

        }

        [NameInMap("notifyOperationTypes")]
        [Validation(Required=false)]
        public List<string> NotifyOperationTypes { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-433aead7560571a87349d054b4</para>
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ramName</para>
        /// </summary>
        [NameInMap("ramRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        [NameInMap("reportExportField")]
        [Validation(Required=false)]
        public List<string> ReportExportField { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://test.oss-cn-hangzhou.aliyuncs.com/test/test">https://test.oss-cn-hangzhou.aliyuncs.com/test/test</a></para>
        /// </summary>
        [NameInMap("reportExportPath")]
        [Validation(Required=false)]
        public string ReportExportPath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.189.0</para>
        /// </summary>
        [NameInMap("terraformProviderVersion")]
        [Validation(Required=false)]
        public string TerraformProviderVersion { get; set; }

        [NameInMap("triggerConfig")]
        [Validation(Required=false)]
        public List<CreateGroupRequestTriggerConfig> TriggerConfig { get; set; }
        public class CreateGroupRequestTriggerConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Cron</para>
            /// </summary>
            [NameInMap("triggerStrategy")]
            [Validation(Required=false)]
            public string TriggerStrategy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0 0 19 * * ？</para>
            /// </summary>
            [NameInMap("triggerValue")]
            [Validation(Required=false)]
            public string TriggerValue { get; set; }

        }

        [NameInMap("triggerResourceType")]
        [Validation(Required=false)]
        public List<string> TriggerResourceType { get; set; }

    }

}
