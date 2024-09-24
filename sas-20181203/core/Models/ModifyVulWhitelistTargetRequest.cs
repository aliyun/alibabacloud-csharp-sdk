// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyVulWhitelistTargetRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the whitelist.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeVulWhitelist~~">DescribeVulWhitelist</a> operation to query the IDs of whitelists.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2533681</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The reason why you add the server to the whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1221</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42.120.75.150</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

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
        /// <para> If you leave this parameter empty, all servers are added to the whitelist. If you set the <b>type</b> field to <b>GroupId</b>, you must also specify the <b>groupIds</b> field. If you set the <b>type</b> field to <b>Uuid</b>, you must also specify the <b>uuids</b> field.</para>
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
        [NameInMap("TargetInfo")]
        [Validation(Required=false)]
        public string TargetInfo { get; set; }

    }

}
