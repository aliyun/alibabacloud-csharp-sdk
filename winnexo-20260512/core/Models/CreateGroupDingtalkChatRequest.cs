// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateGroupDingtalkChatRequest : TeaModel {
        /// <summary>
        /// <para>The platform application token issued by the console. If specified, the operation is performed as the user specified by opsUserId or opsUserCode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wn_app_xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("appToken")]
        [Validation(Required=false)]
        public string AppToken { get; set; }

        /// <summary>
        /// <para>The chat ID, which is generally used for JSSDK.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cidxxxxxxxx</para>
        /// </summary>
        [NameInMap("chatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// <para>The name of the group chat.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Customer project group</para>
        /// </summary>
        [NameInMap("chatName")]
        [Validation(Required=false)]
        public string ChatName { get; set; }

        /// <summary>
        /// <para>The description of the AI assistant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Customer group chat history</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The directory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleDirectoryId</para>
        /// </summary>
        [NameInMap("directoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The project group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleGroupId</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The start time for collecting chat records.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-01</para>
        /// </summary>
        [NameInMap("historyStartTime")]
        [Validation(Required=false)]
        public string HistoryStartTime { get; set; }

        /// <summary>
        /// <para>The content of the meeting notes. This parameter is optional and is used for auxiliary analysis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Focus on identifying customer demands and to-do items</para>
        /// </summary>
        [NameInMap("notes")]
        [Validation(Required=false)]
        public string Notes { get; set; }

        /// <summary>
        /// <para>The name of the digital employee, which is the name of the operating object. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent</para>
        /// </summary>
        [NameInMap("operatingObjectName")]
        [Validation(Required=false)]
        public string OperatingObjectName { get; set; }

        /// <summary>
        /// <para>The proxy user code, which is unique within the tenant. This parameter is used only when the application credential is configured as source_uid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("opsUserCode")]
        [Validation(Required=false)]
        public string OpsUserCode { get; set; }

        /// <summary>
        /// <para>The proxy user ID, which is the WINNEXO platform user ID. This parameter is used only when the application credential is configured as winnexo_uid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("opsUserId")]
        [Validation(Required=false)]
        public string OpsUserId { get; set; }

        /// <summary>
        /// <para>The source tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Customer&quot;,&quot;Group chat&quot;]</para>
        /// </summary>
        [NameInMap("sourceTags")]
        [Validation(Required=false)]
        public string SourceTags { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. For winnexo-cli, explicitly pass this parameter by using --tenant-id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The feature update frequency.</para>
        /// </summary>
        [NameInMap("updateFrequency")]
        [Validation(Required=false)]
        public CreateGroupDingtalkChatRequestUpdateFrequency UpdateFrequency { get; set; }
        public class CreateGroupDingtalkChatRequestUpdateFrequency : TeaModel {
            /// <summary>
            /// <para>The cron expression for the timed scheduling node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 2 * * *</para>
            /// </summary>
            [NameInMap("cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            /// <summary>
            /// <para>Specifies whether the throttling rule is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The preset mode. You can ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hourly</para>
            /// </summary>
            [NameInMap("preset")]
            [Validation(Required=false)]
            public string Preset { get; set; }

        }

    }

}
