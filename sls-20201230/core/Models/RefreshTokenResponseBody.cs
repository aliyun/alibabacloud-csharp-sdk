// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class RefreshTokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>eyJ***************.eyJ******************.KUT****************</para>
        /// </summary>
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

    }

}
