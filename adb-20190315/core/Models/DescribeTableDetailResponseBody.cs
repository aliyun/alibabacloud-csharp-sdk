// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeTableDetailResponseBody : TeaModel {
        /// <summary>
        /// The average number of rows in partitions.
        /// </summary>
        [NameInMap("AvgSize")]
        [Validation(Required=false)]
        public long? AvgSize { get; set; }

        /// <summary>
        /// The list of partitions.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeTableDetailResponseBodyItems Items { get; set; }
        public class DescribeTableDetailResponseBodyItems : TeaModel {
            [NameInMap("Shard")]
            [Validation(Required=false)]
            public List<DescribeTableDetailResponseBodyItemsShard> Shard { get; set; }
            public class DescribeTableDetailResponseBodyItemsShard : TeaModel {
                /// <summary>
                /// The ID of the partition. Only the numeric part of the partition name is returned.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// The number of rows in the table.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
