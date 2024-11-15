// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeExitEntryPermitToHKRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true/false</para>
        /// </summary>
        [NameInMap("OutputFigure")]
        [Validation(Required=false)]
        public bool? OutputFigure { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/imgextra/i2/O1CN01Rs4C321G2oTD7Dg1U_!!6000000000565-0-tps-1024-692.jpg">https://img.alicdn.com/imgextra/i2/O1CN01Rs4C321G2oTD7Dg1U_!!6000000000565-0-tps-1024-692.jpg</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public Stream Body { get; set; }

    }

}
