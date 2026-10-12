// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateProductCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The description of the product category. Maximum length: 500 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Product category for AI-related capabilities</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The icon of the product category, which consists of the icon type and icon information fields.</para>
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public HiMarketIcon Icon { get; set; }

        /// <summary>
        /// <para>The name of the product category. Maximum length: 100 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ai-capabilities</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
