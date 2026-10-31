// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class SubmitBatchTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned for the request. A value of OK indicates that the request is normal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>The error message returned for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The edit result.</para>
        /// </summary>
        [NameInMap("SubmitResult")]
        [Validation(Required=false)]
        public SubmitBatchTaskResponseBodySubmitResult SubmitResult { get; set; }
        public class SubmitBatchTaskResponseBodySubmitResult : TeaModel {
            /// <summary>
            /// <para>The ID of the task scheduling node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n_12113111</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The ID of the object to be published.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1010312911</para>
            /// </summary>
            [NameInMap("SubmitId")]
            [Validation(Required=false)]
            public long? SubmitId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
