// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class RefreshTokenRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("accessTokenExpirationTime")]
        [Validation(Required=false)]
        public long? AccessTokenExpirationTime { get; set; }

        /// <summary>
        /// <para>The ticket that is used for logon-free access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJ***************.eyJ******************.KUT****************</para>
        /// </summary>
        [NameInMap("ticket")]
        [Validation(Required=false)]
        public string Ticket { get; set; }

    }

}
