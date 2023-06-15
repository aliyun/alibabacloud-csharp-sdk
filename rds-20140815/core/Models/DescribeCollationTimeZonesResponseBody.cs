// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCollationTimeZonesResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the character set collations and time zones that are available for use in ApsaraDB RDS.
        /// </summary>
        [NameInMap("CollationTimeZones")]
        [Validation(Required=false)]
        public DescribeCollationTimeZonesResponseBodyCollationTimeZones CollationTimeZones { get; set; }
        public class DescribeCollationTimeZonesResponseBodyCollationTimeZones : TeaModel {
            [NameInMap("CollationTimeZone")]
            [Validation(Required=false)]
            public List<DescribeCollationTimeZonesResponseBodyCollationTimeZonesCollationTimeZone> CollationTimeZone { get; set; }
            public class DescribeCollationTimeZonesResponseBodyCollationTimeZonesCollationTimeZone : TeaModel {
                /// <summary>
                /// The description of the character set collations and time zones.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The offset of the UTC time. The offset is in the following format: (UTC+\<i>HH:mm\</i>).
                /// </summary>
                [NameInMap("StandardTimeOffset")]
                [Validation(Required=false)]
                public string StandardTimeOffset { get; set; }

                /// <summary>
                /// The time zone that is available for use in ApsaraDB RDS.
                /// </summary>
                [NameInMap("TimeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
