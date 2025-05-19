// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class DescribeHybridDoubleWriteResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7985D471-3FA8-4EE9-8F4B-45C19DF3D36F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeHybridDoubleWriteResponseBodyResult> Result { get; set; }
        public class DescribeHybridDoubleWriteResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test-target</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-source</para>
            /// </summary>
            [NameInMap("SourceNamespace")]
            [Validation(Required=false)]
            public string SourceNamespace { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12706766**********</para>
            /// </summary>
            [NameInMap("SourceUserId")]
            [Validation(Required=false)]
            public long? SourceUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11234766**********</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
