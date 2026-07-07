// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class SkuSpec : TeaModel {
        /// <summary>
        /// <para>Specification key</para>
        /// 
        /// <b>Example:</b>
        /// <para>颜色分类</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>Specification ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("keyId")]
        [Validation(Required=false)]
        public long? KeyId { get; set; }

        /// <summary>
        /// <para>Specification value</para>
        /// 
        /// <b>Example:</b>
        /// <para>天蓝色</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <para>Specification value alias (Recommendation: If this field is not empty (null), use its value as the frontend display specification; if this field is empty (null), use the value field as the frontend display specification.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>秘色</para>
        /// </summary>
        [NameInMap("valueAlias")]
        [Validation(Required=false)]
        public string ValueAlias { get; set; }

        /// <summary>
        /// <para>Specification value ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("valueId")]
        [Validation(Required=false)]
        public long? ValueId { get; set; }

    }

}
