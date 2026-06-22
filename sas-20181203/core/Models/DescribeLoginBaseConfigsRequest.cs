// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeLoginBaseConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Settings for paged query. The number of logon configuration entries to display on each page when paging is used. Default value: <b>5</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The selection mode for the assets on which the policy takes effect. This parameter is in JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>Target</b>: The UUID of the server to add or delete, or the ID of the server group.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the targetType parameter is set to uuid, this parameter specifies the UUID of the server. If the targetType parameter is set to groupId, this parameter specifies the ID of the server group. If the targetType parameter is set to global, set this parameter to a hyphen (-).</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>targetType</b>: The selection mode for the assets on which the policy takes effect. Valid values:<list type="bullet">
        /// <item><description><b>uuid</b>: queries by individual server.</description></item>
        /// <item><description><b>groupId</b>: queries by server group.</description></item>
        /// <item><description><b>global</b>: queries all servers.</description></item>
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
        /// <para>The type of logon configuration to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>login_common_location</b>: common logon location.</description></item>
        /// <item><description><b>login_common_ip</b>: common logon IP address.</description></item>
        /// <item><description><b>login_common_time</b>: common logon time.</description></item>
        /// <item><description><b>login_common_account</b>: common logon account.</description></item>
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
