// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FaRui20240628.Models
{
    public class CreateTextFileResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Request.Signature.Error</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateTextFileResponseBodyData Data { get; set; }
        public class CreateTextFileResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>36d6447d277c4a1c9fd0def1d16341f1</para>
            /// </summary>
            [NameInMap("TextFileId")]
            [Validation(Required=false)]
            public string TextFileId { get; set; }

            [NameInMap("TextFileName")]
            [Validation(Required=false)]
            public string TextFileName { get; set; }

            [NameInMap("TextFileUrl")]
            [Validation(Required=false)]
            public string TextFileUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>81E6F6D2-8ACB-5BDA-9C7C-4D6268CD9652</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
