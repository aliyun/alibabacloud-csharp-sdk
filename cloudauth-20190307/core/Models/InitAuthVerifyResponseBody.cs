// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class InitAuthVerifyResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B506328A-D84B-4750-82C7-6A207C585CF1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public InitAuthVerifyResponseBodyResult Result { get; set; }
        public class InitAuthVerifyResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The verification request ID, which is the unique identifier of the verification service authentication request.
            /// You must pass in the verification request ID when querying the authentication result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>shif9d1a185b8dde7cd07bf0943a448b</para>
            /// </summary>
            [NameInMap("CertifyId")]
            [Validation(Required=false)]
            public string CertifyId { get; set; }

        }

    }

}
