// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class QueryUniqueDeviceStatResponseBody : TeaModel {
        [NameInMap("AppDeviceStats")]
        [Validation(Required=false)]
        public QueryUniqueDeviceStatResponseBodyAppDeviceStats AppDeviceStats { get; set; }
        public class QueryUniqueDeviceStatResponseBodyAppDeviceStats : TeaModel {
            [NameInMap("AppDeviceStat")]
            [Validation(Required=false)]
            public List<QueryUniqueDeviceStatResponseBodyAppDeviceStatsAppDeviceStat> AppDeviceStat { get; set; }
            public class QueryUniqueDeviceStatResponseBodyAppDeviceStatsAppDeviceStat : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2016-07-25T00:00:00Z</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9998B3CC-ED9E-4CB3-A8FB-DCC61296BFBC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
