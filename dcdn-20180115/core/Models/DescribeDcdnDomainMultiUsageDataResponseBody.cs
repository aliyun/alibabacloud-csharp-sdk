// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainMultiUsageDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The end of the time range that was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3C6CCEC4-6B88-4D4A-93E4-D47B3D92CF8F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about requests collected every 5 minutes.</para>
        /// </summary>
        [NameInMap("RequestPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainMultiUsageDataResponseBodyRequestPerInterval RequestPerInterval { get; set; }
        public class DescribeDcdnDomainMultiUsageDataResponseBodyRequestPerInterval : TeaModel {
            [NameInMap("RequestDataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainMultiUsageDataResponseBodyRequestPerIntervalRequestDataModule> RequestDataModule { get; set; }
            public class DescribeDcdnDomainMultiUsageDataResponseBodyRequestPerIntervalRequestDataModule : TeaModel {
                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The number of requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1128</para>
                /// </summary>
                [NameInMap("Request")]
                [Validation(Required=false)]
                public long? Request { get; set; }

                /// <summary>
                /// <para>The timestamp of the data returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-10T20:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The type of the requests. Valid values: StaticHttps, DynamicHttps, DynamicHttp, StaticQuic, and DynamicQuic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DynamicHttp</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The beginning of the time range that was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The statistics of network traffic collected every 5 minutes.</para>
        /// </summary>
        [NameInMap("TrafficPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainMultiUsageDataResponseBodyTrafficPerInterval TrafficPerInterval { get; set; }
        public class DescribeDcdnDomainMultiUsageDataResponseBodyTrafficPerInterval : TeaModel {
            [NameInMap("TrafficDataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainMultiUsageDataResponseBodyTrafficPerIntervalTrafficDataModule> TrafficDataModule { get; set; }
            public class DescribeDcdnDomainMultiUsageDataResponseBodyTrafficPerIntervalTrafficDataModule : TeaModel {
                /// <summary>
                /// <para>The name of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("Area")]
                [Validation(Required=false)]
                public string Area { get; set; }

                /// <summary>
                /// <para>The number of bits per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11288111.1</para>
                /// </summary>
                [NameInMap("Bps")]
                [Validation(Required=false)]
                public float? Bps { get; set; }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The timestamp of the data returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-10T20:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The type of the network traffic. Valid values: Simple, IPA, and WebSocket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Simple</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
