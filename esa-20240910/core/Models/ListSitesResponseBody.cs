// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListSitesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of websites per page.</para>
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
        /// <para>The queried websites.</para>
        /// </summary>
        [NameInMap("Sites")]
        [Validation(Required=false)]
        public List<ListSitesResponseBodySites> Sites { get; set; }
        public class ListSitesResponseBodySites : TeaModel {
            /// <summary>
            /// <para>The DNS setup for the website. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NS</b></description></item>
            /// <item><description><b>CNAME</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NS</para>
            /// </summary>
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// <para>The CNAME of the website domain. If you use CNAME setup when you add your website to ESA, the value is the CNAME that you configured then.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.cname.com</para>
            /// </summary>
            [NameInMap("CnameZone")]
            [Validation(Required=false)]
            public string CnameZone { get; set; }

            /// <summary>
            /// <para>The service location for the website. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>domestic</b>: the Chinese mainland</description></item>
            /// <item><description><b>global</b>: global</description></item>
            /// <item><description><b>overseas</b>: outside the Chinese mainland</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>domestic</para>
            /// </summary>
            [NameInMap("Coverage")]
            [Validation(Required=false)]
            public string Coverage { get; set; }

            /// <summary>
            /// <para>The time when the website was added. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-24T02:01:11Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the plan associated with the website.</para>
            /// 
            /// <b>Example:</b>
            /// <para>onBvtlmIyeXLbiDw81F9</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The nameservers assigned to the website domain, which are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>male1-1.ialicdn.com,female1-1.ialicdn.com</para>
            /// </summary>
            [NameInMap("NameServerList")]
            [Validation(Required=false)]
            public string NameServerList { get; set; }

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
            /// <para>The plan associated with the website.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("PlanSpecName")]
            [Validation(Required=false)]
            public string PlanSpecName { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek26g6i6se6pna</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The website ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789****</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

            /// <summary>
            /// <para>The website name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("SiteName")]
            [Validation(Required=false)]
            public string SiteName { get; set; }

            /// <summary>
            /// <para>The website status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pending</b>: The website is to be configured.</description></item>
            /// <item><description><b>active</b>: The website is active.</description></item>
            /// <item><description><b>offline</b>: The website is suspended.</description></item>
            /// <item><description><b>moved</b>: The website has been added and verified by another Alibaba Cloud account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pending</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags of the website.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;tag1&quot;:&quot;value1&quot;}</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            /// <summary>
            /// <para>The time when the website was updated. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-24T02:01:11Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The code that is used to verify the website domain ownership. As part of the verification TXT record, this parameter is returned for websites that use CNAME setup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>verify_d516cb3740f81f0cef77d162edd1****</para>
            /// </summary>
            [NameInMap("VerifyCode")]
            [Validation(Required=false)]
            public string VerifyCode { get; set; }

            /// <summary>
            /// <para>null</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-24T02:01:11Z</para>
            /// </summary>
            [NameInMap("VisitTime")]
            [Validation(Required=false)]
            public string VisitTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of websites.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
