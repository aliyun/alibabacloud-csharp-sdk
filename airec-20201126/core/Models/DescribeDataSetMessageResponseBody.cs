// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class DescribeDataSetMessageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>InternalServerError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>An internal server error occurred</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8F81A922-6C81-46D6-B78C-CC35E16B1691</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<DescribeDataSetMessageResponseBodyResult> Result { get; set; }
        public class DescribeDataSetMessageResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>warn</para>
            /// </summary>
            [NameInMap("errorLevel")]
            [Validation(Required=false)]
            public string ErrorLevel { get; set; }

            [NameInMap("errorType")]
            [Validation(Required=false)]
            public string ErrorType { get; set; }

            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20181211 17:27:44</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

        }

    }

}
