// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAICopilot20250731.Models
{
    public class ListChatsResponseBody : TeaModel {
        [NameInMap("Chats")]
        [Validation(Required=false)]
        public List<Chat> Chats { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>44553E9A-******-37ADC33FE2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
