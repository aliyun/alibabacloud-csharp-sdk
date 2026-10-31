// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ApplyResourcePermissionResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code of the request. A value of OK indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The application result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ApplyResourcePermissionResponseBodyData Data { get; set; }
        public class ApplyResourcePermissionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of application IDs.</para>
            /// </summary>
            [NameInMap("ApplyIds")]
            [Validation(Required=false)]
            public List<string> ApplyIds { get; set; }

            /// <summary>
            /// <para>The list of approval IDs.</para>
            /// </summary>
            [NameInMap("BpmsIds")]
            [Validation(Required=false)]
            public List<string> BpmsIds { get; set; }

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
        /// <para>The error message of the request.</para>
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
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
