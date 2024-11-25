// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeRequestGraphResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the DNS requests.</para>
        /// </summary>
        [NameInMap("RequestDetails")]
        [Validation(Required=false)]
        public DescribeRequestGraphResponseBodyRequestDetails RequestDetails { get; set; }
        public class DescribeRequestGraphResponseBodyRequestDetails : TeaModel {
            [NameInMap("ZoneRequestTop")]
            [Validation(Required=false)]
            public List<DescribeRequestGraphResponseBodyRequestDetailsZoneRequestTop> ZoneRequestTop { get; set; }
            public class DescribeRequestGraphResponseBodyRequestDetailsZoneRequestTop : TeaModel {
                /// <summary>
                /// <para>The number of DNS requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>103</para>
                /// </summary>
                [NameInMap("RequestCount")]
                [Validation(Required=false)]
                public long? RequestCount { get; set; }

                /// <summary>
                /// <para>The time when the data was collected. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-10-21T10:00Z</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// <para>The time when the data was collected. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1571652000000</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EB71815-A421-4E51-8E8D-667F44ABE633</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
