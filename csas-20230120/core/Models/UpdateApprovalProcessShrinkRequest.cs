// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateApprovalProcessShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The approval type. Valid values: 0 (built-in approval), 1 (DingTalk approval), 2 (WeCom approval), and 3 (Lark approval). Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ApprovalType")]
        [Validation(Required=false)]
        public int? ApprovalType { get; set; }

        /// <summary>
        /// <para>The description of the approval process. The description must be 1 to 128 characters in length and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), hyphens (-), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office endpoint software installation and uninstallation approval process</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The event callback identifier. When the approval type is 1 (DingTalk approval) or 3 (Lark approval), this parameter is used to generate the event callback URL for the external platform. You can pass a complete callback URL, and the server retains only the part after the callback path prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://callback.example.com/sase/api/v1/approval/dingtalk/callback/9m4e2mr0ui3e8a21">https://callback.example.com/sase/api/v1/approval/dingtalk/callback/9m4e2mr0ui3e8a21</a>****</para>
        /// </summary>
        [NameInMap("EventLabel")]
        [Validation(Required=false)]
        public string EventLabel { get; set; }

        /// <summary>
        /// <para>The integration configuration for the external approval platform. This parameter is required when the approval type is 1 (DingTalk approval) or 3 (Lark approval). It includes integration parameters such as appKey and appSecret, and must be passed as a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;appKey&quot;:&quot;dingn1a2b3c4d5e6f****&quot;,&quot;appSecret&quot;:&quot;f9c8e7d6a5b4c3d2e1f0a9b8c7d6e5f4a3b2c1d0e9f8a7b6c5d4e3f2a1b0****&quot;,&quot;eventVerifyToken&quot;:&quot;7a8b9c0d1e2f3a4b5c6d7e8f9a0b****&quot;,&quot;eventAesKey&quot;:&quot;1a2b3c4d5e6f7g8h9i0j1k2l3m4n5o6p7q8r9s0t****&quot;}</para>
        /// </summary>
        [NameInMap("ExternalConfig")]
        [Validation(Required=false)]
        public string ExternalConfig { get; set; }

        /// <summary>
        /// <para>The external approval template configurations. Configure the approval template ID, external approval process ID, and field mappings based on the policy type. This parameter is used only when ApprovalType is set to 1 (DingTalk approval), 2 (WeCom approval), or 3 (Lark approval). If this parameter is not passed, the existing template associations of the approval process are cleared. The approval templates associated with business policies cannot be cleared.</para>
        /// </summary>
        [NameInMap("MatchSchemaConfigs")]
        [Validation(Required=false)]
        public string MatchSchemaConfigsShrink { get; set; }

        /// <summary>
        /// <para>The matched approval templates.</para>
        /// </summary>
        [NameInMap("MatchSchemas")]
        [Validation(Required=false)]
        public string MatchSchemasShrink { get; set; }

        /// <summary>
        /// <para>The ID of the approval process.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>approval-process-f16bf74b2b29****</para>
        /// </summary>
        [NameInMap("ProcessId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

        /// <summary>
        /// <para>The name of the approval process. The name must be 1 to 128 characters in length and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Endpoint software installation approval process</para>
        /// </summary>
        [NameInMap("ProcessName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        /// <summary>
        /// <para>The list of approval nodes. You can define up to 5 approval nodes.</para>
        /// </summary>
        [NameInMap("ProcessNodes")]
        [Validation(Required=false)]
        public List<List<string>> ProcessNodes { get; set; }

    }

}
