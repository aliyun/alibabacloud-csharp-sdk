// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetVulWhitelistResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09969D2C-4FAD-429E-BFBF-9A60DEF8BF6F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the whitelist.</para>
        /// </summary>
        [NameInMap("VulWhitelist")]
        [Validation(Required=false)]
        public GetVulWhitelistResponseBodyVulWhitelist VulWhitelist { get; set; }
        public class GetVulWhitelistResponseBodyVulWhitelist : TeaModel {
            /// <summary>
            /// <para>The alias of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RHSA-2017:3263: curl security update</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>The ID of the whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1275</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oval:com.redhat.rhsa:def:20173263</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The reason why the vulnerability is added to the whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ignore</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The application scope of the rule. The value is a JSON string that contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>type</b>: the type of the assets to which the rule is applied. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Uuid</b>: server</description></item>
            /// <item><description><b>GroupId</b>: server group</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>groupIds</b>: the ID of the server group</para>
            /// </description></item>
            /// <item><description><para><b>uuids</b>: the UUID of the server</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>If this parameter is empty, the rule is applied to all types of assets.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;type&quot;: &quot;GroupId&quot;,
            ///       &quot;uuids&quot;: [],
            ///       &quot;groupIds&quot;: [
            ///             10782678
            ///       ]
            /// }</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <para>The type of the vulnerability.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cve</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The information about the vulnerability that is added to the whitelist. The value is a JSON string that contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Name</b>: the name of the vulnerability.</para>
            /// </description></item>
            /// <item><description><para><b>Type</b>: the type of the vulnerability. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cve</b>: Linux software vulnerability</description></item>
            /// <item><description><b>sys</b>: Windows system vulnerability</description></item>
            /// <item><description><b>cms</b>: Web-CMS vulnerability</description></item>
            /// <item><description><b>app</b>: application vulnerability</description></item>
            /// <item><description><b>emg</b>: urgent vulnerabilities</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>AliasName</b>: the alias of the vulnerability.</para>
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

}
