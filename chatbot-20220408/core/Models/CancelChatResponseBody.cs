// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CancelChatResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of calling this operation.</para>
        /// </summary>
        [NameInMap("CancelResult")]
        [Validation(Required=false)]
        public bool? CancelResult { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E3E5C779-A630-45AC-B0F2-A4506A4212F1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
