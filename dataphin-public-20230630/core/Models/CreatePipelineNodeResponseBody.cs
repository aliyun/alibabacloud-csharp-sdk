// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreatePipelineNodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The pipeline node information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreatePipelineNodeResponseBodyData Data { get; set; }
        public class CreatePipelineNodeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The error codes.</para>
            /// </summary>
            [NameInMap("ErrorCodeList")]
            [Validation(Required=false)]
            public List<string> ErrorCodeList { get; set; }

            /// <summary>
            /// <para>The error messages.</para>
            /// </summary>
            [NameInMap("ErrorMessageList")]
            [Validation(Required=false)]
            public List<string> ErrorMessageList { get; set; }

            /// <summary>
            /// <para>The ID of the pipeline created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33749</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public long? PipelineId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
