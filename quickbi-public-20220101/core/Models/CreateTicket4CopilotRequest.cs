// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class CreateTicket4CopilotRequest : TeaModel {
        /// <summary>
        /// <para>User\&quot;s account name.
        /// <notice>Note: Only one of userId and accountName needs to be filled in. If neither is provided, it will default to the report owner, and the report will be accessed with that user\&quot;s identity.</notice></para>
        /// 
        /// <b>Example:</b>
        /// <para>Test user</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>User\&quot;s account type:</para>
        /// <list type="bullet">
        /// <item><description><para>1: Alibaba Cloud Primary Account</para>
        /// </description></item>
        /// <item><description><para>3: Quick BI Self-built Account</para>
        /// </description></item>
        /// <item><description><para>4: DingTalk</para>
        /// </description></item>
        /// <item><description><para>5: Alibaba Cloud RAM Account</para>
        /// </description></item>
        /// <item><description><para>6: Third-party Account (SAML, OAuth, etc.)</para>
        /// </description></item>
        /// <item><description><para>9: WeCom</para>
        /// </description></item>
        /// <item><description><para>10: Feishu</para>
        /// </description></item>
        /// </list>
        /// <para><notice>Note: If accountName is not empty, then accountType must also be provided.</notice></para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public int? AccountType { get; set; }

        /// <summary>
        /// <para>ID of the Smart Q module to be embedded.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccd3*********ae29dffee</para>
        /// </summary>
        [NameInMap("CopilotId")]
        [Validation(Required=false)]
        public string CopilotId { get; set; }

        /// <summary>
        /// <para>Expiration time.</para>
        /// <list type="bullet">
        /// <item><description><para>Unit: minutes, maximum 240 (4 hours).</para>
        /// </description></item>
        /// <item><description><para>Default: 240.</para>
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
        /// <para>Range of ticket quantity:</para>
        /// <list type="bullet">
        /// <item><description><para>Default value is 1.</para>
        /// </description></item>
        /// <item><description><para>Recommended value is 1.</para>
        /// </description></item>
        /// <item><description><para>Maximum value is 99999.</para>
        /// </description></item>
        /// </list>
        /// <para>Each time a ticket is used, the ticket count decreases by 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TicketNum")]
        [Validation(Required=false)]
        public int? TicketNum { get; set; }

        /// <summary>
        /// <para>Quick BI\&quot;s UserId.</para>
        /// <list type="bullet">
        /// <item><description>You can obtain this by calling [3.1.7 Get User Details Based on Third-Party Account] or other relevant APIs.</description></item>
        /// </list>
        /// <para><notice>Note: Only one of userId and accountName needs to be filled in. If neither is provided, it will default to the report owner, and the report will be accessed with that user\&quot;s identity.</notice></para>
        /// 
        /// <b>Example:</b>
        /// <para>9c-asd*****asd-asdasd</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
