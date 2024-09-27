// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeRecordStatisticsSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. Pages start from page <b>1</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>1 to 100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E49F0023-4A98-486F-8BA3-6003D5664105</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The DNS requests.</para>
        /// </summary>
        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public DescribeRecordStatisticsSummaryResponseBodyStatistics Statistics { get; set; }
        public class DescribeRecordStatisticsSummaryResponseBodyStatistics : TeaModel {
            [NameInMap("Statistic")]
            [Validation(Required=false)]
            public List<DescribeRecordStatisticsSummaryResponseBodyStatisticsStatistic> Statistic { get; set; }
            public class DescribeRecordStatisticsSummaryResponseBodyStatisticsStatistic : TeaModel {
                /// <summary>
                /// <para>The number of DNS requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>838711553</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The subdomain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t1.alitest2.com</para>
                /// </summary>
                [NameInMap("SubDomain")]
                [Validation(Required=false)]
                public string SubDomain { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
