// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetLogTicketResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>*******。</para>
        /// </summary>
        [NameInMap("LogTicket")]
        [Validation(Required=false)]
        public string LogTicket { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>173326*******。</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
