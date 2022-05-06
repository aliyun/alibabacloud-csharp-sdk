// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCollationTimeZonesResponseBody : TeaModel {
        [NameInMap("CollationTimeZones")]
        [Validation(Required=false)]
        public DescribeCollationTimeZonesResponseBodyCollationTimeZones CollationTimeZones { get; set; }
        public class DescribeCollationTimeZonesResponseBodyCollationTimeZones : TeaModel {
            [NameInMap("CollationTimeZone")]
            [Validation(Required=false)]
            public List<DescribeCollationTimeZonesResponseBodyCollationTimeZonesCollationTimeZone> CollationTimeZone { get; set; }
            public class DescribeCollationTimeZonesResponseBodyCollationTimeZonesCollationTimeZone : TeaModel {
                public string Description { get; set; }
                public string StandardTimeOffset { get; set; }
                public string TimeZone { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
