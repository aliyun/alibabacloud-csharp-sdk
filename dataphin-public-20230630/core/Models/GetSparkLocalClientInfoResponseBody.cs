// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetSparkLocalClientInfoResponseBody : TeaModel {
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
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetSparkLocalClientInfoResponseBodyData> Data { get; set; }
        public class GetSparkLocalClientInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The client file ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XXXX-XXXX-XXXX-XXXX</para>
            /// </summary>
            [NameInMap("ClientFileResourceId")]
            [Validation(Required=false)]
            public string ClientFileResourceId { get; set; }

            /// <summary>
            /// <para>The client file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>spark-cleint.zip</para>
            /// </summary>
            [NameInMap("ClientFileResourceName")]
            [Validation(Required=false)]
            public string ClientFileResourceName { get; set; }

            /// <summary>
            /// <para>The client name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>spark-clinet</para>
            /// </summary>
            [NameInMap("ClientName")]
            [Validation(Required=false)]
            public string ClientName { get; set; }

            /// <summary>
            /// <para>Indicates whether the client information is editable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true/false</para>
            /// </summary>
            [NameInMap("Editable")]
            [Validation(Required=false)]
            public bool? Editable { get; set; }

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
