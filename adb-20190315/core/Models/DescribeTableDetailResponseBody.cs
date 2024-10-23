// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeTableDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The average number of rows in partitions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AvgSize")]
        [Validation(Required=false)]
        public long? AvgSize { get; set; }

        /// <summary>
        /// <para>The list of partitions.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeTableDetailResponseBodyItems Items { get; set; }
        public class DescribeTableDetailResponseBodyItems : TeaModel {
            [NameInMap("Shard")]
            [Validation(Required=false)]
            public List<DescribeTableDetailResponseBodyItemsShard> Shard { get; set; }
            public class DescribeTableDetailResponseBodyItemsShard : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
