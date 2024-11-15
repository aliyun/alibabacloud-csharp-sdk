// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeBankAcceptanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/imgextra/i1/O1CN016eNk0d1ubhKP4y6gK_!!6000000006056-2-tps-631-570.png">https://img.alicdn.com/imgextra/i1/O1CN016eNk0d1ubhKP4y6gK_!!6000000006056-2-tps-631-570.png</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public Stream Body { get; set; }

    }

}
