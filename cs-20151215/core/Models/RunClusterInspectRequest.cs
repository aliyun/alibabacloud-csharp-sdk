// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class RunClusterInspectRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency token that ensures an API request completes no more than one time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c82e6987e2961451182edacd74faf</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
