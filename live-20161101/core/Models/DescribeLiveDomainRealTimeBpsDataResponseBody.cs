// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainRealTimeBpsDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The time granularity of the queried data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// <para>The streaming domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example1.aliyundoc.com,example2.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range. The format is <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-11-30T05:40:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RealTimeBpsDataPerInterval")]
        [Validation(Required=false)]
        public DescribeLiveDomainRealTimeBpsDataResponseBodyRealTimeBpsDataPerInterval RealTimeBpsDataPerInterval { get; set; }
        public class DescribeLiveDomainRealTimeBpsDataResponseBodyRealTimeBpsDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainRealTimeBpsDataResponseBodyRealTimeBpsDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeLiveDomainRealTimeBpsDataResponseBodyRealTimeBpsDataPerIntervalDataModule : TeaModel {
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC858082-736F-4A25-867B-E5B6******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start of the time range. The format is <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-11-30T05:33:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
