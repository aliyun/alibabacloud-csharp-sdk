// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeMedicalDeviceProduceLicenseRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/tfs/TB13MJ.MuT2gK0jSZFvXXXnFXXa-1417-994.png">https://img.alicdn.com/tfs/TB13MJ.MuT2gK0jSZFvXXXnFXXa-1417-994.png</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public Stream Body { get; set; }

    }

}
