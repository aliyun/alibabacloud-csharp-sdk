// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class ProductSaleInfoListResult : TeaModel {
        /// <summary>
        /// <para>Product sales information</para>
        /// </summary>
        [NameInMap("productSaleInfos")]
        [Validation(Required=false)]
        public List<ProductSaleInfo> ProductSaleInfos { get; set; }

        /// <summary>
        /// <para>The request ID of the API call</para>
        /// 
        /// <b>Example:</b>
        /// <para>3239281273464326823</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
