// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeCollationTimeZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of the character set collations and time zones that are available.</para>
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
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Kabul</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The offset of the UTC time. The offset is in the following format: (UTC+<em>HH:mm</em>).</para>
                /// 
                /// <b>Example:</b>
                /// <para>(UTC+04:30)</para>
                /// </summary>
                [NameInMap("StandardTimeOffset")]
                [Validation(Required=false)]
                public string StandardTimeOffset { get; set; }

                /// <summary>
                /// <para>The time zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Afghanistan Standard Time</para>
                /// </summary>
                [NameInMap("TimeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EAED246-DB18-4C8D-9EB5-C319626F2A77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
