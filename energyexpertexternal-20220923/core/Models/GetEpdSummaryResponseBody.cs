// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetEpdSummaryResponseBody : TeaModel {
        /// <summary>
        /// Response parameters
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetEpdSummaryResponseBodyData> Data { get; set; }
        public class GetEpdSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// Emissions. The result is maintained up to 31 decimal places for precise intermediate calculation and subsequently truncated for display. It is advised to pair the emissions figure with the unit of the environmental impact result for a comprehensive understanding.
            /// </summary>
            [NameInMap("carbonEmission")]
            [Validation(Required=false)]
            public double? CarbonEmission { get; set; }

            /// <summary>
            /// The evaluation index adopted for the environmental impact
            /// </summary>
            [NameInMap("indicator")]
            [Validation(Required=false)]
            public string Indicator { get; set; }

            /// <summary>
            /// The category key. The environmental impact category. Currently, a maximum of 19 categories are supported. Enumeration refers to [Carbon Footprint Appendices](https://carbon-doc.oss-cn-hangzhou.aliyuncs.com/CarbonFootprintAppendices-en.pdf).
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// Calculation method standard
            /// </summary>
            [NameInMap("method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// The name of the category.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Category num: the unique serial number of the environmental impact category. A maximum of 19 categories are supported. Enumeration refers to [Carbon Footprint Appendices](https://carbon-doc.oss-cn-hangzhou.aliyuncs.com/CarbonFootprintAppendices-en.pdf).
            /// </summary>
            [NameInMap("num")]
            [Validation(Required=false)]
            public long? Num { get; set; }

            /// <summary>
            /// Environmental impact result Value Unit.
            /// </summary>
            [NameInMap("preUnit")]
            [Validation(Required=false)]
            public string PreUnit { get; set; }

            /// <summary>
            /// The data status. 1 indicates that the calculation is accurate, 2 indicates that the default data is used, and 3 indicates that the missing factor uses the value of 0.
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public long? State { get; set; }

        }

        /// <summary>
        /// The ID of the request. The value is unique for each request. This facilitates subsequent troubleshooting.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
