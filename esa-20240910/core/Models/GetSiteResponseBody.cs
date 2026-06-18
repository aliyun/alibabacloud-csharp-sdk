// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetSiteResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9732E117-8A37-49FD-A36F-ABBB87556CA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the site.</para>
        /// </summary>
        [NameInMap("SiteModel")]
        [Validation(Required=false)]
        public GetSiteResponseBodySiteModel SiteModel { get; set; }
        public class GetSiteResponseBodySiteModel : TeaModel {
            /// <summary>
            /// <para>The access type of the site. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>NS</b>: Access via NS.</para>
            /// </description></item>
            /// <item><description><para><b>CNAME</b>: Access via CNAME.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NS</para>
            /// </summary>
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// <para>For sites onboarded via CNAME, use this suffix to configure the CNAME record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.cname.com</para>
            /// </summary>
            [NameInMap("CnameZone")]
            [Validation(Required=false)]
            public string CnameZone { get; set; }

            /// <summary>
            /// <para>The acceleration region. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>domestic</b>: Chinese mainland only</para>
            /// </description></item>
            /// <item><description><para><b>global</b>: Global</para>
            /// </description></item>
            /// <item><description><para><b>overseas</b>: Global (excluding the Chinese mainland)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>domestic</para>
            /// </summary>
            [NameInMap("Coverage")]
            [Validation(Required=false)]
            public string Coverage { get; set; }

            /// <summary>
            /// <para>The time (in UTC) when the site was created, formatted in ISO 8601 (<c>yyyy-MM-ddTHH:mm:ssZ</c>).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-24T02:01:11Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the plan instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cas-merge-q6h0bv</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>A comma-separated list of name servers assigned to the site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>male1-1.ialicdn.com,female1-1.ialicdn.com</para>
            /// </summary>
            [NameInMap("NameServerList")]
            [Validation(Required=false)]
            public string NameServerList { get; set; }

            /// <summary>
            /// <para>The reason the site is offline. This parameter appears only when <c>Status</c> is <c>offline</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>expiration_arrears</b>: The subscription plan has expired or the account has overdue payments.</para>
            /// </description></item>
            /// <item><description><para><b>internally_disabled</b>: The site was disabled by the system.</para>
            /// </description></item>
            /// <item><description><para><b>missing_icp</b>: The domain is missing an ICP license.</para>
            /// </description></item>
            /// <item><description><para><b>content_violation</b>: The site violated content policies.</para>
            /// </description></item>
            /// <item><description><para><b>proactively_disabled</b>: The site was disabled either by you or by a usage limit that you configured.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>expiration_ arrears</para>
            /// </summary>
            [NameInMap("OfflineReason")]
            [Validation(Required=false)]
            public string OfflineReason { get; set; }

            /// <summary>
            /// <para>The name of the plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>plan-168777532****</para>
            /// </summary>
            [NameInMap("PlanName")]
            [Validation(Required=false)]
            public string PlanName { get; set; }

            /// <summary>
            /// <para>The name of the plan specification.</para>
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
            /// <para>rg-aek26g6i6se****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890123</para>
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
            /// <para>The status of the site. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>pending</b>: The site is pending configuration.</para>
            /// </description></item>
            /// <item><description><para><b>active</b>: The site is active.</para>
            /// </description></item>
            /// <item><description><para><b>offline</b>: The site is offline.</para>
            /// </description></item>
            /// <item><description><para><b>moved</b>: The site has been superseded.</para>
            /// </description></item>
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
            /// <para>The time (in UTC) when the site was last updated, formatted in ISO 8601 (<c>yyyy-MM-ddTHH:mm:ssZ</c>).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-24T02:01:11Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>Each key is a custom name server, and its value is a comma-separated list of the server\&quot;s IP addresses.</para>
            /// </summary>
            [NameInMap("VanityNSList")]
            [Validation(Required=false)]
            public Dictionary<string, string> VanityNSList { get; set; }

            /// <summary>
            /// <para>For sites onboarded via CNAME, you must configure this code as a TXT record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>verify_d516cb3740f81f0cef77d162edd1****</para>
            /// </summary>
            [NameInMap("VerifyCode")]
            [Validation(Required=false)]
            public string VerifyCode { get; set; }

            /// <summary>
            /// <para>If <c>true</c>, version management is enabled for the site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("VersionManagement")]
            [Validation(Required=false)]
            public bool? VersionManagement { get; set; }

        }

    }

}
