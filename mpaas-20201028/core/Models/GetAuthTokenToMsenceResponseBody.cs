// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class GetAuthTokenToMsenceResponseBody : TeaModel {
        [NameInMap("MpaasSystemOauthTokenResponse")]
        [Validation(Required=false)]
        public GetAuthTokenToMsenceResponseBodyMpaasSystemOauthTokenResponse MpaasSystemOauthTokenResponse { get; set; }
        public class GetAuthTokenToMsenceResponseBodyMpaasSystemOauthTokenResponse : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>NPHTGKNR</para>
            /// </summary>
            [NameInMap("AuthToken")]
            [Validation(Required=false)]
            public string AuthToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("ExpiresIn")]
            [Validation(Required=false)]
            public string ExpiresIn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("OpenId")]
            [Validation(Required=false)]
            public string OpenId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>userid001</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>11E66B29-9E5E-5C10-B64E-B5A0E0F26355</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("ResultMsg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
