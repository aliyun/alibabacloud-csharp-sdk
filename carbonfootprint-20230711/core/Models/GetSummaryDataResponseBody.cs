// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CarbonFootprint20230711.Models
{
    public class GetSummaryDataResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSummaryDataResponseBodyData Data { get; set; }
        public class GetSummaryDataResponseBodyData : TeaModel {
            [NameInMap("AircraftConsumptionConversion")]
            [Validation(Required=false)]
            public string AircraftConsumptionConversion { get; set; }

            [NameInMap("CarConsumptionConversion")]
            [Validation(Required=false)]
            public string CarConsumptionConversion { get; set; }

            [NameInMap("LastMonthConsumptionConversion")]
            [Validation(Required=false)]
            public string LastMonthConsumptionConversion { get; set; }

            [NameInMap("LastYearConsumptionConversion")]
            [Validation(Required=false)]
            public string LastYearConsumptionConversion { get; set; }

            [NameInMap("LastYearConsumptionConversionSum")]
            [Validation(Required=false)]
            public string LastYearConsumptionConversionSum { get; set; }

            [NameInMap("LatestDataTime")]
            [Validation(Required=false)]
            public string LatestDataTime { get; set; }

            [NameInMap("ThisMonthConsumptionConversion")]
            [Validation(Required=false)]
            public string ThisMonthConsumptionConversion { get; set; }

            [NameInMap("ThisYearConsumptionConversion")]
            [Validation(Required=false)]
            public string ThisYearConsumptionConversion { get; set; }

            [NameInMap("TotalCarbonConsumptionConversion")]
            [Validation(Required=false)]
            public string TotalCarbonConsumptionConversion { get; set; }

            [NameInMap("TreeConsumptionConversion")]
            [Validation(Required=false)]
            public string TreeConsumptionConversion { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
