// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetLoginDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Logon information data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetLoginDetailsResponseBodyData Data { get; set; }
        public class GetLoginDetailsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Agent data push server URL. After a successful connection, the server pushes agent status data to the agent Workbench.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sh-wss-ccc.aliyuncs.com</para>
            /// </summary>
            [NameInMap("AgentServerUrl")]
            [Validation(Required=false)]
            public string AgentServerUrl { get; set; }

            /// <summary>
            /// <para>Agent profile picture URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://abc.com/sam.jpb">http://abc.com/sam.jpb</a></para>
            /// </summary>
            [NameInMap("AvatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            /// <summary>
            /// <para>Chat session application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7pjxxx</para>
            /// </summary>
            [NameInMap("ChatAppId")]
            [Validation(Required=false)]
            public string ChatAppId { get; set; }

            /// <summary>
            /// <para>Chat session application key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>955e4bd7xxxxxxxxxxxxxd7898ba9fa0d0</para>
            /// </summary>
            [NameInMap("ChatAppKey")]
            [Validation(Required=false)]
            public string ChatAppKey { get; set; }

            /// <summary>
            /// <para>Chat Device ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4c51c9116c36537cb850dc1081d745df</para>
            /// </summary>
            [NameInMap("ChatDeviceId")]
            [Validation(Required=false)]
            public string ChatDeviceId { get; set; }

            /// <summary>
            /// <para>Chat session logon token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;accessToken&quot;:&quot;oauth_cloud_key:4xxx0=&quot;,&quot;accessTokenExpiredTime&quot;:864xxxx,&quot;refreshToken&quot;:&quot;oauth_cloud_key:Paxxxx==&quot;}</para>
            /// </summary>
            [NameInMap("ChatLoginToken")]
            [Validation(Required=false)]
            public string ChatLoginToken { get; set; }

            /// <summary>
            /// <para>Chat session server URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wss://wss.im.dingtalk.cn</para>
            /// </summary>
            [NameInMap("ChatServerUrl")]
            [Validation(Required=false)]
            public string ChatServerUrl { get; set; }

            /// <summary>
            /// <para>Chat session Device ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A-8000100x</para>
            /// </summary>
            [NameInMap("ChatUserId")]
            [Validation(Required=false)]
            public string ChatUserId { get; set; }

            /// <summary>
            /// <para>SIP device extension number. This field is required when using a SIP phone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8033****</para>
            /// </summary>
            [NameInMap("DeviceExt")]
            [Validation(Required=false)]
            public string DeviceExt { get; set; }

            /// <summary>
            /// <para>If the agent has registered an SIP phone, this parameter is the Device ID of the SIP phone device; otherwise, it is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Yealink SIP-T23G 44.84.XX.XX</para>
            /// </summary>
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <para>SIP device status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OFFLINE</para>
            /// </summary>
            [NameInMap("DeviceState")]
            [Validation(Required=false)]
            public string DeviceState { get; set; }

            /// <summary>
            /// <para>Agent display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>坐席小王</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>Agent extension number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8001****</para>
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            /// <summary>
            /// <para>Agent nickname</para>
            /// 
            /// <b>Example:</b>
            /// <para>老王</para>
            /// </summary>
            [NameInMap("Nickname")]
            [Validation(Required=false)]
            public string Nickname { get; set; }

            /// <summary>
            /// <para>Signature information generated using an asymmetric key encryption algorithm. This information is required for authentication when registering with the SIP server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zi31STIMtIfa/UN2l+6lww****</para>
            /// </summary>
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

            /// <summary>
            /// <para>Signature information generated using an asymmetric key encryption algorithm. This information is required for authentication when registering with the SIP server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zi31STIMtIfa/UN2l+6lww****</para>
            /// </summary>
            [NameInMap("Signature2")]
            [Validation(Required=false)]
            public string Signature2 { get; set; }

            /// <summary>
            /// <para>SIP registration server URL. The agent must register with the server as an SIP user to perform transactional processing (TP) operations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sh-sip-ccc.aliyuncs.com:443</para>
            /// </summary>
            [NameInMap("SipServerUrl")]
            [Validation(Required=false)]
            public string SipServerUrl { get; set; }

            /// <summary>
            /// <para>Agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent@ccc-test</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>Signature data used to generate signature information. Because this signature mechanism does not support Chinese characters, UserKey2 is currently used for signing instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>坐席@aliyun:802001:1656406628862</para>
            /// </summary>
            [NameInMap("UserKey")]
            [Validation(Required=false)]
            public string UserKey { get; set; }

            /// <summary>
            /// <para>Signature data used to generate signature information. UserKey2 was added because UserKey does not support Chinese characters in signatures.</para>
            /// 
            /// <b>Example:</b>
            /// <para>802001:1656406628862&quot;</para>
            /// </summary>
            [NameInMap("UserKey2")]
            [Validation(Required=false)]
            public string UserKey2 { get; set; }

            /// <summary>
            /// <para>Work mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ON_SITE</para>
            /// </summary>
            [NameInMap("WorkMode")]
            [Validation(Required=false)]
            public string WorkMode { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Response parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F1A4774A-F28B-5C40-AEF6-D88D2DD6C7E4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
