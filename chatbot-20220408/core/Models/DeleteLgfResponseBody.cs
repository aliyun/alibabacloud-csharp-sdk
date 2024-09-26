// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DeleteLgfResponseBody : TeaModel {
        /// <summary>
        /// <para>LGF ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>2342424</para>
        /// </summary>
        [NameInMap("LgfId")]
        [Validation(Required=false)]
        public long? LgfId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dgw2342424qw42</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
