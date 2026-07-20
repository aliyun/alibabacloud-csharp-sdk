// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class RecoverSiteResponseBody : TeaModel {
        /// <summary>
        /// <para>The access type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NS</b>: access through NS hosting.</para>
        /// </description></item>
        /// <item><description><para><b>CNAME</b>: access through CNAME.</para>
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
        /// <para>The CNAME suffix of the site. For sites accessed through CNAME, this is the suffix that needs to be configured for the CNAME record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gf-test.hkrt.cn</para>
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
        /// <para>global</para>
        /// </summary>
        [NameInMap("Coverage")]
        [Validation(Required=false)]
        public string Coverage { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-11T01:23:21Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The plan instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esa-site-9vjienwn****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The list of name servers assigned to the site, separated by commas (,). When the site is accessed through NS, this field contains values. You need to change the DNS servers of the site to these name servers. Then you can verify site ownership and activate the site.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ns1.example.com,ns2.example.com</para>
        /// </summary>
        [NameInMap("NameServerList")]
        [Validation(Required=false)]
        public string NameServerList { get; set; }

        /// <summary>
        /// <para>The reason why the site was disabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>expiration_ arrears</b>: the subscription plan expired or the account has an overdue payment.</description></item>
        /// <item><description><b>internally_disabled</b>: disabled by the system internally.</description></item>
        /// <item><description><b>missing_icp</b>: the domain name lacks an ICP filing.</description></item>
        /// <item><description><b>content_violation</b>: content violation.</description></item>
        /// <item><description><b>proactively_disabled</b>: you proactively disabled the site or the site was disabled due to the usage cap you configured.</description></item>
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
        /// <para>basic</para>
        /// </summary>
        [NameInMap("PlanName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AEDAF20-4DDF-4165-8750-47FF9C1929C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-axxxxxx</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The site ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
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
        /// <para>active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-13T02:13:28Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The site ownership verification code. When the site is accessed through CNAME, this is the TXT verification code that needs to be configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>verify_d516cb3740f81f0cef77d162edd1****</para>
        /// </summary>
        [NameInMap("VerifyCode")]
        [Validation(Required=false)]
        public string VerifyCode { get; set; }

    }

}
