// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class UpdateLgfResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2342556223532</para>
        /// </summary>
        [NameInMap("LgfId")]
        [Validation(Required=false)]
        public long? LgfId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>289dfa131adf23wqe2r</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
