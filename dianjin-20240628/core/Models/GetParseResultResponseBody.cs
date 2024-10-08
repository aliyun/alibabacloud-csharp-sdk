// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetParseResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetParseResultResponseBodyData Data { get; set; }
        public class GetParseResultResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("providerType")]
            [Validation(Required=false)]
            public string ProviderType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>b0a202e2-5031-4589-a6d7-39185f0d8d01</para>
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///           &quot;Status&quot;: &quot;Success&quot;,
            ///           &quot;Data&quot;: {},
            ///           &quot;Message&quot;: null,
            ///           &quot;TaskId&quot;: &quot;docmind-20240601-123abc&quot;
            ///         }</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public Dictionary<string, object> Result { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>WaitRefresh</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0abb793617204049360065953ec6dd</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-04-24 11:54:34</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
