// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateCategoryProductsRequest : TeaModel {
        /// <summary>
        /// <para>The direction of this bulk operation: adds the API products specified in productIds to the category, or removes these API products from the category. The set of valid values is not declared in the API definition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>action-xxxxxxxx</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The list of API product IDs to process. Each element is a primary ID of the API product resource.</para>
        /// </summary>
        [NameInMap("productIds")]
        [Validation(Required=false)]
        public List<string> ProductIds { get; set; }

    }

}
