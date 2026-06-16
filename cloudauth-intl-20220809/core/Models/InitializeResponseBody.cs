// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class InitializeResponseBody : TeaModel {
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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EB35****87EBA1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public InitializeResponseBodyResult Result { get; set; }
        public class InitializeResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The client configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("ClientCfg")]
            [Validation(Required=false)]
            public string ClientCfg { get; set; }

            /// <summary>
            /// <para>The authentication standard encryption protocol.</para>
            /// <remarks>
            /// <para>This field is required when you use iframe embedding for H5 web page integration.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>hksb7ba1b28130d24e015d*********</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The authentication ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08573be80f944d95ac812e019e3655a8</para>
            /// </summary>
            [NameInMap("TransactionId")]
            [Validation(Required=false)]
            public string TransactionId { get; set; }

            /// <summary>
            /// <para>The web authentication URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http****</para>
            /// </summary>
            [NameInMap("TransactionUrl")]
            [Validation(Required=false)]
            public string TransactionUrl { get; set; }

        }

    }

}
