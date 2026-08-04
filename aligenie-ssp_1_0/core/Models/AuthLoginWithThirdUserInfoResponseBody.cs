// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class AuthLoginWithThirdUserInfoResponseBody : TeaModel {
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
        /// <para>When Code is 5140001, it indicates that logon failed because the third-party user is not attached to a Tmall Genie user. The frontend must initiate the phone number authorization logon flow based on this error code. In subsequent steps, the frontend must return the SessionId in DataObj to the server.</para>
        /// </summary>
        [NameInMap("DataObj")]
        [Validation(Required=false)]
        public AuthLoginWithThirdUserInfoResponseBodyDataObj DataObj { get; set; }
        public class AuthLoginWithThirdUserInfoResponseBodyDataObj : TeaModel {
            /// <summary>
            /// <para>Session ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>dbe2eb4458302b9246c6da17fbc95f4b</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

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

        /// <summary>
        /// <para>Response Result</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public AuthLoginWithThirdUserInfoResponseBodyResult Result { get; set; }
        public class AuthLoginWithThirdUserInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Expiration time of the logon state access token</para>
            /// 
            /// <b>Example:</b>
            /// <para>1659428051452</para>
            /// </summary>
            [NameInMap("ExpiredTimeLong")]
            [Validation(Required=false)]
            public long? ExpiredTimeLong { get; set; }

            /// <summary>
            /// <para>Logon state access token</para>
            /// 
            /// <b>Example:</b>
            /// <para>bd9ccdb121ee950ddead51e943e081fe</para>
            /// </summary>
            [NameInMap("LoginStateAccessToken")]
            [Validation(Required=false)]
            public string LoginStateAccessToken { get; set; }

        }

        /// <summary>
        /// <para>Flag indicating whether the invocation succeeded</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
