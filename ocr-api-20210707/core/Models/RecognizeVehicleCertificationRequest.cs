// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeVehicleCertificationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/imgextra/i1/O1CN0196uE7i1FXD9TpYqLy_!!6000000000496-0-tps-3024-4032.jpg">https://img.alicdn.com/imgextra/i1/O1CN0196uE7i1FXD9TpYqLy_!!6000000000496-0-tps-3024-4032.jpg</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public Stream Body { get; set; }

    }

}
