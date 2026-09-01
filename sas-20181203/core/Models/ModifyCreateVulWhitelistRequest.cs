// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyCreateVulWhitelistRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Different requests must use different tokens. The token supports only ASCII characters and cannot exceed 64 characters in length.</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The reason for adding the vulnerability to the whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This vulnerability is not harmful</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The scope in which the whitelist takes effect. The value is a JSON string that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>type</b>: The scope type. Valid values:<list type="bullet">
        /// <item><description><b>GroupId</b>: server group</description></item>
        /// <item><description><b>Uuid</b>: host asset</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>uuids</b>: The collection of host asset UUIDs. The field type is String.</description></item>
        /// <item><description><b>groupIds</b>: The collection of server group IDs. The field type is Long.<remarks>
        /// <para>If this parameter is left empty, the whitelist takes effect on all hosts. If <b>type</b> is set to <b>GroupId</b>, <b>groupIds</b> cannot be empty. If <b>type</b> is set to <b>Uuid</b>, <b>uuids</b> cannot be empty.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;Uuid&quot;,&quot;uuids&quot;:[&quot;b31a708f-5fea-426e-bebe-a7b0893****&quot;,&quot;1f749687-3b5d-4e11-8140-d964673****&quot;],&quot;groupIds&quot;:[]}</para>
        /// </summary>
        [NameInMap("TargetInfo")]
        [Validation(Required=false)]
        public string TargetInfo { get; set; }

        /// <summary>
        /// <para>The information about the vulnerability to add to the whitelist. The value is a JSON string that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Status</b>: The vulnerability status.</para>
        /// </description></item>
        /// <item><description><para><b>GmtLast</b>: The timestamp when the vulnerability was last detected. Unit: milliseconds.</para>
        /// </description></item>
        /// <item><description><para><b>LaterCount</b>: The number of medium-priority vulnerabilities.</para>
        /// </description></item>
        /// <item><description><para><b>AsapCount</b>: The number of high-priority vulnerabilities.</para>
        /// </description></item>
        /// <item><description><para><b>Name</b>: The vulnerability name.</para>
        /// </description></item>
        /// <item><description><para><b>Type</b>: The vulnerability type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: Linux software vulnerability</description></item>
        /// <item><description><b>sys</b>: Windows system vulnerability</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerability</description></item>
        /// <item><description><b>app</b>: application vulnerability</description></item>
        /// <item><description><b>emg</b>: emergency vulnerability</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>Related</b>: The CVE ID of the vulnerability.</para>
        /// </description></item>
        /// <item><description><para><b>HandledCount</b>: The number of handled vulnerabilities.</para>
        /// </description></item>
        /// <item><description><para><b>AliasName</b>: The alias of the vulnerability.</para>
        /// </description></item>
        /// <item><description><para><b>RuleModifyTime</b>: The time when the vulnerability was last published.</para>
        /// </description></item>
        /// <item><description><para><b>NntfCount</b>: The number of low-priority vulnerabilities.</para>
        /// </description></item>
        /// <item><description><para><b>TotalFixCount</b>: The total number of fixed vulnerabilities.</para>
        /// </description></item>
        /// <item><description><para><b>Tags</b>: The vulnerability tags.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeGroupedVul~~">DescribeGroupedVul</a> operation to obtain the vulnerability information to add to the whitelist.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Status&quot;:0,&quot;GmtLast&quot;:1662281929000,&quot;LaterCount&quot;:0,&quot;AsapCount&quot;:1,&quot;Name&quot;:&quot;oval:com.redhat.rhsa:def:20172836&quot;,&quot;Type&quot;:&quot;cve&quot;,&quot;Related&quot;:&quot;CVE-2017-14491,CVE-2017-14492,CVE-2017-14493,CVE-2017-14494,CVE-2017-14495,CVE-2017-14496&quot;,&quot;HandledCount&quot;:1,&quot;AliasName&quot;:&quot;RHSA-2017:2836-Critical: dnsmasq security update&quot;,&quot;RuleModifyTime&quot;:1535542395000,&quot;NntfCount&quot;:0,&quot;TotalFixCount&quot;:196668,&quot;Tags&quot;:&quot;Exploit Exists,Code Execution&quot;},{&quot;Status&quot;:0,&quot;GmtLast&quot;:1662281933000,&quot;LaterCount&quot;:0,&quot;AsapCount&quot;:1,&quot;Name&quot;:&quot;oval:com.redhat.rhsa:def:20173075&quot;,&quot;Type&quot;:&quot;cve&quot;,&quot;Related&quot;:&quot;CVE-2017-13089,CVE-2017-13090&quot;,&quot;HandledCount&quot;:1,&quot;AliasName&quot;:&quot;RHSA-2017:3075-Important: wget security update&quot;,&quot;RuleModifyTime&quot;:1551432867000,&quot;NntfCount&quot;:0,&quot;TotalFixCount&quot;:369136,&quot;Tags&quot;:&quot;Code Execution&quot;}]</para>
        /// </summary>
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public string Whitelist { get; set; }

    }

}
