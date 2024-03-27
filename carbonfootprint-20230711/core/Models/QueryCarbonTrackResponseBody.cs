// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CarbonFootprint20230711.Models
{
    public class QueryCarbonTrackResponseBody : TeaModel {
        /// <summary>
        /// The data records.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryCarbonTrackResponseBodyData> Data { get; set; }
        public class QueryCarbonTrackResponseBodyData : TeaModel {
            /// <summary>
            /// The service code.
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// The carbon emissions within the specified time range, in kgCO₂e.
            /// </summary>
            [NameInMap("QuotaValue")]
            [Validation(Required=false)]
            public double? QuotaValue { get; set; }

            /// <summary>
            /// The region in which the cloud service resides.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The date when the statistics are collected, which is a timestamp in milliseconds.
            /// </summary>
            [NameInMap("StatisticsDate")]
            [Validation(Required=false)]
            public long? StatisticsDate { get; set; }

            /// <summary>
            /// The ID of the RAM user.
            /// </summary>
            [NameInMap("SubUid")]
            [Validation(Required=false)]
            public string SubUid { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account.
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
