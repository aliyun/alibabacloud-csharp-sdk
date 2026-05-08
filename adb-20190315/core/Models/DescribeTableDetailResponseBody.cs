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
        /// <para>The queried shard.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeTableDetailResponseBodyItems Items { get; set; }
        public class DescribeTableDetailResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The queried shards.</para>
            /// </summary>
            [NameInMap("Shard")]
            [Validation(Required=false)]
            public List<DescribeTableDetailResponseBodyItemsShard> Shard { get; set; }
            public class DescribeTableDetailResponseBodyItemsShard : TeaModel {
                /// <summary>
                /// <para>The partition ID. Only the numeric part of the partition name is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// <para>The number of rows in the partition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
