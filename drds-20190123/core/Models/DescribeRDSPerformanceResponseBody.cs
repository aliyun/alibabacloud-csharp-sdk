// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeRDSPerformanceResponseBody : TeaModel {
        /// <summary>
        /// The result set of the query.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeRDSPerformanceResponseBodyData> Data { get; set; }
        public class DescribeRDSPerformanceResponseBodyData : TeaModel {
            /// <summary>
            /// The name of the monitoring metric.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The name of the node.
            /// 
            /// >  This parameter is returned only when the storage type of the database is PolarDB for MySQL. If the storage type of the database is ApsaraDB RDS for MySQL, this parameter is not returned.
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// The number of nodes.
            /// </summary>
            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public int? NodeNum { get; set; }

            /// <summary>
            /// The unit of the monitoring metric.
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            /// <summary>
            /// The details of the monitoring metric data.
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<DescribeRDSPerformanceResponseBodyDataValues> Values { get; set; }
            public class DescribeRDSPerformanceResponseBodyDataValues : TeaModel {
                /// <summary>
                /// The time point when the value of the monitoring metric was obtained. The value is in the UNIX timestamp format. The time is displayed in UTC. Unit: ms.
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public long? Date { get; set; }

                /// <summary>
                /// The value of the monitoring metric.
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
