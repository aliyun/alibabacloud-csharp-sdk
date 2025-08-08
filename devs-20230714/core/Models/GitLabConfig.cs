// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class GitLabConfig : TeaModel {
        [NameInMap("isFixedIP")]
        [Validation(Required=false)]
        public bool? IsFixedIP { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>your-token</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://gitlab.c16194660f14898a0810408171302ac.cn-shanghai.alicontainer.com/">http://gitlab.c16194660f14898a0810408171302ac.cn-shanghai.alicontainer.com/</a></para>
        /// </summary>
        [NameInMap("uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}
