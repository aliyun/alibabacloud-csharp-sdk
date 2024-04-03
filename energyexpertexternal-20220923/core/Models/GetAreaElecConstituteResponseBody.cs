// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetAreaElecConstituteResponseBody : TeaModel {
        /// <summary>
        /// The code returned for the request. A value of Success indicates that the request was successful. Other values indicate that the request failed. You can troubleshoot the error by viewing the error message returned.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAreaElecConstituteResponseBodyData Data { get; set; }
        public class GetAreaElecConstituteResponseBodyData : TeaModel {
            /// <summary>
            /// Photoelectric power consumption and carbon emission data of each enterprise.
            /// </summary>
            [NameInMap("light")]
            [Validation(Required=false)]
            public List<CarbonEmissionElecSummaryItem> Light { get; set; }

            /// <summary>
            /// Data on nuclear power consumption and carbon emissions at each enterprise.
            /// </summary>
            [NameInMap("nuclear")]
            [Validation(Required=false)]
            public List<CarbonEmissionElecSummaryItem> Nuclear { get; set; }

            /// <summary>
            /// Data on renewable electricity consumption and carbon emissions at each enterprise.
            /// </summary>
            [NameInMap("renewing")]
            [Validation(Required=false)]
            public List<CarbonEmissionElecSummaryItem> Renewing { get; set; }

            /// <summary>
            /// Data on mains electricity consumption and carbon emission of each enterprise.
            /// </summary>
            [NameInMap("urban")]
            [Validation(Required=false)]
            public List<CarbonEmissionElecSummaryItem> Urban { get; set; }

            /// <summary>
            /// Hydropower consumption and carbon emission data of each enterprise.
            /// </summary>
            [NameInMap("water")]
            [Validation(Required=false)]
            public List<CarbonEmissionElecSummaryItem> Water { get; set; }

            /// <summary>
            /// Wind power consumption and carbon emission data of each enterprise.
            /// </summary>
            [NameInMap("wind")]
            [Validation(Required=false)]
            public List<CarbonEmissionElecSummaryItem> Wind { get; set; }

            /// <summary>
            /// Data of zero electricity consumption and carbon emission of each enterprise.
            /// </summary>
            [NameInMap("zero")]
            [Validation(Required=false)]
            public List<CarbonEmissionElecSummaryItem> Zero { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
