// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class ProductSpecValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>白色</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>秘色</para>
        /// </summary>
        [NameInMap("valueAlias")]
        [Validation(Required=false)]
        public string ValueAlias { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("valueId")]
        [Validation(Required=false)]
        public long? ValueId { get; set; }

    }

}
