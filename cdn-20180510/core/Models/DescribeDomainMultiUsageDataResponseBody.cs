// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainMultiUsageDataResponseBody : TeaModel {
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
        public DescribeDomainMultiUsageDataResponseBodyRequestPerInterval RequestPerInterval { get; set; }
        public class DescribeDomainMultiUsageDataResponseBodyRequestPerInterval : TeaModel {
            [NameInMap("RequestDataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainMultiUsageDataResponseBodyRequestPerIntervalRequestDataModule> RequestDataModule { get; set; }
            public class DescribeDomainMultiUsageDataResponseBodyRequestPerIntervalRequestDataModule : TeaModel {
                /// <summary>
                /// <para>The accelerated domain name.</para>
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
                /// <para>11288111</para>
                /// </summary>
                [NameInMap("Request")]
                [Validation(Required=false)]
                public long? Request { get; set; }

                /// <summary>
                /// <para>The timestamp of the returned number of requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-10T20:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The type.</para>
                /// <remarks>
                /// <para> The value is Simple for Alibaba Cloud CDN.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Simple</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The start of the time range that was queried.</para>
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
        public DescribeDomainMultiUsageDataResponseBodyTrafficPerInterval TrafficPerInterval { get; set; }
        public class DescribeDomainMultiUsageDataResponseBodyTrafficPerInterval : TeaModel {
            [NameInMap("TrafficDataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainMultiUsageDataResponseBodyTrafficPerIntervalTrafficDataModule> TrafficDataModule { get; set; }
            public class DescribeDomainMultiUsageDataResponseBodyTrafficPerIntervalTrafficDataModule : TeaModel {
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
                /// <para>The bandwidth. Unit: bit/s.</para>
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
                /// <para>The startstamp of the returned usage data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-10T20:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The type of requests. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>StaticHttps</b>: static HTTPS requests</description></item>
                /// <item><description><b>DynamicHttps</b>: dynamic HTTPS requests</description></item>
                /// <item><description><b>DynamicHttp</b>: dynamic HTTP requests</description></item>
                /// <item><description><b>StaticQuic</b>: static QUIC requests</description></item>
                /// <item><description><b>DynamicQuic</b>: dynamic QUIC requests</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DynamicHttp</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
