// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class CreateMmsFetchMetadataJobResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateMmsFetchMetadataJobResponseBodyData Data { get; set; }
        public class CreateMmsFetchMetadataJobResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1000002</para>
            /// </summary>
            [NameInMap("scanId")]
            [Validation(Required=false)]
            public long? ScanId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CC4D05E8-0613-5A8E-9339-A0EBD097A69E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
