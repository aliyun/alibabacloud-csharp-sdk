// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeKBSyncLinkAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The client ID of the source application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cli_a123456</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The synchronization configuration whitelist returned by source type. For DINGTALK, UserId can be returned. For FEISHU, FeishuChatMemberStaleTtlSeconds can be returned.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public DescribeKBSyncLinkAttributeResponseBodyConfig Config { get; set; }
        public class DescribeKBSyncLinkAttributeResponseBodyConfig : TeaModel {
            /// <summary>
            /// <para>The validity period of the group member success snapshot used for fallback reuse, in seconds. This field can be returned for DINGTALK and FEISHU synchronization links. Explicit general configurations take precedence. If it is not configured, Lark uses the legacy dedicated field. A value of -1 indicates that the snapshot never expires. A value of 0 indicates that snapshot fallback reuse is disabled. A positive integer indicates the maximum age of the snapshot allowed for reuse. If it is not configured for DingTalk, -1 is returned. If the general field is not explicitly configured for Lark, this field may not be returned, and the legacy dedicated field returns a valid value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("ChatMemberStaleTtlSeconds")]
            [Validation(Required=false)]
            public int? ChatMemberStaleTtlSeconds { get; set; }

            /// <summary>
            /// <para>The validity period of the Lark group member success snapshot used for fallback reuse, in seconds. This field is returned only for FEISHU synchronization links. A value of -1 indicates that the snapshot never expires. A value of 0 indicates that snapshot fallback reuse is disabled. A positive integer indicates the maximum age of the snapshot allowed for reuse. The valid value configured for the link is returned. If it is not configured, the default value -1 is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("FeishuChatMemberStaleTtlSeconds")]
            [Validation(Required=false)]
            public int? FeishuChatMemberStaleTtlSeconds { get; set; }

            /// <summary>
            /// <para>The ID of the DingTalk user who performs the operation. This field is returned only for DINGTALK synchronization links.</para>
            /// 
            /// <b>Example:</b>
            /// <para>manager123</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The time when the synchronization link was created. The time is displayed in the YYYY-MM-DDTHH:mm:ssZ format (UTC time).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-22T12:00:00Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The description of the synchronization link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Synchronize Lark knowledge base documents</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The source channel of the synchronization link. Valid values: OSS, DINGTALK, FEISHU, and SHAREPOINT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FEISHU</para>
        /// </summary>
        [NameInMap("ImPlatform")]
        [Validation(Required=false)]
        public string ImPlatform { get; set; }

        /// <summary>
        /// <para>The unique identifier of the synchronization link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pkbl-123456</para>
        /// </summary>
        [NameInMap("LinkId")]
        [Validation(Required=false)]
        public string LinkId { get; set; }

        /// <summary>
        /// <para>The name of the synchronization link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>feishu-doc-sync</para>
        /// </summary>
        [NameInMap("LinkName")]
        [Validation(Required=false)]
        public string LinkName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-1234-1234-1234567890ab</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returns the current configuration, which does not indicate that synchronization is complete. This field may not be returned if it is not set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECTED</para>
        /// </summary>
        [NameInMap("SelectionMode")]
        [Validation(Required=false)]
        public string SelectionMode { get; set; }

        /// <summary>
        /// <para>Returns the current configuration, which does not indicate that synchronization is complete. This field may not be returned if it is not set.</para>
        /// </summary>
        [NameInMap("SelectionRules")]
        [Validation(Required=false)]
        public string SelectionRules { get; set; }

        /// <summary>
        /// <para>The switch for source deletion synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SourceDeleteSyncEnabled")]
        [Validation(Required=false)]
        public bool? SourceDeleteSyncEnabled { get; set; }

        /// <summary>
        /// <para>The source directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/documents</para>
        /// </summary>
        [NameInMap("SourceDir")]
        [Validation(Required=false)]
        public string SourceDir { get; set; }

        /// <summary>
        /// <para>The automatic synchronization interval, in minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("SyncIntervalMinutes")]
        [Validation(Required=false)]
        public int? SyncIntervalMinutes { get; set; }

        /// <summary>
        /// <para>The status of the synchronization link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("SyncStatus")]
        [Validation(Required=false)]
        public string SyncStatus { get; set; }

    }

}
