// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class AuthLoginWithThirdUserInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("DataObj")]
        [Validation(Required=false)]
        public AuthLoginWithThirdUserInfoResponseBodyDataObj DataObj { get; set; }
        public class AuthLoginWithThirdUserInfoResponseBodyDataObj : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>dbe2eb4458302b9246c6da17fbc95f4b</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>73C67BD9-175A-1324-8202-9FAABBB3E6FA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public AuthLoginWithThirdUserInfoResponseBodyResult Result { get; set; }
        public class AuthLoginWithThirdUserInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1659428051452</para>
            /// </summary>
            [NameInMap("ExpiredTimeLong")]
            [Validation(Required=false)]
            public long? ExpiredTimeLong { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bd9ccdb121ee950ddead51e943e081fe</para>
            /// </summary>
            [NameInMap("LoginStateAccessToken")]
            [Validation(Required=false)]
            public string LoginStateAccessToken { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
