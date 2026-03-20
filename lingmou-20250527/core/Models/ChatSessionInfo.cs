// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LingMou20250527.Models
{
    public class ChatSessionInfo : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1755680969</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234567</para>
        /// </summary>
        [NameInMap("mainAccountId")]
        [Validation(Required=false)]
        public long? MainAccountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7239F9E5-A4DB-55BA-B701-0CE47DBDB0A8</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
