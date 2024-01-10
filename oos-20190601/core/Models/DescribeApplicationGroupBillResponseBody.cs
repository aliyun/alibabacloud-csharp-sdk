// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class DescribeApplicationGroupBillResponseBody : TeaModel {
        /// <summary>
        /// The consume of application group.
        /// </summary>
        [NameInMap("ApplicationGroupConsume")]
        [Validation(Required=false)]
        public List<DescribeApplicationGroupBillResponseBodyApplicationGroupConsume> ApplicationGroupConsume { get; set; }
        public class DescribeApplicationGroupBillResponseBodyApplicationGroupConsume : TeaModel {
            /// <summary>
            /// The amount consumed by the instance.
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public float? Amount { get; set; }

            /// <summary>
            /// The time when the instance was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The currency unit.
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the instance.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The instance type.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// Optimization suggestions.
            /// </summary>
            [NameInMap("Optimization")]
            [Validation(Required=false)]
            public string Optimization { get; set; }

            /// <summary>
            /// The peak type.
            /// </summary>
            [NameInMap("PeakType")]
            [Validation(Required=false)]
            public string PeakType { get; set; }

            /// <summary>
            /// The performance of the data synchronization instance.
            /// </summary>
            [NameInMap("Performance")]
            [Validation(Required=false)]
            public string Performance { get; set; }

            /// <summary>
            /// The status of instance.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used to retrieve the next page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
