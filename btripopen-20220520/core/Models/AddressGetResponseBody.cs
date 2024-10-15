// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class AddressGetResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public AddressGetResponseBodyModule Module { get; set; }
        public class AddressGetResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://trip-hisv.taobao.com/ding/trustLogin.htm?redirectUrl=https%3A%2F%2Fmarket.m.taobao.com%2Fapp%2Fbtrip-fe%2Frx-alitrip-main%2Fhome.html%3Ffpt%3DbIdentify%2528dingtalk.isv.h5.home%2529%26corpId%3Dding3f9797e277423f14a1320dcb25e91351%26dingUserId%3Dmanager9302%26dingAppId%3D1692%26fit%3Dtrue&token=b73e0b9e-d25a-40f0-aff8-2c2e58da659b">https://trip-hisv.taobao.com/ding/trustLogin.htm?redirectUrl=https%3A%2F%2Fmarket.m.taobao.com%2Fapp%2Fbtrip-fe%2Frx-alitrip-main%2Fhome.html%3Ffpt%3DbIdentify%2528dingtalk.isv.h5.home%2529%26corpId%3Dding3f9797e277423f14a1320dcb25e91351%26dingUserId%3Dmanager9302%26dingAppId%3D1692%26fit%3Dtrue&amp;token=b73e0b9e-d25a-40f0-aff8-2c2e58da659b</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>210bcc3a16583004579056128d33d7</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
