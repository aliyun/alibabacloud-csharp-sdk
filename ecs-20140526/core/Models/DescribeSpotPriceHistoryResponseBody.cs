// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSpotPriceHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance type of the spot instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CNY</para>
        /// </summary>
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// <para>The network type of the spot instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("NextOffset")]
        [Validation(Required=false)]
        public int? NextOffset { get; set; }

        /// <summary>
        /// <para>The instance type of the spot instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The zone ID of the spot instance.</para>
        /// </summary>
        [NameInMap("SpotPrices")]
        [Validation(Required=false)]
        public DescribeSpotPriceHistoryResponseBodySpotPrices SpotPrices { get; set; }
        public class DescribeSpotPriceHistoryResponseBodySpotPrices : TeaModel {
            [NameInMap("SpotPriceType")]
            [Validation(Required=false)]
            public List<DescribeSpotPriceHistoryResponseBodySpotPricesSpotPriceType> SpotPriceType { get; set; }
            public class DescribeSpotPriceHistoryResponseBodySpotPricesSpotPriceType : TeaModel {
                /// <summary>
                /// <para>The instance type of the spot instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.g5.large</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>Details about the price history of the spot instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>optimized</para>
                /// </summary>
                [NameInMap("IoOptimized")]
                [Validation(Required=false)]
                public string IoOptimized { get; set; }

                /// <summary>
                /// <para>Queries the price history of a spot instance within the last 30 days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The price for a pay-as-you-go instance that has the same configuration as the specified spot instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.354</para>
                /// </summary>
                [NameInMap("OriginPrice")]
                [Validation(Required=false)]
                public float? OriginPrice { get; set; }

                /// <summary>
                /// <para>The price for a pay-as-you-go instance that has the same configurations as the spot instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.036</para>
                /// </summary>
                [NameInMap("SpotPrice")]
                [Validation(Required=false)]
                public float? SpotPrice { get; set; }

                /// <summary>
                /// <para>The currency unit of the price.</para>
                /// <para>Alibaba Cloud China site (aliyun.com): CNY.</para>
                /// <para>Alibaba Cloud International site (alibabacloud.com): USD.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-11-19T06:00:00Z</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

                /// <summary>
                /// <para>The ID of the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-c</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
