// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class ProductSpec : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>颜色分类</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("keyId")]
        [Validation(Required=false)]
        public long? KeyId { get; set; }

        [NameInMap("values")]
        [Validation(Required=false)]
        public List<ProductSpecValue> Values { get; set; }

    }

}
