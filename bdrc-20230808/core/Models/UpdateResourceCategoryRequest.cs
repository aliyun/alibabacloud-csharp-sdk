// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class UpdateResourceCategoryRequest : TeaModel {
        /// <summary>
        /// <para>Resource category ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-123****7890</para>
        /// </summary>
        [NameInMap("ResourceCategoryId")]
        [Validation(Required=false)]
        public string ResourceCategoryId { get; set; }

        /// <summary>
        /// <para>Resource category name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My***ResourceCategory</para>
        /// </summary>
        [NameInMap("ResourceCategoryName")]
        [Validation(Required=false)]
        public string ResourceCategoryName { get; set; }

        /// <summary>
        /// <para>Resource matcher.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///    &quot;type&quot;: &quot;BOOL&quot;,
        ///    &quot;operator&quot;: &quot;AND&quot;,
        ///    &quot;values&quot;: [
        ///      {
        ///        &quot;type&quot;: &quot;TAG&quot;,
        ///        &quot;operator&quot;: &quot;EQUAL&quot;,
        ///        &quot;key&quot;: &quot;key0&quot;,
        ///        &quot;values&quot;: [
        ///          &quot;value0&quot;
        ///        ]
        ///      },
        ///      {
        ///        &quot;type&quot;: &quot;TAG&quot;,
        ///        &quot;operator&quot;: &quot;KEY_EXIST&quot;,
        ///        &quot;key&quot;: &quot;key1&quot;
        ///      },
        ///      {
        ///        &quot;type&quot;: &quot;TAG&quot;,
        ///        &quot;operator&quot;: &quot;KEY_EXIST_NOT_EQUAL&quot;,
        ///        &quot;key&quot;: &quot;key2&quot;,
        ///        &quot;values&quot;: [
        ///          &quot;value2-wrong&quot;
        ///        ]
        ///      }
        ///    ]
        ///  }</para>
        /// </summary>
        [NameInMap("ResourceMatcher")]
        [Validation(Required=false)]
        public string ResourceMatcher { get; set; }

    }

}
