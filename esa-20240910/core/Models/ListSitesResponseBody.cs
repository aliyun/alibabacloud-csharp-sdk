// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListSitesResponseBody : TeaModel {
        /// <summary>
        /// <para>Page number of the returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of sites per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List of queried site information.</para>
        /// </summary>
        [NameInMap("Sites")]
        [Validation(Required=false)]
        public List<ListSitesResponseBodySites> Sites { get; set; }
        public class ListSitesResponseBodySites : TeaModel {
            /// <summary>
            /// <para>Site access type. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>NS</b>: Access through NS.</description></item>
            /// <item><description><b>CNAME</b>: Access through CNAME.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NS</para>
            /// </summary>
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// <para>CNAME suffix of the site. For sites accessed via CNAME, this is the CNAME suffix that needs to be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.cname.com</para>
            /// </summary>
            [NameInMap("CnameZone")]
            [Validation(Required=false)]
            public string CnameZone { get; set; }

            /// <summary>
            /// <para>Site acceleration region. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>domestic</b>: China mainland only.</description></item>
            /// <item><description><b>global</b>: Global.</description></item>
            /// <item><description><b>overseas</b>: Global (excluding China mainland).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>domestic</para>
            /// </summary>
            [NameInMap("Coverage")]
            [Validation(Required=false)]
            public string Coverage { get; set; }

            /// <summary>
            /// <para>Site creation time, in ISO8601 format and using UTC time, formatted as yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-24T02:01:11Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the plan instance bound to the site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>onBvtlmIyeXLbiDw81F9</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The list of NS (Name Servers) assigned to the site. Separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>male1-1.ialicdn.com,female1-1.ialicdn.com</para>
            /// </summary>
            [NameInMap("NameServerList")]
            [Validation(Required=false)]
            public string NameServerList { get; set; }

            [NameInMap("OfflineReason")]
            [Validation(Required=false)]
            public string OfflineReason { get; set; }

            /// <summary>
            /// <para>The name of the plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>plan-168656498****</para>
            /// </summary>
            [NameInMap("PlanName")]
            [Validation(Required=false)]
            public string PlanName { get; set; }

            /// <summary>
            /// <para>The specification name of the site\&quot;s plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("PlanSpecName")]
            [Validation(Required=false)]
            public string PlanSpecName { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek26g6i6se6pna</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The site ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789****</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

            /// <summary>
            /// <para>The name of the site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("SiteName")]
            [Validation(Required=false)]
            public string SiteName { get; set; }

            /// <summary>
            /// <para>The status of the site. Possible values:</para>
            /// <list type="bullet">
            /// <item><description><b>pending</b>: The site is pending configuration.</description></item>
            /// <item><description><b>active</b>: The site is active.</description></item>
            /// <item><description><b>offline</b>: The site is offline.</description></item>
            /// <item><description><b>moved</b>: The site has been replaced.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pending</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags of the site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;tag1&quot;:&quot;value1&quot;}</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            /// <summary>
            /// <para>The update time of the site, represented in ISO8601 format and using UTC, formatted as yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-24T02:01:11Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The verification code for site ownership. When the site is accessed via CNAME, this TXT verification code needs to be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>verify_d516cb3740f81f0cef77d162edd1****</para>
            /// </summary>
            [NameInMap("VerifyCode")]
            [Validation(Required=false)]
            public string VerifyCode { get; set; }

            /// <summary>
            /// <para>The visit time of the site, formatted according to ISO8601 and using UTC, in the format yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-24T02:01:11Z</para>
            /// </summary>
            [NameInMap("VisitTime")]
            [Validation(Required=false)]
            public string VisitTime { get; set; }

        }

        /// <summary>
        /// <para>Total number of sites.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
