// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeQuickSaleConfigResponseBody : TeaModel {
        /// <summary>
        /// Product code.
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public string Commodity { get; set; }

        /// <summary>
        /// Return data.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public Dictionary<string, object> Items { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
