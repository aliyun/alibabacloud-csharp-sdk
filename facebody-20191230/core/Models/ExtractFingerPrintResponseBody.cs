// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class ExtractFingerPrintResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ExtractFingerPrintResponseBodyData Data { get; set; }
        public class ExtractFingerPrintResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>/9j/4AAQSkZJRgABAQAAAQABAAD****</para>
            /// </summary>
            [NameInMap("FingerPrint")]
            [Validation(Required=false)]
            public string FingerPrint { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D21978CC-C1E7-4A7A-A1B2-D5896BDC7ADF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
