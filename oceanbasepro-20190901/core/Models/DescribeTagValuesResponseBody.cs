// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTagValuesResponseBody : TeaModel {
        /// <summary>
        /// <para>The mappings between tag groups and tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{\&quot;Tag group 2\&quot;:[\&quot;Tag 2-1\&quot;,\&quot;Tag 2-2\&quot;],\&quot;Tag group 1\&quot;:[\&quot;Tag 1-1\&quot;]}&quot;</para>
        /// </summary>
        [NameInMap("Map")]
        [Validation(Required=false)]
        public string Map { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C91F7BA-xxxx-xxxx-xxxx-846ECA1A9908</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
