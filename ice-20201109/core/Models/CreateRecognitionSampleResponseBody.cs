// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateRecognitionSampleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b><b><b><b><b>4d2ba728e2f</b></b></b></b></b></b></b></para>
        /// </summary>
        [NameInMap("SampleId")]
        [Validation(Required=false)]
        public string SampleId { get; set; }

    }

}
