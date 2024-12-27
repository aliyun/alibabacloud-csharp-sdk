// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GenerateWebofficeTokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2d73dd5d87524c5e8a194c3eb5********</para>
        /// </summary>
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-08-30T13:13:11.347146982Z</para>
        /// </summary>
        [NameInMap("AccessTokenExpiredTime")]
        [Validation(Required=false)]
        public string AccessTokenExpiredTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>e374995ec532432bb678074d36********</para>
        /// </summary>
        [NameInMap("RefreshToken")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-08-31T12:43:11.347146982Z</para>
        /// </summary>
        [NameInMap("RefreshTokenExpiredTime")]
        [Validation(Required=false)]
        public string RefreshTokenExpiredTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1759315A-CB33-0A75-A72B-62D7********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://office-hl.imm.aliyuncs.com/office/s/dd221b2cdb44fb66e9070d1d70a8b9bbb6d6fff7?_w_tokentype=1">https://office-hl.imm.aliyuncs.com/office/s/dd221b2cdb44fb66e9070d1d70a8b9bbb6d6fff7?_w_tokentype=1</a></para>
        /// </summary>
        [NameInMap("WebofficeURL")]
        [Validation(Required=false)]
        public string WebofficeURL { get; set; }

    }

}
