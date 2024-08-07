// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDeliverListRequest : TeaModel {
        /// <summary>
        /// The ID of the tracking task that you want to query. If you do not specify an ID, all tracking tasks are queried.
        /// </summary>
        [NameInMap("DeliverId")]
        [Validation(Required=false)]
        public long? DeliverId { get; set; }

    }

}
