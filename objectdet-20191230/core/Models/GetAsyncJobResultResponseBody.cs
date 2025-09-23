// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class GetAsyncJobResultResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAsyncJobResultResponseBodyData Data { get; set; }
        public class GetAsyncJobResultResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>InvalidParameter</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>paramsIllegal</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>35B11E1B-800C-4598-B5AA-577E3BDBD917</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;inputFile\&quot;:\&quot;oss://public-vigen-video/guotian.xgt/test_images/test_video\&quot;,\&quot;width\&quot;:1280,\&quot;height\&quot;:720,\&quot;frames\&quot;:[{\&quot;time\&quot;:6124533574,\&quot;elements\&quot;:[{\&quot;type\&quot;:\&quot;PERSON\&quot;,\&quot;score\&quot;:0.7812,\&quot;x\&quot;:289,\&quot;y\&quot;:271,\&quot;width\&quot;:100,\&quot;height\&quot;:156},{\&quot;type\&quot;:\&quot;PERSON\&quot;,\&quot;score\&quot;:0.4377,\&quot;x\&quot;:917,\&quot;y\&quot;:267,\&quot;width\&quot;:34,\&quot;height\&quot;:51}]}]}]}&quot;}</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PROCESS_SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>87FC80D2-2571-4BBD-BD61-AFF7912C556D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
