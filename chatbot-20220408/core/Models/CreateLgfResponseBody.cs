// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateLgfResponseBody : TeaModel {
        /// <summary>
        /// <para>LGF ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>123453433453</para>
        /// </summary>
        [NameInMap("LgfId")]
        [Validation(Required=false)]
        public long? LgfId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>af5fg3sdf457j5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
