// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
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
            /// <para>72CFDC08-3FEF-56AA-91E5-B14DE31C09C2</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;tags\&quot;:[{\&quot;confidence\&quot;:-1,\&quot;value\&quot;:\&quot;{\\\&quot;tagInfo\\\&quot;: {\\\&quot;humanInfo\\\&quot;: [[{\\\&quot;category\\\&quot;: \\\&quot;human-real-normal\\\&quot;, \\\&quot;score\\\&quot;: 0.9690580798778683, \\\&quot;bbox\\\&quot;: [77, 280, 431, 569], \\\&quot;cloth_category\\\&quot;: \\\&quot;modern\\\&quot;, \\\&quot;cloth_category_score\\\&quot;: 0.7393399477005005}]], \\\&quot;sceneInfo\\\&quot;: [[{\\\&quot;category\\\&quot;: \\\&quot;gamescreen-gameeffect\\\&quot;, \\\&quot;score\\\&quot;: 0.44200169294841274}]], \\\&quot;objectInfo\\\&quot;: [null]}}\&quot;}]}</para>
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
        /// <para>572974F0-1014-5C60-97EE-DBFFC0FF7616</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
