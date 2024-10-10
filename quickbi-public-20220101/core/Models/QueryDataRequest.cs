// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDataRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f4cc43bc3***</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public string Conditions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;area&quot;, &quot;city&quot;, &quot;price&quot;, &quot;date&quot;]</para>
        /// </summary>
        [NameInMap("ReturnFields")]
        [Validation(Required=false)]
        public string ReturnFields { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>b5d8fd9348cc4327****afb604</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
