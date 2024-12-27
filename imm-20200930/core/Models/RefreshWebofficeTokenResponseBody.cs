// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class RefreshWebofficeTokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>4996466c690a4902846ce00f96********</para>
        /// </summary>
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-08-31T13:07:28.950065359Z</para>
        /// </summary>
        [NameInMap("AccessTokenExpiredTime")]
        [Validation(Required=false)]
        public string AccessTokenExpiredTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>72a52ab3702a4123ab5594671a********</para>
        /// </summary>
        [NameInMap("RefreshToken")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-09-01T12:37:28.950065359Z</para>
        /// </summary>
        [NameInMap("RefreshTokenExpiredTime")]
        [Validation(Required=false)]
        public string RefreshTokenExpiredTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>501339F9-4B70-0CE2-AB8C-866C********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
