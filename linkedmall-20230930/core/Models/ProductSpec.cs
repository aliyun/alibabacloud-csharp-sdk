// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class ProductSpec : TeaModel {
        /// <summary>
        /// <para>The specification key name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Color category</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The specification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("keyId")]
        [Validation(Required=false)]
        public long? KeyId { get; set; }

        /// <summary>
        /// <para>The specification key values.</para>
        /// </summary>
        [NameInMap("values")]
        [Validation(Required=false)]
        public List<ProductSpecValue> Values { get; set; }

    }

}
