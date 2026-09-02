// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class InitAiAppScanResponseBody : TeaModel {
        /// <summary>
        /// <para>The access entry information.</para>
        /// </summary>
        [NameInMap("AuthInfo")]
        [Validation(Required=false)]
        public InitAiAppScanResponseBodyAuthInfo AuthInfo { get; set; }
        public class InitAiAppScanResponseBodyAuthInfo : TeaModel {
            /// <summary>
            /// <para>The credential.</para>
            /// 
            /// <b>Example:</b>
            /// <para>token-xxx</para>
            /// </summary>
            [NameInMap("AuthToken")]
            [Validation(Required=false)]
            public string AuthToken { get; set; }

            /// <summary>
            /// <para>The private domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx">https://xxx</a></para>
            /// </summary>
            [NameInMap("PrivateDomain")]
            [Validation(Required=false)]
            public string PrivateDomain { get; set; }

            /// <summary>
            /// <para>The project space.</para>
            /// 
            /// <b>Example:</b>
            /// <para>proj-xxx</para>
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <para>The public domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx">https://xxx</a></para>
            /// </summary>
            [NameInMap("PublicDomain")]
            [Validation(Required=false)]
            public string PublicDomain { get; set; }

        }

        /// <summary>
        /// <para>The access information.</para>
        /// </summary>
        [NameInMap("AuthInfoConfig")]
        [Validation(Required=false)]
        public Dictionary<string, AuthInfoConfigValue> AuthInfoConfig { get; set; }

        /// <summary>
        /// <para>The authorization status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("AuthStatus")]
        [Validation(Required=false)]
        public string AuthStatus { get; set; }

        /// <summary>
        /// <para>The service activation status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("OpenStatus")]
        [Validation(Required=false)]
        public string OpenStatus { get; set; }

        /// <summary>
        /// <para>The ready status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("ReadyStatus")]
        [Validation(Required=false)]
        public string ReadyStatus { get; set; }

        /// <summary>
        /// <para>The ID assigned by the backend to uniquely identify a request. You can use this ID for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
