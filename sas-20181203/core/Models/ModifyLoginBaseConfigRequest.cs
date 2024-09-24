// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyLoginBaseConfigRequest : TeaModel {
        /// <summary>
        /// <para>The details of the configuration that is used to detect unusual logons to your servers. The value of this parameter is in the JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>totalCount</b>: the total number of servers.</description></item>
        /// <item><description><b>uuidCount</b>: the number of servers to which the configuration is applied.</description></item>
        /// <item><description><b>id</b>: the ID of the configuration.</description></item>
        /// <item><description><b>location</b>: the common logon location.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify this field if the Type parameter is set to login_common_location.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>ip</b>: the common logon IP address.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify this field if the Type parameter is set to login_common_ip.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>endTime</b>: the end time of the common logon time range.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify this field if the Type parameter is set to login_common_time.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>startTime</b>: the start time of the common logon time range.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify this field if the Type parameter is set to login_common_time.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>account</b>: the common logon account.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify this field if the Type parameter is set to login_common_account.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;totalCount&quot;:174,&quot;uuidCount&quot;:4,&quot;location&quot;:&quot;Montenegro&quot;,&quot;id&quot;:0}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The details of the server to which the configuration is applied. The value of this parameter is in the JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Target</b>: the UUID of the server.</para>
        /// </description></item>
        /// <item><description><para><b>targetType</b>: the type of the server to which the configuration is applied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>uuid</b>: a server</description></item>
        /// <item><description><b>groupId</b>: a server group</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>flag</b>: the operation that you want to perform on the server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>del</b>: removes the server from the configuration.</description></item>
        /// <item><description><b>add</b>: adds the server to the configuration.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;target&quot;:&quot;inet-7c676676-06fa-442e-90fb-b802e5d6****&quot;,&quot;targetType&quot;:&quot;uuid&quot;,&quot;flag&quot;:&quot;add&quot;}]</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>The logon type of the configuration to modify. Valid values:</para>
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
