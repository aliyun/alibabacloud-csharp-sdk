// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class LookupWmInfoMappingResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public LookupWmInfoMappingResponseBodyData Data { get; set; }
        public class LookupWmInfoMappingResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>aGVsbG8gc2F*****</para>
            /// </summary>
            [NameInMap("WmInfoBytesB64")]
            [Validation(Required=false)]
            public string WmInfoBytesB64 { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7E9D7ACD-53D5-56EF-A913-79D148D06299</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
