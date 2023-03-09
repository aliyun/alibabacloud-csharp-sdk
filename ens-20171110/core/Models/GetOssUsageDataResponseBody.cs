// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class GetOssUsageDataResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UsageList")]
        [Validation(Required=false)]
        public List<GetOssUsageDataResponseBodyUsageList> UsageList { get; set; }
        public class GetOssUsageDataResponseBodyUsageList : TeaModel {
            [NameInMap("LanRxBw")]
            [Validation(Required=false)]
            public long? LanRxBw { get; set; }

            [NameInMap("LanTxBw")]
            [Validation(Required=false)]
            public long? LanTxBw { get; set; }

            [NameInMap("Point")]
            [Validation(Required=false)]
            public long? Point { get; set; }

            [NameInMap("PointTs")]
            [Validation(Required=false)]
            public string PointTs { get; set; }

            [NameInMap("StorageUsageByte")]
            [Validation(Required=false)]
            public long? StorageUsageByte { get; set; }

            [NameInMap("WanRxBw")]
            [Validation(Required=false)]
            public long? WanRxBw { get; set; }

            [NameInMap("WanTxBw")]
            [Validation(Required=false)]
            public long? WanTxBw { get; set; }

        }

    }

}
