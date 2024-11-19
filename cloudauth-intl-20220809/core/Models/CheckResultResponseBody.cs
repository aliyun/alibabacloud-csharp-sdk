// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class CheckResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EB35****87EBA1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CheckResultResponseBodyResult Result { get; set; }
        public class CheckResultResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>**</para>
            /// </summary>
            [NameInMap("EkycResult")]
            [Validation(Required=false)]
            public string EkycResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>**</para>
            /// </summary>
            [NameInMap("ExtBasicInfo")]
            [Validation(Required=false)]
            public string ExtBasicInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>**</para>
            /// </summary>
            [NameInMap("ExtFaceInfo")]
            [Validation(Required=false)]
            public string ExtFaceInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>**</para>
            /// </summary>
            [NameInMap("ExtIdInfo")]
            [Validation(Required=false)]
            public string ExtIdInfo { get; set; }

            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>**</para>
            /// </summary>
            [NameInMap("ExtRiskInfo")]
            [Validation(Required=false)]
            public string ExtRiskInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public string Passed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

        }

    }

}
