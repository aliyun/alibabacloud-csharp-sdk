// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListSitesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of sites displayed per page.</para>
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
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of queried site information.</para>
        /// </summary>
        [NameInMap("Sites")]
        [Validation(Required=false)]
        public List<ListSitesResponseBodySites> Sites { get; set; }
        public class ListSitesResponseBodySites : TeaModel {
            /// <summary>
            /// <para>The site access type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NS</b>: NS-based access.</description></item>
            /// <item><description><b>CNAME</b>: CNAME-based access.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NS</para>
            /// </summary>
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// <para>The CNAME suffix of the site. For sites that use CNAME-based access, this is the CNAME suffix that needs to be configured for records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.cname.com</para>
            /// </summary>
            [NameInMap("CnameZone")]
            [Validation(Required=false)]
            public string CnameZone { get; set; }

            /// <summary>
            /// <para>The acceleration region of the site. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>domestic</b>: the Chinese mainland only.</description></item>
            /// <item><description><b>global</b>: global.</description></item>
            /// <item><description><b>overseas</b>: global (excluding the Chinese mainland).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>domestic</para>
            /// </summary>
            [NameInMap("Coverage")]
            [Validation(Required=false)]
            public string Coverage { get; set; }

            /// <summary>
            /// <para>The creation time of the site. The time is in ISO 8601 format and displayed in UTC. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-24T02:01:11Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The instance ID of the plan attached to the site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>onBvtlmIyeXLbiDw81F9</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The list of name servers assigned to the site. Multiple values are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>male1-1.ialicdn.com,female1-1.ialicdn.com</para>
            /// </summary>
            [NameInMap("NameServerList")]
            [Validation(Required=false)]
            public string NameServerList { get; set; }

            /// <summary>
            /// <para>The reason why the site is disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>expiration_ arrears</b>: The subscription plan has expired or the account has an overdue payment.</description></item>
            /// <item><description><b>internally_disabled</b>: The site is disabled by the system.</description></item>
            /// <item><description><b>missing_icp</b>: The domain name does not have an ICP filing.</description></item>
            /// <item><description><b>content_violation</b>: Content violation.</description></item>
            /// <item><description><b>proactively_disabled</b>: You proactively disabled the site or the site is disabled because the usage cap you configured is reached.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>expiration_ arrears</para>
            /// </summary>
            [NameInMap("OfflineReason")]
            [Validation(Required=false)]
            public string OfflineReason { get; set; }

            /// <summary>
            /// <para>The plan name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>plan-168656498****</para>
            /// </summary>
            [NameInMap("PlanName")]
            [Validation(Required=false)]
            public string PlanName { get; set; }

            /// <summary>
            /// <para>The specification name of the site plan.</para>
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
            /// <para>The site name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("SiteName")]
            [Validation(Required=false)]
            public string SiteName { get; set; }

            /// <summary>
            /// <para>The site status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pending</b>: the site is pending configuration.</description></item>
            /// <item><description><b>active</b>: the site is activated.</description></item>
            /// <item><description><b>offline</b>: the site is offline.</description></item>
            /// <item><description><b>moved</b>: the site has been superseded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pending</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The site tags.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;tag1&quot;:&quot;value1&quot;}</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            /// <summary>
            /// <para>The update time of the site. The time is in ISO 8601 format and displayed in UTC. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-24T02:01:11Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The site ownership verification code. When a site uses CNAME-based access, this TXT verification code must be configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>verify_d516cb3740f81f0cef77d162edd1****</para>
            /// </summary>
            [NameInMap("VerifyCode")]
            [Validation(Required=false)]
            public string VerifyCode { get; set; }

            /// <summary>
            /// <para>The access time of the site. The time is in ISO 8601 format and displayed in UTC. Format: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-24T02:01:11Z</para>
            /// </summary>
            [NameInMap("VisitTime")]
            [Validation(Required=false)]
            public string VisitTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of sites.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
