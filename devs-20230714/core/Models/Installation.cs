// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class Installation : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://github.com/login/oauth/authorize?client_id=86059a1b2bb20d3e5fc3&scope=repo,repo:status,delete_repo">https://github.com/login/oauth/authorize?client_id=86059a1b2bb20d3e5fc3&amp;scope=repo,repo:status,delete_repo</a></para>
        /// </summary>
        [NameInMap("actionUri")]
        [Validation(Required=false)]
        public string ActionUri { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Please click &quot;actionUri&quot; to complete the OAuth authorization process</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>finished</para>
        /// </summary>
        [NameInMap("stage")]
        [Validation(Required=false)]
        public string Stage { get; set; }

    }

}
