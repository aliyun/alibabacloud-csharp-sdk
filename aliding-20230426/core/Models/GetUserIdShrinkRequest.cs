// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetUserIdShrinkRequest : TeaModel {
        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

        /// <summary>
        /// <para>unionId</para>
        /// 
        /// <b>Example:</b>
        /// <para>****iE</para>
        /// </summary>
        [NameInMap("UnionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
