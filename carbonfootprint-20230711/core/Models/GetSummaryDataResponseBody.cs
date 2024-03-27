// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CarbonFootprint20230711.Models
{
    public class GetSummaryDataResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSummaryDataResponseBodyData Data { get; set; }
        public class GetSummaryDataResponseBodyData : TeaModel {
            /// <summary>
            /// Converted aircraft carbon emissions.
            /// </summary>
            [NameInMap("AircraftConsumptionConversion")]
            [Validation(Required=false)]
            public string AircraftConsumptionConversion { get; set; }

            /// <summary>
            /// Converted car carbon emissions.
            /// </summary>
            [NameInMap("CarConsumptionConversion")]
            [Validation(Required=false)]
            public string CarConsumptionConversion { get; set; }

            /// <summary>
            /// The carbon emissions in the previous month, in kgCO₂e.
            /// </summary>
            [NameInMap("LastMonthConsumptionConversion")]
            [Validation(Required=false)]
            public string LastMonthConsumptionConversion { get; set; }

            /// <summary>
            /// The carbon emissions in the same month of the previous year, in kgCO₂e.
            /// </summary>
            [NameInMap("LastYearConsumptionConversion")]
            [Validation(Required=false)]
            public string LastYearConsumptionConversion { get; set; }

            /// <summary>
            /// The carbon emissions of the previous year, in kgCO₂e.
            /// </summary>
            [NameInMap("LastYearConsumptionConversionSum")]
            [Validation(Required=false)]
            public string LastYearConsumptionConversionSum { get; set; }

            /// <summary>
            /// The point in time at which the data is last updated.
            /// </summary>
            [NameInMap("LatestDataTime")]
            [Validation(Required=false)]
            public string LatestDataTime { get; set; }

            /// <summary>
            /// The carbon emissions in this month, in kgCO₂e.
            /// </summary>
            [NameInMap("ThisMonthConsumptionConversion")]
            [Validation(Required=false)]
            public string ThisMonthConsumptionConversion { get; set; }

            /// <summary>
            /// The carbon emissions in the year of this month, in kgCO₂e.
            /// </summary>
            [NameInMap("ThisYearConsumptionConversion")]
            [Validation(Required=false)]
            public string ThisYearConsumptionConversion { get; set; }

            /// <summary>
            /// The total carbon emissions within the specified time range, in kgCO₂e.
            /// </summary>
            [NameInMap("TotalCarbonConsumptionConversion")]
            [Validation(Required=false)]
            public string TotalCarbonConsumptionConversion { get; set; }

            /// <summary>
            /// Converted tree carbon absorption.
            /// </summary>
            [NameInMap("TreeConsumptionConversion")]
            [Validation(Required=false)]
            public string TreeConsumptionConversion { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
