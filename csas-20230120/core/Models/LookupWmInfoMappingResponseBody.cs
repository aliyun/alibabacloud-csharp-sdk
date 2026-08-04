// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class LookupWmInfoMappingResponseBody : TeaModel {
        /// <summary>
        /// <para>Query result of the mapping.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public LookupWmInfoMappingResponseBodyData Data { get; set; }
        public class LookupWmInfoMappingResponseBodyData : TeaModel {
            /// <summary>
            /// <para>String-formatted watermark information obtained from the mapping lookup. Value source:</para>
            /// <list type="bullet">
            /// <item><description><a href="~~CreateWmInfoMapping~~">CreateWmInfoMapping</a>: The <b>WmInfoBytesB64</b> parameter from the CreateWmInfoMapping API.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>aGVsbG8gc2F*****</para>
            /// </summary>
            [NameInMap("WmInfoBytesB64")]
            [Validation(Required=false)]
            public string WmInfoBytesB64 { get; set; }

        }

        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E9D7ACD-53D5-56EF-A913-79D148D06299</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
