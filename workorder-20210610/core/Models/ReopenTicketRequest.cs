// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class ReopenTicketRequest : TeaModel {
        /// <summary>
        /// <para>The content of the reply to reopen the ticket.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The issue has not been resolved yet.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The ticket ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0005PYGCW</para>
        /// </summary>
        [NameInMap("TicketId")]
        [Validation(Required=false)]
        public string TicketId { get; set; }

        /// <summary>
        /// <para>The UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1013872004421947</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
