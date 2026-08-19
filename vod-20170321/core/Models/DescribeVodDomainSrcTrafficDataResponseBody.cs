// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainSrcTrafficDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The time interval between consecutive data entries, which is the time granularity of the data. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
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
        /// <para>The end of the time range for the returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-09-23T15:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-D7393642CA58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SrcTrafficDataPerInterval")]
        [Validation(Required=false)]
        public DescribeVodDomainSrcTrafficDataResponseBodySrcTrafficDataPerInterval SrcTrafficDataPerInterval { get; set; }
        public class DescribeVodDomainSrcTrafficDataResponseBodySrcTrafficDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVodDomainSrcTrafficDataResponseBodySrcTrafficDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeVodDomainSrcTrafficDataResponseBodySrcTrafficDataPerIntervalDataModule : TeaModel {
                [NameInMap("HttpsValue")]
                [Validation(Required=false)]
                public string HttpsValue { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The beginning of the time range for the returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-29T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The total traffic. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5906662826</para>
        /// </summary>
        [NameInMap("TotalTraffic")]
        [Validation(Required=false)]
        public string TotalTraffic { get; set; }

    }

}
