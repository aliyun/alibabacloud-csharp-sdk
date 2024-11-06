// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainPvDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The time interval between the data entries returned. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
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
        /// <para>The end of the time range that was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-11-29T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The number of PVs at each interval.</para>
        /// </summary>
        [NameInMap("PvDataInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainPvDataResponseBodyPvDataInterval PvDataInterval { get; set; }
        public class DescribeDcdnDomainPvDataResponseBodyPvDataInterval : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainPvDataResponseBodyPvDataIntervalUsageData> UsageData { get; set; }
            public class DescribeDcdnDomainPvDataResponseBodyPvDataIntervalUsageData : TeaModel {
                /// <summary>
                /// <para>The timestamp of the data returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-11-28T03:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The number of PVs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9292</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BCD7D917-76F1-442F-BB75-C810DE34C761</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range that was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-11-28T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
