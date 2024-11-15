// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeVehicleRegistrationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/imgextra/i1/O1CN01NA1F7A1cSO8cnFQ7m_!!6000000003599-0-tps-844-1125.jpg">https://img.alicdn.com/imgextra/i1/O1CN01NA1F7A1cSO8cnFQ7m_!!6000000003599-0-tps-844-1125.jpg</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public Stream Body { get; set; }

    }

}
