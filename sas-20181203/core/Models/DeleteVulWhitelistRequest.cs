// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteVulWhitelistRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the vulnerability whitelist.</para>
        /// <remarks>
        /// <para>To delete a vulnerability whitelist, provide the vulnerability whitelist ID. You can obtain this ID by calling the <a href="~~DescribeVulWhitelist~~">DescribeVulWhitelist</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>131231</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The vulnerability whitelist information to delete. The value is a JSON string that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Name</b>: The name of the vulnerability.</para>
        /// </description></item>
        /// <item><description><para><b>Type</b>: The type of the vulnerability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: Linux software vulnerability</description></item>
        /// <item><description><b>sys</b>: Windows system vulnerability</description></item>
        /// <item><description><b>cms</b>: Web-CMS vulnerability</description></item>
        /// <item><description><b>app</b>: application vulnerability</description></item>
        /// <item><description><b>emg</b>: emergency vulnerability</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>AliasName</b>: The alias of the vulnerability.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///       {
        ///             &quot;Name&quot;: &quot;oval:com.redhat.rhsa:def:20173263&quot;,
        ///             &quot;Type&quot;: &quot;cve&quot;,
        ///             &quot;AliasName&quot;: &quot;RHSA-2017:3263: curl security update&quot;
        ///       }
        /// ]</para>
        /// </summary>
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public string Whitelist { get; set; }

    }

}
