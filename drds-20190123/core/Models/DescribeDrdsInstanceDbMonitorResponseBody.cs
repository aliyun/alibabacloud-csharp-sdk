// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsInstanceDbMonitorResponseBody : TeaModel {
        /// <summary>
        /// The list of monitoring data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeDrdsInstanceDbMonitorResponseBodyData> Data { get; set; }
        public class DescribeDrdsInstanceDbMonitorResponseBodyData : TeaModel {
            /// <summary>
            /// The name of the monitoring metric.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The unit of the monitoring metric.
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            /// <summary>
            /// The details about the value of monitoring data.
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<DescribeDrdsInstanceDbMonitorResponseBodyDataValues> Values { get; set; }
            public class DescribeDrdsInstanceDbMonitorResponseBodyDataValues : TeaModel {
                /// <summary>
                /// The time point when the value of monitoring data was obtained. The value is in the UNIX timestamp format. Unit: ms.
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public long? Date { get; set; }

                /// <summary>
                /// The data value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
