// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryTicketInfoRequest : TeaModel {
        /// <summary>
        /// <para>The value of the bill.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a27a9aec-<b><b>-</b></b>-bd40-1a21ea41d7c5</para>
        /// </summary>
        [NameInMap("Ticket")]
        [Validation(Required=false)]
        public string Ticket { get; set; }

    }

}
