// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetAligenieUserInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Response message</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>73C67BD9-175A-1324-8202-9FAABBB3E6FA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetAligenieUserInfoResponseBodyResult Result { get; set; }
        public class GetAligenieUserInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Aligenie user nickname</para>
            /// 
            /// <b>Example:</b>
            /// <para>XXX</para>
            /// </summary>
            [NameInMap("AligenieNickname")]
            [Validation(Required=false)]
            public string AligenieNickname { get; set; }

            /// <summary>
            /// <para>URL of the Aligenie user profile picture</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://img.alicdn.com/xxx.jpg">http://img.alicdn.com/xxx.jpg</a></para>
            /// </summary>
            [NameInMap("Avatar")]
            [Validation(Required=false)]
            public string Avatar { get; set; }

            /// <summary>
            /// <para>Indicates whether the account can be logged off</para>
            /// </summary>
            [NameInMap("Deletable")]
            [Validation(Required=false)]
            public bool? Deletable { get; set; }

        }

        /// <summary>
        /// <para>Flag indicating whether the invocation succeeded</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
