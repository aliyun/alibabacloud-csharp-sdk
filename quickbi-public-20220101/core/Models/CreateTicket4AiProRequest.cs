// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class CreateTicket4AiProRequest : TeaModel {
        /// <summary>
        /// <para>The account of the access user to bind. Use this parameter together with AccountType when QuickBIUserId is not specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The account type of the user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Alibaba Cloud account.</description></item>
        /// <item><description>3: Quick BI custom account.</description></item>
        /// <item><description>4: DingTalk.</description></item>
        /// <item><description>5: RAM user.</description></item>
        /// <item><description>9: WeCom.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public int? AccountType { get; set; }

        /// <summary>
        /// <para>The ID of the AIPro embedding configuration. The configuration must exist, belong to the current organization, and have a status of 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AiProId")]
        [Validation(Required=false)]
        public string AiProId { get; set; }

        /// <summary>
        /// <para>The custom pass-through parameter. If specified, it must be a valid JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("CustomParam")]
        [Validation(Required=false)]
        public string CustomParam { get; set; }

        /// <summary>
        /// <para>The validity period of the ticket, in minutes. Default value: 240. The value must be greater than 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public int? ExpireTime { get; set; }

        /// <summary>
        /// <para>The QuickBI user ID of the access user to bind. Specify either this parameter or the combination of AccountName and AccountType.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("QuickBIUserId")]
        [Validation(Required=false)]
        public string QuickBIUserId { get; set; }

        /// <summary>
        /// <para>The custom system identifier. The length must be less than 150 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SystemUid")]
        [Validation(Required=false)]
        public string SystemUid { get; set; }

        /// <summary>
        /// <para>The number of times the ticket can be used. Default value: 1. Valid values: 1 to 99999.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TicketNum")]
        [Validation(Required=false)]
        public int? TicketNum { get; set; }

    }

}
