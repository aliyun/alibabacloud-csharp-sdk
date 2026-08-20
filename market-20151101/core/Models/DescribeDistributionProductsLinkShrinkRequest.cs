// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeDistributionProductsLinkShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The collection of product codes. The collection cannot be empty and can contain up to 50 entries.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Codes")]
        [Validation(Required=false)]
        public string CodesShrink { get; set; }

    }

}
