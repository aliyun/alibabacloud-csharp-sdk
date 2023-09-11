// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeSQLLogCountResponseBody : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The end time of the query.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The name of the instance.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeSQLLogCountResponseBodyItems> Items { get; set; }
        public class DescribeSQLLogCountResponseBodyItems : TeaModel {
            /// <summary>
            /// The name of the table.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Details of the audit logs.
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<DescribeSQLLogCountResponseBodyItemsSeries> Series { get; set; }
            public class DescribeSQLLogCountResponseBodyItemsSeries : TeaModel {
                /// <summary>
                /// Details of the audit logs.
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<DescribeSQLLogCountResponseBodyItemsSeriesValues> Values { get; set; }
                public class DescribeSQLLogCountResponseBodyItemsSeriesValues : TeaModel {
                    /// <summary>
                    /// The time when the audit logs were generated and the number of the audit logs.
                    /// </summary>
                    [NameInMap("Point")]
                    [Validation(Required=false)]
                    public List<string> Point { get; set; }

                }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The start time of the query.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
