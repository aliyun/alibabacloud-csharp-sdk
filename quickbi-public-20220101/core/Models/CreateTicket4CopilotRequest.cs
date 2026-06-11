// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class CreateTicket4CopilotRequest : TeaModel {
        /// <summary>
        /// <para>The name of the user account.</para>
        /// <remarks>
        /// <para>Notice: Note: Specify either UserId or AccountName. If you leave both parameters empty, the ticket is bound to the API caller by default. Access is then granted based on the caller\&quot;s identity.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>测试用户</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The type of the user account:</para>
        /// <list type="bullet">
        /// <item><description><para>1: Alibaba Cloud account</para>
        /// </description></item>
        /// <item><description><para>3: Quick BI user</para>
        /// </description></item>
        /// <item><description><para>4: DingTalk</para>
        /// </description></item>
        /// <item><description><para>5: RAM user</para>
        /// </description></item>
        /// <item><description><para>6: Third-party account (an account integrated using protocols such as SAML or OAuth)</para>
        /// </description></item>
        /// <item><description><para>9: WeCom</para>
        /// </description></item>
        /// <item><description><para>10: Lark</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>Note: This parameter is required if you specify AccountName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public int? AccountType { get; set; }

        /// <summary>
        /// <para>The ID of the embedded Copilot module.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccd3428c-dd23-460c-a608-26bae29dffee</para>
        /// </summary>
        [NameInMap("CopilotId")]
        [Validation(Required=false)]
        public string CopilotId { get; set; }

        /// <summary>
        /// <para>The expiration time of the ticket.</para>
        /// <list type="bullet">
        /// <item><description><para>Unit: minutes. The maximum validity period is 240 minutes (4 hours).</para>
        /// </description></item>
        /// <item><description><para>Default: 240 minutes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public int? ExpireTime { get; set; }

        /// <summary>
        /// <para>The number of times the ticket can be used. The value can range from 1 to 99,999.</para>
        /// <list type="bullet">
        /// <item><description><para>Default: 1.</para>
        /// </description></item>
        /// <item><description><para>Recommended: 1.</para>
        /// </description></item>
        /// <item><description><para>Maximum: 99,999.</para>
        /// </description></item>
        /// </list>
        /// <para>Each access decrements the ticket\&quot;s usage count by one.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TicketNum")]
        [Validation(Required=false)]
        public int? TicketNum { get; set; }

        /// <summary>
        /// <para>The ID of the Quick BI user. This is not your Alibaba Cloud account ID. Call the QueryUserInfoByAccount operation to obtain the user ID. Example: <c>fe67f61a35a94b7da1a34ba174a7****</c>.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>Note: Specify either UserId or AccountName. If you leave both parameters empty, the ticket is bound to the API caller by default. Access is then granted based on the caller\&quot;s identity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9c-asdawf-casxcasd-asdasd</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
