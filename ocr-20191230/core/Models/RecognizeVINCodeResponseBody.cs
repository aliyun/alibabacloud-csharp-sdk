// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeVINCodeResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeVINCodeResponseBodyData Data { get; set; }
        public class RecognizeVINCodeResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>LVBB2FAF777999888</para>
            /// </summary>
            [NameInMap("VinCode")]
            [Validation(Required=false)]
            public string VinCode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>911FC8CF-CC27-477E-BE3B-7ED77DF4DFE0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
