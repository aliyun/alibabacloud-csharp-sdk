// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class GetOrCreateInvitationCodeRequest : TeaModel {
        /// <summary>
        /// <para>The validity period in days, calculated from the current time. Set to -1 for permanent validity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ExpireDays")]
        [Validation(Required=false)]
        public int? ExpireDays { get; set; }

        /// <summary>
        /// <para>The validity period in minutes, calculated from the current time. Set to -1 for permanent validity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ExpireMinutes")]
        [Validation(Required=false)]
        public int? ExpireMinutes { get; set; }

        /// <summary>
        /// <para>The terminal group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tg-XXX</para>
        /// </summary>
        [NameInMap("TerminalGroupId")]
        [Validation(Required=false)]
        public string TerminalGroupId { get; set; }

        /// <summary>
        /// <para>The validity period type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: The response returns the expiration in days. This is the default value if Type is not specified.</description></item>
        /// <item><description>2: The response returns the expiration in minutes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cron</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
