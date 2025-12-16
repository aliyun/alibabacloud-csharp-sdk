// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeAuthVerifyResponseBody : TeaModel {
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
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAuthVerifyResponseBodyResult Result { get; set; }
        public class DescribeAuthVerifyResponseBodyResult : TeaModel {
            [NameInMap("MaterialInfo")]
            [Validation(Required=false)]
            public string MaterialInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>spoofRiskResult：Y
            /// spoofType：SCREEN_REMARK</para>
            /// </summary>
            [NameInMap("SpoofBackInfo")]
            [Validation(Required=false)]
            public string SpoofBackInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>spoofRiskResult：Y
            /// spoofType：SCREEN_REMARK</para>
            /// </summary>
            [NameInMap("SpoofInfo")]
            [Validation(Required=false)]
            public string SpoofInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

        }

    }

}
