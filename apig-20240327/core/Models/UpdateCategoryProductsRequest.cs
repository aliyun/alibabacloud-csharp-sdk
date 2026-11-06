// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateCategoryProductsRequest : TeaModel {
        /// <summary>
        /// <para>The operation type for the bulk operation. This parameter specifies whether to add the API products specified by productIds to the category or remove them from the category. The valid values are not declared in the API definition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>action-xxxxxxxx</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The list of API product IDs to be processed. Each element is the primary ID of an API product resource.</para>
        /// </summary>
        [NameInMap("productIds")]
        [Validation(Required=false)]
        public List<string> ProductIds { get; set; }

    }

}
