// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketProductCategory : TeaModel {
        /// <summary>
        /// <para>The categorization ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cat-xxx</para>
        /// </summary>
        [NameInMap("categoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>The categorization description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AI网关相关产品分类</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The icon configuration.</para>
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public HiMarketIcon Icon { get; set; }

        /// <summary>
        /// <para>The categorization name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AI网关</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
