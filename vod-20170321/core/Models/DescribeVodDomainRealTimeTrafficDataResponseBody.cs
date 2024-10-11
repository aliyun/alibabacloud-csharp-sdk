// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainRealTimeTrafficDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The time interval at which data is returned. Unit: seconds.</para>
        /// <para>The returned value varies based on the time range per query. Valid values: 60 (1 minute), 300 (5 minutes), and 3600 (1 hour). For more information, see the <b>Time granularity</b> section in the <b>API documentation</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
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
        /// <para>The end of the time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-12-10T20:01:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The details of traffic data in each time interval.</para>
        /// </summary>
        [NameInMap("RealTimeTrafficDataPerInterval")]
        [Validation(Required=false)]
        public DescribeVodDomainRealTimeTrafficDataResponseBodyRealTimeTrafficDataPerInterval RealTimeTrafficDataPerInterval { get; set; }
        public class DescribeVodDomainRealTimeTrafficDataResponseBodyRealTimeTrafficDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVodDomainRealTimeTrafficDataResponseBodyRealTimeTrafficDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeVodDomainRealTimeTrafficDataResponseBodyRealTimeTrafficDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// <para>The timestamp of the data returned. The time follows the ISO 8601 standard. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-12-10T20:01:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The traffic data. Unit: bytes.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A666D44F-19D6-490E-97CF-1A64AB962C57</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
