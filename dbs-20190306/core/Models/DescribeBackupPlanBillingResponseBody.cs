// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeBackupPlanBillingResponseBody : TeaModel {
        [NameInMap("Item")]
        [Validation(Required=false)]
        public DescribeBackupPlanBillingResponseBodyItem Item { get; set; }
        public class DescribeBackupPlanBillingResponseBodyItem : TeaModel {
            [NameInMap("FullStorageSize")]
            [Validation(Required=false)]
            public long? FullStorageSize { get; set; }
            [NameInMap("BuyCreateTimestamp")]
            [Validation(Required=false)]
            public long? BuyCreateTimestamp { get; set; }
            [NameInMap("BuyExpiredTimestamp")]
            [Validation(Required=false)]
            public long? BuyExpiredTimestamp { get; set; }
            [NameInMap("QuotaEndTimestamp")]
            [Validation(Required=false)]
            public long? QuotaEndTimestamp { get; set; }
            [NameInMap("BuySpec")]
            [Validation(Required=false)]
            public string BuySpec { get; set; }
            [NameInMap("QuotaStartTimestamp")]
            [Validation(Required=false)]
            public long? QuotaStartTimestamp { get; set; }
            [NameInMap("IsExpired")]
            [Validation(Required=false)]
            public bool? IsExpired { get; set; }
            [NameInMap("PaiedBytes")]
            [Validation(Required=false)]
            public long? PaiedBytes { get; set; }
            [NameInMap("TotalFreeBytes")]
            [Validation(Required=false)]
            public long? TotalFreeBytes { get; set; }
            [NameInMap("UsedFullBytes")]
            [Validation(Required=false)]
            public long? UsedFullBytes { get; set; }
            [NameInMap("IsFreeBytesUnlimited")]
            [Validation(Required=false)]
            public bool? IsFreeBytesUnlimited { get; set; }
            [NameInMap("ContStorageSize")]
            [Validation(Required=false)]
            public long? ContStorageSize { get; set; }
            [NameInMap("BuyChargeType")]
            [Validation(Required=false)]
            public string BuyChargeType { get; set; }
            [NameInMap("UsedIncrementBytes")]
            [Validation(Required=false)]
            public long? UsedIncrementBytes { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

    }

}
