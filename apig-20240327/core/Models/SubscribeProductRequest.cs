// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class SubscribeProductRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the API product to subscribe to. This is the primary ID of the API product resource. You can obtain this ID from the productId field in the response of the ListProducts operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>product-xxxxxxxx</para>
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

    }

}
