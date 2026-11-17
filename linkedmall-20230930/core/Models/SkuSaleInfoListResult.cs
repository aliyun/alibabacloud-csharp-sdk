// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class SkuSaleInfoListResult : TeaModel {
        /// <summary>
        /// <para>The API request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3239281273464326823</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The SKU inventory collection.</para>
        /// </summary>
        [NameInMap("skuSaleInfos")]
        [Validation(Required=false)]
        public List<SkuSaleInfo> SkuSaleInfos { get; set; }

    }

}
