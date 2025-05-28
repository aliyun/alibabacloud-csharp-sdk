// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class UpdateTicketNumRequest : TeaModel {
        /// <summary>
        /// <para>The value of the third-party embedded ticket, that is, the accessTicket value in the URL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>040e6f79d33444838***83c7206c070</para>
        /// </summary>
        [NameInMap("Ticket")]
        [Validation(Required=false)]
        public string Ticket { get; set; }

        /// <summary>
        /// <para>The number of bills.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: 1 to 99998. Recommended value: 1.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TicketNum")]
        [Validation(Required=false)]
        public int? TicketNum { get; set; }

    }

}
