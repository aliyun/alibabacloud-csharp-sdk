// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeLoginBaseConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>5</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The server to which the configuration is applied. The value of this parameter is in the JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>Target</b>: the UUID or group ID of the server to add or delete.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If targetType is set to uuid, the value of Target is the UUID of the server. If targetType is set to groupId, the value of Target is the group ID of the server. If targetType is set to global, the value of Target is a hyphen (-).</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para><b>targetType</b>: the type of the server to which the configuration is applied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>uuid</b>: a server</description></item>
        /// <item><description><b>groupId</b>: a server group</description></item>
        /// <item><description><b>global</b>: all servers</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[ {&quot;target&quot;: &quot;inet-7c676676-06fa-442e-90fb-b802e5d6****&quot;, &quot;targetType&quot;: &quot;uuid&quot; } ]</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>The logon type of the configuration to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>login_common_location</b>: common logon location</description></item>
        /// <item><description><b>login_common_ip</b>: common logon IP address</description></item>
        /// <item><description><b>login_common_time</b>: common logon time range</description></item>
        /// <item><description><b>login_common_account</b>: common logon account</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>login_common_location</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
