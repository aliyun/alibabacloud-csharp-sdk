// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafUsageDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The operation that you want to perform. Set the value to <b>DescribeDcdnWafUsageData</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-10-01T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies how query results are grouped. By default, this parameter is empty. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>domain: Query results are grouped by accelerated domain name.</description></item>
        /// <item><description>An empty string: Query results are not grouped.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-802B-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The accelerated domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-09-30T16:00:00Z&quot;,</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The number of monitored requests.</para>
        /// </summary>
        [NameInMap("WafUsageData")]
        [Validation(Required=false)]
        public DescribeDcdnWafUsageDataResponseBodyWafUsageData WafUsageData { get; set; }
        public class DescribeDcdnWafUsageDataResponseBodyWafUsageData : TeaModel {
            [NameInMap("WafUsageDataItem")]
            [Validation(Required=false)]
            public List<DescribeDcdnWafUsageDataResponseBodyWafUsageDataWafUsageDataItem> WafUsageDataItem { get; set; }
            public class DescribeDcdnWafUsageDataResponseBodyWafUsageDataWafUsageDataItem : TeaModel {
                /// <summary>
                /// <para>The number of blocked requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>600</para>
                /// </summary>
                [NameInMap("AccessCnt")]
                [Validation(Required=false)]
                public long? AccessCnt { get; set; }

                /// <summary>
                /// <para>The number of allowed requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("BlockCnt")]
                [Validation(Required=false)]
                public long? BlockCnt { get; set; }

                /// <summary>
                /// <para>The domain name that you want to query. If you do not specify an accelerated domain name, all accelerated domain names are queried by default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The end of the time range during which data was queried.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("ObserveCnt")]
                [Validation(Required=false)]
                public long? ObserveCnt { get; set; }

                /// <summary>
                /// <para>The time granularity for a query. Unit: seconds.</para>
                /// <para>The time granularity varies with the maximum time range per query. Valid values: 300 (5 minutes), 3600 (1 hour), and 86400 (1 day).</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("SecCu")]
                [Validation(Required=false)]
                public long? SecCu { get; set; }

                /// <summary>
                /// <para>The beginning of the time range during which data was queried.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-09-30T16:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

    }

}
