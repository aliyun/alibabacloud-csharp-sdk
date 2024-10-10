// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class DelayTicketExpireTimeRequest : TeaModel {
        /// <summary>
        /// <para>The time to postpone.</para>
        /// <list type="bullet">
        /// <item><description>Unit: minutes. Valid values: 0 to 240. Unit: minutes. Valid values: 4 hours.</description></item>
        /// <item><description>Expired bills cannot be extended.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public int? ExpireTime { get; set; }

        /// <summary>
        /// <para>The value of the third-party embedded ticket, that is, the accessTicket value in the URL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>040e6f79d33444838e*****c7206c070</para>
        /// </summary>
        [NameInMap("Ticket")]
        [Validation(Required=false)]
        public string Ticket { get; set; }

    }

}
