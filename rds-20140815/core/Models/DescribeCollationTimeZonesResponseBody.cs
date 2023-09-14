// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCollationTimeZonesResponseBody : TeaModel {
        /// <summary>
        /// The list of the character set collations and time zones that are available.
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
                /// The description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The offset of the UTC time. The offset is in the following format: (UTC+*HH:mm*).
                /// </summary>
                [NameInMap("StandardTimeOffset")]
                [Validation(Required=false)]
                public string StandardTimeOffset { get; set; }

                /// <summary>
                /// The time zone.
                /// </summary>
                [NameInMap("TimeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
