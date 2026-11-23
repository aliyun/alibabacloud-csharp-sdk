// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210218.Models
{
    public class GetLatestThirdAppAccessTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The current valid static access token for the specified user and single cloud desktop. The original saved token is returned, and the query does not renew the token. This is a sensitive credential. Do not log or expose the full value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>taatv1.v2****</para>
        /// </summary>
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para>The absolute expiration time of the token, represented as a Unix timestamp in milliseconds. This parameter is not empty when the call is successful. GetLatestThirdAppAccessToken returns the original expiration time and does not renew the token.</para>
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
