// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeRecordResolveStatisticsSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. The value starts from 1. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. The maximum value is <b>500</b>. The default value is <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>389DFFA3-77A5-4A9E-BF3D-147C6F98A5BA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of statistics.</para>
        /// </summary>
        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public List<DescribeRecordResolveStatisticsSummaryResponseBodyStatistics> Statistics { get; set; }
        public class DescribeRecordResolveStatisticsSummaryResponseBodyStatistics : TeaModel {
            /// <summary>
            /// <para>The number of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>330</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public string Count { get; set; }

            /// <summary>
            /// <para>The subdomain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The type of the domain name. This parameter is not case-sensitive. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>PUBLIC: an authoritative domain name (default)</para>
            /// </description></item>
            /// <item><description><para>CACHE: an authoritative proxy domain name</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLIC</para>
            /// </summary>
            [NameInMap("DomainType")]
            [Validation(Required=false)]
            public string DomainType { get; set; }

            /// <summary>
            /// <para>The subdomain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.example.com</para>
            /// </summary>
            [NameInMap("SubDomain")]
            [Validation(Required=false)]
            public string SubDomain { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
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
