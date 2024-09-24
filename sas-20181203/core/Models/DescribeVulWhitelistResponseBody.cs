// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulWhitelistResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74F97EF7-B543-43FD-A4E9-18456731F9C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>An array that consists of information about the whitelist of vulnerabilities.</para>
        /// </summary>
        [NameInMap("VulWhitelists")]
        [Validation(Required=false)]
        public List<DescribeVulWhitelistResponseBodyVulWhitelists> VulWhitelists { get; set; }
        public class DescribeVulWhitelistResponseBodyVulWhitelists : TeaModel {
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
            /// <para>The ID of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1275</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

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
            /// <para>ignore</para>
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
            /// <para>If this field is empty, the rule is applied to all assets.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;type&quot;:&quot;GroupId&quot;,&quot;groupIds&quot;:[916****],&quot;uuids&quot;:[]}</para>
            /// </summary>
            [NameInMap("TargetInfo")]
            [Validation(Required=false)]
            public string TargetInfo { get; set; }

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
            /// <para>The information about the vulnerability. The value of this parameter is in the JSON format. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>name</b>: the name of the vulnerability</description></item>
            /// <item><description><b>type</b>: the type of the vulnerability.</description></item>
            /// <item><description><b>aliasName</b>: the alias of the vulnerability</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{
            /// &quot;name&quot;:&quot;oval:com.redhat.rhsa:def:20173263&quot;,
            /// &quot;type&quot;:&quot;cve&quot;,
            /// &quot;aliasName&quot;:&quot;RHSA-2017:3263: curl security update&quot;
            /// }]</para>
            /// </summary>
            [NameInMap("Whitelist")]
            [Validation(Required=false)]
            public string Whitelist { get; set; }

        }

    }

}
