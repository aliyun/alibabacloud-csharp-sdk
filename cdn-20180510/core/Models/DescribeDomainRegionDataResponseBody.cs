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

        [NameInMap("Value")]
        [Validation(Required=false)]
        public DescribeDomainRegionDataResponseBodyValue Value { get; set; }
        public class DescribeDomainRegionDataResponseBodyValue : TeaModel {
            [NameInMap("RegionProportionData")]
            [Validation(Required=false)]
            public List<DescribeDomainRegionDataResponseBodyValueRegionProportionData> RegionProportionData { get; set; }
            public class DescribeDomainRegionDataResponseBodyValueRegionProportionData : TeaModel {
                [NameInMap("AvgObjectSize")]
                [Validation(Required=false)]
                public string AvgObjectSize { get; set; }

                [NameInMap("AvgResponseRate")]
                [Validation(Required=false)]
                public string AvgResponseRate { get; set; }

                [NameInMap("AvgResponseTime")]
                [Validation(Required=false)]
                public string AvgResponseTime { get; set; }

                [NameInMap("Bps")]
                [Validation(Required=false)]
                public string Bps { get; set; }

                [NameInMap("BytesProportion")]
                [Validation(Required=false)]
                public string BytesProportion { get; set; }

                [NameInMap("Proportion")]
                [Validation(Required=false)]
                public string Proportion { get; set; }

                [NameInMap("Qps")]
                [Validation(Required=false)]
                public string Qps { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("RegionEname")]
                [Validation(Required=false)]
                public string RegionEname { get; set; }

                [NameInMap("ReqErrRate")]
                [Validation(Required=false)]
                public string ReqErrRate { get; set; }

                [NameInMap("TotalBytes")]
                [Validation(Required=false)]
                public string TotalBytes { get; set; }

                [NameInMap("TotalQuery")]
                [Validation(Required=false)]
                public string TotalQuery { get; set; }

            }

        }

    }

}
