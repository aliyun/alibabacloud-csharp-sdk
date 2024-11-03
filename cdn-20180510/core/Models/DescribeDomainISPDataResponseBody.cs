// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainISPDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The time interval. Unit: seconds.</para>
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
        /// <para>The end of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-11-30T05:40:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DE81639B-DAC1-4C76-AB72-F34B836837D5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range that was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-11-29T05:33:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The access statistics by ISP.</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public DescribeDomainISPDataResponseBodyValue Value { get; set; }
        public class DescribeDomainISPDataResponseBodyValue : TeaModel {
            [NameInMap("ISPProportionData")]
            [Validation(Required=false)]
            public List<DescribeDomainISPDataResponseBodyValueISPProportionData> ISPProportionData { get; set; }
            public class DescribeDomainISPDataResponseBodyValueISPProportionData : TeaModel {
                /// <summary>
                /// <para>The average response size. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7081884.7</para>
                /// </summary>
                [NameInMap("AvgObjectSize")]
                [Validation(Required=false)]
                public string AvgObjectSize { get; set; }

                /// <summary>
                /// <para>The average response speed. Unit: byte/ms.</para>
                /// 
                /// <b>Example:</b>
                /// <para>88.92594866772144</para>
                /// </summary>
                [NameInMap("AvgResponseRate")]
                [Validation(Required=false)]
                public string AvgResponseRate { get; set; }

                /// <summary>
                /// <para>The average response time. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>79638.0</para>
                /// </summary>
                [NameInMap("AvgResponseTime")]
                [Validation(Required=false)]
                public string AvgResponseTime { get; set; }

                /// <summary>
                /// <para>The bandwidth.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1311.4601296296296</para>
                /// </summary>
                [NameInMap("Bps")]
                [Validation(Required=false)]
                public string Bps { get; set; }

                /// <summary>
                /// <para>The proportion of network traffic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.012220518530445479</para>
                /// </summary>
                [NameInMap("BytesProportion")]
                [Validation(Required=false)]
                public string BytesProportion { get; set; }

                /// <summary>
                /// <para>The information about the ISP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba</para>
                /// </summary>
                [NameInMap("ISP")]
                [Validation(Required=false)]
                public string ISP { get; set; }

                /// <summary>
                /// <para>The name of the ISP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alibaba</para>
                /// </summary>
                [NameInMap("IspEname")]
                [Validation(Required=false)]
                public string IspEname { get; set; }

                /// <summary>
                /// <para>The proportion of the HTTP status code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.004509176173513099</para>
                /// </summary>
                [NameInMap("Proportion")]
                [Validation(Required=false)]
                public string Proportion { get; set; }

                /// <summary>
                /// <para>The QPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.3148148148148147E-5</para>
                /// </summary>
                [NameInMap("Qps")]
                [Validation(Required=false)]
                public string Qps { get; set; }

                /// <summary>
                /// <para>The request error rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("ReqErrRate")]
                [Validation(Required=false)]
                public string ReqErrRate { get; set; }

                /// <summary>
                /// <para>The total volume of traffic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7081884</para>
                /// </summary>
                [NameInMap("TotalBytes")]
                [Validation(Required=false)]
                public string TotalBytes { get; set; }

                /// <summary>
                /// <para>The total number of requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TotalQuery")]
                [Validation(Required=false)]
                public string TotalQuery { get; set; }

            }

        }

    }

}
