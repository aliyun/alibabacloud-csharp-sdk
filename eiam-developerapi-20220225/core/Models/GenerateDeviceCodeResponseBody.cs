// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GenerateDeviceCodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The device code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("device_code")]
        [Validation(Required=false)]
        public string DeviceCode { get; set; }

        /// <summary>
        /// <para>The time when the token expires. This value is a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1653288641</para>
        /// </summary>
        [NameInMap("expires_at")]
        [Validation(Required=false)]
        public long? ExpiresAt { get; set; }

        /// <summary>
        /// <para>The remaining validity period of the device code. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1200</para>
        /// </summary>
        [NameInMap("expires_in")]
        [Validation(Required=false)]
        public long? ExpiresIn { get; set; }

        /// <summary>
        /// <para>The timeout period of the request token. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        /// <summary>
        /// <para>The user authorization code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("user_code")]
        [Validation(Required=false)]
        public string UserCode { get; set; }

        /// <summary>
        /// <para>The verification URI.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/authorize/device">https://example.com/authorize/device</a></para>
        /// </summary>
        [NameInMap("verification_uri")]
        [Validation(Required=false)]
        public string VerificationUri { get; set; }

        /// <summary>
        /// <para>The complete verification URI.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/authorize/device?user_code=">https://example.com/authorize/device?user_code=</a>
        /// xxxx</para>
        /// </summary>
        [NameInMap("verification_uri_complete")]
        [Validation(Required=false)]
        public string VerificationUriComplete { get; set; }

    }

}
