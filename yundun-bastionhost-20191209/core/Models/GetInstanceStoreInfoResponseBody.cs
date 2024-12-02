// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetInstanceStoreInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>102400</para>
        /// </summary>
        [NameInMap("Max")]
        [Validation(Required=false)]
        public long? Max { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5EAB922E-F476-5DFA-9290-313C608E724B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Usage")]
        [Validation(Required=false)]
        public long? Usage { get; set; }

    }

}
