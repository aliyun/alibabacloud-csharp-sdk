// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class SubmitDocumentAnalyzeJobResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public SubmitDocumentAnalyzeJobResponseBodyData Data { get; set; }
        public class SubmitDocumentAnalyzeJobResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>adkc-kk2k41-kk2ol-222424</para>
            /// </summary>
            [NameInMap("jobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4A0AEC56-5C9A-5D47-93DF-7227836FFF82</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
