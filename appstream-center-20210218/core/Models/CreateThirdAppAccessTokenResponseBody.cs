// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210218.Models
{
    public class CreateThirdAppAccessTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The time-limited static access token created for the specified user and single cloud desktop. This is a sensitive credential. Do not log or expose the full value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>taatv1.v2****</para>
        /// </summary>
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para>The absolute expiration time of the token, in UNIX milliseconds. This parameter is not empty when the call is successful. GetLatestThirdAppAccessToken returns the original expiration time without extending it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1795450500000</para>
        /// </summary>
        [NameInMap("ExpiresAt")]
        [Validation(Required=false)]
        public long? ExpiresAt { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which can be used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6DAB2D15-7345-4C33-9D77-48A1A756B9E1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
