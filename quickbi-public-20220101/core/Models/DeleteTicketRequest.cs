// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class DeleteTicketRequest : TeaModel {
        /// <summary>
        /// <para>The value of the third-party embedded ticket, which is the <c>accessTicket</c> in the URL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>040e6f79d****7d283c7206c070</para>
        /// </summary>
        [NameInMap("Ticket")]
        [Validation(Required=false)]
        public string Ticket { get; set; }

    }

}
