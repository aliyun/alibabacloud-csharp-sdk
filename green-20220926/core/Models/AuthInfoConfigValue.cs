// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class AuthInfoConfigValue : TeaModel {
        /// <summary>
        /// <para>The credential.</para>
        /// 
        /// <b>Example:</b>
        /// <para>token-xxx</para>
        /// </summary>
        [NameInMap("AuthToken")]
        [Validation(Required=false)]
        public string AuthToken { get; set; }

        /// <summary>
        /// <para>The private domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx">https://xxx</a></para>
        /// </summary>
        [NameInMap("PrivateDomain")]
        [Validation(Required=false)]
        public string PrivateDomain { get; set; }

        /// <summary>
        /// <para>The project space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>proj-xxx</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// <para>The public domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx">https://xxx</a></para>
        /// </summary>
        [NameInMap("PublicDomain")]
        [Validation(Required=false)]
        public string PublicDomain { get; set; }

    }

}
