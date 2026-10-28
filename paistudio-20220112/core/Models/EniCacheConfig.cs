// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class EniCacheConfig : TeaModel {
        /// <summary>
        /// <para>The size of the cache pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CachePoolSize")]
        [Validation(Required=false)]
        public int? CachePoolSize { get; set; }

        /// <summary>
        /// <para>Specifies whether it is enabled.</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

    }

}
