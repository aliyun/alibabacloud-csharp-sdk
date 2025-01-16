// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class GetTextbookAssistantTokenResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetTextbookAssistantTokenResponseBodyData Data { get; set; }
        public class GetTextbookAssistantTokenResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>tc_197bf5bb81889cc79eb51ae9b8c0cea3</para>
            /// </summary>
            [NameInMap("authToken")]
            [Validation(Required=false)]
            public string AuthToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5400</para>
            /// </summary>
            [NameInMap("expire")]
            [Validation(Required=false)]
            public int? Expire { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A5E9849-A2F0-551D-A7D8-1A8118557BAB</para>
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

    }

}
