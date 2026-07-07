// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class SelectionGroupAddProductResponseBody : TeaModel {
        /// <summary>
        /// <para>List of product IDs successfully added</para>
        /// </summary>
        [NameInMap("productIds")]
        [Validation(Required=false)]
        public List<string> ProductIds { get; set; }

    }

}
