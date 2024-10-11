// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetVisitorLoginDetailsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetVisitorLoginDetailsResponseBodyData Data { get; set; }
        public class GetVisitorLoginDetailsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>7pjxxx</para>
            /// </summary>
            [NameInMap("ChatAppId")]
            [Validation(Required=false)]
            public string ChatAppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>955e4bd7xxxxxxxxxxxxxd7898ba9fa0d0</para>
            /// </summary>
            [NameInMap("ChatAppKey")]
            [Validation(Required=false)]
            public string ChatAppKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4c51c9116c36537cb850dc1081d745df</para>
            /// </summary>
            [NameInMap("ChatDeviceId")]
            [Validation(Required=false)]
            public string ChatDeviceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;accessToken&quot;:&quot;oauth_cloud_key:+4oJXUAFSWxGD2YuRW4V/oUN0/8qJGNc0I<em><b><b><b><b>n1E3DOr3Q3lX00ZnTpyqRi8Y6hYoLYA7n2ZkWuv485hVtXeSgnIQkKxXPbMgwoLxWaK//lI5Dn/mb4YuDifigv+ZyFzc+07vxm9ZFu/NjA==&quot;,&quot;accessTokenExpiredTime&quot;:86400000,&quot;refreshToken&quot;:&quot;oauth_cloud_key:/U+8UueDmpeUszhXC+SWow4pNLZp2C</b></b></b></b></em>**U/377BNXF+Mjo1lFgDk6GtEjNNoJpapX2mHH8GcRke2+yKQs/w4gAN9xSMn543Ciung+93pXV6IpQGbEVlu&quot;}</para>
            /// </summary>
            [NameInMap("ChatLoginToken")]
            [Validation(Required=false)]
            public string ChatLoginToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>wss://wss.im.dingtalk.cn</para>
            /// </summary>
            [NameInMap("ChatServerUrl")]
            [Validation(Required=false)]
            public string ChatServerUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dac9c001****a15684ea91a81317</para>
            /// </summary>
            [NameInMap("ChatUserId")]
            [Validation(Required=false)]
            public string ChatUserId { get; set; }

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
        /// <para>19D09CCC-F298-4124-849A-AFA217819011</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
