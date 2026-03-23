// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class GetSendifyAutoLoginURLResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://dingstore.cn">https://dingstore.cn</a></para>
        /// </summary>
        [NameInMap("AutoLoginURL")]
        [Validation(Required=false)]
        public string AutoLoginURL { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123423</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
