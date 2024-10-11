// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainSrcBpsDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The time interval at which data is returned, which is the time granularity. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// <para>The accelerated domain name whose ICP filing status you want to update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sample.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-23T02:02:57Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A13-BEF6-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The origin bandwidth data at each time interval.</para>
        /// </summary>
        [NameInMap("SrcBpsDataPerInterval")]
        [Validation(Required=false)]
        public DescribeVodDomainSrcBpsDataResponseBodySrcBpsDataPerInterval SrcBpsDataPerInterval { get; set; }
        public class DescribeVodDomainSrcBpsDataResponseBodySrcBpsDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVodDomainSrcBpsDataResponseBodySrcBpsDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeVodDomainSrcBpsDataResponseBodySrcBpsDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// <para>The bandwidth consumed for fetching resources from the origin over HTTPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("HttpsValue")]
                [Validation(Required=false)]
                public string HttpsValue { get; set; }

                /// <summary>
                /// <para>The timestamp of the data returned. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-23T02:02:57Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The total origin bandwidth data. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The beginning of the time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-12T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
