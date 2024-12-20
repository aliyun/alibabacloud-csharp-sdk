// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Httpdns20160201.Models
{
    public class GetResolveStatisticsResponseBody : TeaModel {
        [NameInMap("DataPoints")]
        [Validation(Required=false)]
        public GetResolveStatisticsResponseBodyDataPoints DataPoints { get; set; }
        public class GetResolveStatisticsResponseBodyDataPoints : TeaModel {
            [NameInMap("DataPoint")]
            [Validation(Required=false)]
            public List<GetResolveStatisticsResponseBodyDataPointsDataPoint> DataPoint { get; set; }
            public class GetResolveStatisticsResponseBodyDataPointsDataPoint : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>9703</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1488297600</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public int? Time { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50F9C40E-188D-B00B-BE2C-7427E531****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
