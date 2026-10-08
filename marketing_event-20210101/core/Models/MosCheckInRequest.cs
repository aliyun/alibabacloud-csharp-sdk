// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Marketing_event20210101.Models
{
    public class MosCheckInRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>INTL1234</para>
        /// </summary>
        [NameInMap("ActivityId")]
        [Validation(Required=false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ExtParam")]
        [Validation(Required=false)]
        public string ExtParam { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc12345</para>
        /// </summary>
        [NameInMap("QrCode")]
        [Validation(Required=false)]
        public string QrCode { get; set; }

    }

}
