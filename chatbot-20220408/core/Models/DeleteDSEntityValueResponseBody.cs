// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DeleteDSEntityValueResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3453453452</para>
        /// </summary>
        [NameInMap("EntityValueId")]
        [Validation(Required=false)]
        public long? EntityValueId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dfdf2t3rfvb45y</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
