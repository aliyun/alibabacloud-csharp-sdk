// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

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
        public AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberResponseBodyResult Result { get; set; }
        public class AuthLoginWithAligenieUserInfoGeneratedByPhoneNumberResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1659506854230</para>
            /// </summary>
            [NameInMap("ExpiredTimeLong")]
            [Validation(Required=false)]
            public long? ExpiredTimeLong { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>d15aa92de679d0d225aa845268be19ee</para>
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
