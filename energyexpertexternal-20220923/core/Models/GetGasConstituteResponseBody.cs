// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetGasConstituteResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetGasConstituteResponseBodyData> Data { get; set; }
        public class GetGasConstituteResponseBodyData : TeaModel {
            /// <summary>
            /// Carbon emissions
            /// </summary>
            [NameInMap("carbonEmissionData")]
            [Validation(Required=false)]
            public double? CarbonEmissionData { get; set; }

            /// <summary>
            /// Gas emissions
            /// </summary>
            [NameInMap("gasEmissionData")]
            [Validation(Required=false)]
            public double? GasEmissionData { get; set; }

            /// <summary>
            /// Name of gas
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Proportion of carbon emissions. Example value: 0.5 (50%)
            /// </summary>
            [NameInMap("ratio")]
            [Validation(Required=false)]
            public double? Ratio { get; set; }

            /// <summary>
            /// Gas Type
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
