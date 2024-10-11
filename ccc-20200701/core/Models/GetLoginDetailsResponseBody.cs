// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetLoginDetailsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetLoginDetailsResponseBodyData Data { get; set; }
        public class GetLoginDetailsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>sh-wss-ccc.aliyuncs.com</para>
            /// </summary>
            [NameInMap("AgentServerUrl")]
            [Validation(Required=false)]
            public string AgentServerUrl { get; set; }

            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            [NameInMap("ChatAppId")]
            [Validation(Required=false)]
            public string ChatAppId { get; set; }

            [NameInMap("ChatAppKey")]
            [Validation(Required=false)]
            public string ChatAppKey { get; set; }

            [NameInMap("ChatDeviceId")]
            [Validation(Required=false)]
            public string ChatDeviceId { get; set; }

            [NameInMap("ChatLoginToken")]
            [Validation(Required=false)]
            public string ChatLoginToken { get; set; }

            [NameInMap("ChatServerUrl")]
            [Validation(Required=false)]
            public string ChatServerUrl { get; set; }

            [NameInMap("ChatUserId")]
            [Validation(Required=false)]
            public string ChatUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8033****</para>
            /// </summary>
            [NameInMap("DeviceExt")]
            [Validation(Required=false)]
            public string DeviceExt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Yealink SIP-T23G 44.84.XX.XX</para>
            /// </summary>
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OFFLINE</para>
            /// </summary>
            [NameInMap("DeviceState")]
            [Validation(Required=false)]
            public string DeviceState { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8001****</para>
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            [NameInMap("Nickname")]
            [Validation(Required=false)]
            public string Nickname { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zi31STIMtIfa/UN2l+6lww****</para>
            /// </summary>
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zi31STIMtIfa/UN2l+6lww****</para>
            /// </summary>
            [NameInMap("Signature2")]
            [Validation(Required=false)]
            public string Signature2 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sh-sip-ccc.aliyuncs.com:443</para>
            /// </summary>
            [NameInMap("SipServerUrl")]
            [Validation(Required=false)]
            public string SipServerUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>agent@ccc-test</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserKey")]
            [Validation(Required=false)]
            public string UserKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>802001:1656406628862&quot;</para>
            /// </summary>
            [NameInMap("UserKey2")]
            [Validation(Required=false)]
            public string UserKey2 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ON_SITE</para>
            /// </summary>
            [NameInMap("WorkMode")]
            [Validation(Required=false)]
            public string WorkMode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F1A4774A-F28B-5C40-AEF6-D88D2DD6C7E4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
