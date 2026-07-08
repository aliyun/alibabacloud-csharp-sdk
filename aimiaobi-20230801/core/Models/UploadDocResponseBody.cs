// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class UploadDocResponseBody : TeaModel {
        /// <summary>
        /// <para>Internal error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Document information</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UploadDocResponseBodyData Data { get; set; }
        public class UploadDocResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Array of successfully uploaded document IDs</para>
            /// </summary>
            [NameInMap("DocIds")]
            [Validation(Required=false)]
            public List<string> DocIds { get; set; }

            /// <summary>
            /// <para>Document IDs that could not be uploaded because they already exist</para>
            /// </summary>
            [NameInMap("ExistedIds")]
            [Validation(Required=false)]
            public List<string> ExistedIds { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error description</para>
        /// 
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
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation succeeded</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
