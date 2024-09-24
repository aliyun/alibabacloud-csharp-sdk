// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class PublicPreCheckImageScanTaskResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PublicPreCheckImageScanTaskResponseBodyData Data { get; set; }
        public class PublicPreCheckImageScanTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("NeedAuthCount")]
            [Validation(Required=false)]
            public int? NeedAuthCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ScanImageCount")]
            [Validation(Required=false)]
            public int? ScanImageCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F9353221-40F4-5F98-B73C-2803DC804033</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
