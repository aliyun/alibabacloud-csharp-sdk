// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainRegionDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The time interval between the data entries returned. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// <para>The accelerated domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range for which the data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-07T12:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2E5AD83F-BD7B-462E-8319-2E30E305519A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range for which the data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-05T12:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The proportions of requests initiated from each region.</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public DescribeDomainRegionDataResponseBodyValue Value { get; set; }
        public class DescribeDomainRegionDataResponseBodyValue : TeaModel {
            [NameInMap("RegionProportionData")]
            [Validation(Required=false)]
            public List<DescribeDomainRegionDataResponseBodyValueRegionProportionData> RegionProportionData { get; set; }
            public class DescribeDomainRegionDataResponseBodyValueRegionProportionData : TeaModel {
                /// <summary>
                /// <para>The average response size. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>800019.0</para>
                /// </summary>
                [NameInMap("AvgObjectSize")]
                [Validation(Required=false)]
                public string AvgObjectSize { get; set; }

                /// <summary>
                /// <para>The average response speed. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>154.3345765545624</para>
                /// </summary>
                [NameInMap("AvgResponseRate")]
                [Validation(Required=false)]
                public string AvgResponseRate { get; set; }

                /// <summary>
                /// <para>The average response time. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5183.666666666667</para>
                /// </summary>
                [NameInMap("AvgResponseTime")]
                [Validation(Required=false)]
                public string AvgResponseTime { get; set; }

                /// <summary>
                /// <para>The bandwidth.</para>
                /// 
                /// <b>Example:</b>
                /// <para>380.9614285714286</para>
                /// </summary>
                [NameInMap("Bps")]
                [Validation(Required=false)]
                public string Bps { get; set; }

                /// <summary>
                /// <para>The proportion of traffic from the region. For example, a value of 90 indicates that 90% of the traffic is from the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.003544181046236794</para>
                /// </summary>
                [NameInMap("BytesProportion")]
                [Validation(Required=false)]
                public string BytesProportion { get; set; }

                /// <summary>
                /// <para>The proportion of visits from the region. For example, a value of 90 indicates that 90% of the visits are from the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.01155980271270037</para>
                /// </summary>
                [NameInMap("Proportion")]
                [Validation(Required=false)]
                public string Proportion { get; set; }

                /// <summary>
                /// <para>The number of queries per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.9523809523809524E-5</para>
                /// </summary>
                [NameInMap("Qps")]
                [Validation(Required=false)]
                public string Qps { get; set; }

                /// <summary>
                /// <para>The information about the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Japan</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The name of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>japan</para>
                /// </summary>
                [NameInMap("RegionEname")]
                [Validation(Required=false)]
                public string RegionEname { get; set; }

                /// <summary>
                /// <para>The request error rate. A value of 90 indicates that 90% of the requests encountered errors.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("ReqErrRate")]
                [Validation(Required=false)]
                public string ReqErrRate { get; set; }

                /// <summary>
                /// <para>The total traffic. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2400057</para>
                /// </summary>
                [NameInMap("TotalBytes")]
                [Validation(Required=false)]
                public string TotalBytes { get; set; }

                /// <summary>
                /// <para>The total number of requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("TotalQuery")]
                [Validation(Required=false)]
                public string TotalQuery { get; set; }

            }

        }

    }

}
