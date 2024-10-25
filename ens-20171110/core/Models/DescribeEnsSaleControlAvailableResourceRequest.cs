// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsSaleControlAvailableResourceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        [NameInMap("CustomAccount")]
        [Validation(Required=false)]
        public string CustomAccount { get; set; }

        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

    }

}
