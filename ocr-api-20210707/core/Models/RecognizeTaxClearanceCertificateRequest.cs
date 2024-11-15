// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeTaxClearanceCertificateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/imgextra/i1/O1CN0131X3Xs1d1CHG8oypS_!!6000000003675-0-tps-1080-712.jpg">https://img.alicdn.com/imgextra/i1/O1CN0131X3Xs1d1CHG8oypS_!!6000000003675-0-tps-1080-712.jpg</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public Stream Body { get; set; }

    }

}
