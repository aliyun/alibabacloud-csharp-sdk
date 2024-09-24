// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyCreateVulWhitelistRequest : TeaModel {
        /// <summary>
        /// <para>The reason why you add the vulnerability to the whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This vulnerability is not harmful</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The applicable scope of the whitelist. The value of this parameter is in the JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>type</b>: the type of the applicable scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>GroupId</b>: the ID of a server group</description></item>
        /// <item><description><b>Uuid</b>: the UUID of a server</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>uuids</b>: the UUIDs of servers</para>
        /// </description></item>
        /// <item><description><para><b>groupIds</b>: the IDs of server groups</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> If you leave this parameter empty, all servers are added to the whitelist. If you set the <b>type</b> field to <b>GroupId</b>, you must also specify the <b>groupIds</b> field. If you set <b>type</b> to <b>Uuid</b>, you must specify the <b>uuids</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;GroupId&quot;,&quot;uuids&quot;:[],&quot;groupIds&quot;:[10782678]}</para>
        /// </summary>
        [NameInMap("TargetInfo")]
        [Validation(Required=false)]
        public string TargetInfo { get; set; }

        /// <summary>
        /// <para>The information about the vulnerability that you want to add to the whitelist. The value is a JSON string that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Status</b>: the status of the vulnerability.</para>
        /// </description></item>
        /// <item><description><para><b>GmtLast</b>: the timestamp when the vulnerability was last detected. Unit: milliseconds.</para>
        /// </description></item>
        /// <item><description><para><b>LaterCount</b>: the number of vulnerabilities that have the medium priority.</para>
        /// </description></item>
        /// <item><description><para><b>AsapCount</b>: the number of vulnerabilities that have the high priority.</para>
        /// </description></item>
        /// <item><description><para><b>Name</b>: the name of the vulnerability.</para>
        /// </description></item>
        /// <item><description><para><b>Type</b>: the type of the vulnerability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: Linux software vulnerability</description></item>
        /// <item><description><b>sys</b>: Windows system vulnerability</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerability</description></item>
        /// <item><description><b>app</b>: application vulnerability</description></item>
        /// <item><description><b>emg</b>: urgent vulnerability</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>Related</b>: the Common Vulnerabilities and Exposures (CVE) ID of the vulnerability.</para>
        /// </description></item>
        /// <item><description><para><b>HandledCount</b>: the number of handled vulnerabilities.</para>
        /// </description></item>
        /// <item><description><para><b>AliasName</b>: the alias of the vulnerability.</para>
        /// </description></item>
        /// <item><description><para><b>RuleModifyTime</b>: the time when the vulnerability was last disclosed.</para>
        /// </description></item>
        /// <item><description><para><b>NntfCount</b>: the number of vulnerabilities that have the low priority.</para>
        /// </description></item>
        /// <item><description><para><b>TotalFixCount</b>: the total number of fixed vulnerabilities.</para>
        /// </description></item>
        /// <item><description><para><b>Tags</b>: the tag that is added to the vulnerability.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeGroupedVul~~">DescribeGroupedVul</a> operation to query the information about the vulnerability that you want to add to the whitelist.</para>
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
