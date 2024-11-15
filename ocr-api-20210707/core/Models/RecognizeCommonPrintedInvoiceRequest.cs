// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeCommonPrintedInvoiceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/imgextra/i2/O1CN01XU9dTh1O4CdHxXhMw_!!6000000001651-0-tps-1437-909.jpg">https://img.alicdn.com/imgextra/i2/O1CN01XU9dTh1O4CdHxXhMw_!!6000000001651-0-tps-1437-909.jpg</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public Stream Body { get; set; }

    }

}
