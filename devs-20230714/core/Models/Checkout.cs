// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class Checkout : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>+001691d0768ca49e9550beeb59fbc163f33b7e88:refs/remotes/origin/master</para>
        /// </summary>
        [NameInMap("ref")]
        [Validation(Required=false)]
        public string Ref { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>https:/your_token/@github.com/buptwzj/test-initRepo4.git</para>
        /// </summary>
        [NameInMap("remote")]
        [Validation(Required=false)]
        public string Remote { get; set; }

    }

}
