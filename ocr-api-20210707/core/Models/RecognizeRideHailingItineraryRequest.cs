// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeRideHailingItineraryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/imgextra/i1/O1CN01ePLJiZ1n8CTylKsn3_!!6000000005044-2-tps-194-260.png">https://img.alicdn.com/imgextra/i1/O1CN01ePLJiZ1n8CTylKsn3_!!6000000005044-2-tps-194-260.png</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public Stream Body { get; set; }

    }

}
