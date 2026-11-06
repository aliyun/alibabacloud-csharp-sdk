// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class SubscribeProductRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the API product to subscribe to. This is the primary ID of the Product resource. You can obtain this ID from the productId field of a list item returned by ListProducts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>product-xxxxxxxx</para>
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

    }

}
