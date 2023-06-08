// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnOrderCommodityCodeResponseBody : TeaModel {
        /// <summary>
        /// The commodity code that includes the organization unit.
        /// </summary>
        [NameInMap("OrderCommodityCode")]
        [Validation(Required=false)]
        public string OrderCommodityCode { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
