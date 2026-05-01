// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class RemoveRuntimeModelTemplateResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<RemoveRuntimeModelTemplateResponseBodyData> Data { get; set; }
        public class RemoveRuntimeModelTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Runtime.NotFound</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>404</para>
            /// </summary>
            [NameInMap("HttpStatusCode")]
            [Validation(Required=false)]
            public int? HttpStatusCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>The runtime is not found.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>jvs-xxxxx</para>
            /// </summary>
            [NameInMap("RuntimeId")]
            [Validation(Required=false)]
            public string RuntimeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
