// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class SessionNetworkHeaderValueReplacement : TeaModel {
        /// <summary>
        /// <para>The fake value. A placeholder used by code in the sandbox. The gateway performs an exact substring match on this string within the header value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sbx-notion-key-0001</para>
        /// </summary>
        [NameInMap("placeholder")]
        [Validation(Required=false)]
        public string Placeholder { get; set; }

        /// <summary>
        /// <para>The real value. The actual value after the placeholder is replaced.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ntn_real_secret_xxx</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
