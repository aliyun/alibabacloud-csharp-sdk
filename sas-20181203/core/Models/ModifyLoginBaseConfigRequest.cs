// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyLoginBaseConfigRequest : TeaModel {
        /// <summary>
        /// <para>The detailed configuration of the unusual logon detection rule for the server. This parameter is in JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>totalCount</b>: the total number of assets.</description></item>
        /// <item><description><b>uuidCount</b>: the number of assets on which the rule takes effect.</description></item>
        /// <item><description><b>id</b>: the ID of the unusual logon detection rule.</description></item>
        /// <item><description><b>location</b>: the name of the common logon location.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This field is required only when the Type parameter is set to login_common_location.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>ip</b>: the common logon IP address.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This field is required only when the Type parameter is set to login_common_ip.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>endTime</b>: the end time of the common logon time range.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This field is required only when the Type parameter is set to login_common_time.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>startTime</b>: the start time of the common logon time range.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This field is required only when the Type parameter is set to login_common_time.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>account</b>: the common logon account.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This field is required only when the Type parameter is set to login_common_account.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;totalCount&quot;:174,&quot;uuidCount&quot;:4,&quot;location&quot;:&quot;黑山&quot;,&quot;id&quot;:0}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The configuration of the servers on which the unusual logon detection rule takes effect. This parameter is in JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>Target</b>: the UUID of the server to add or remove.</description></item>
        /// <item><description><b>targetType</b>: the mode for adding assets on which the rule takes effect. Valid values:<list type="bullet">
        /// <item><description><b>uuid</b>: add by individual server.</description></item>
        /// <item><description><b>groupId</b>: add by server group.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>flag</b>: the operation to perform on the asset. Valid values:<list type="bullet">
        /// <item><description><b>del</b>: remove the server from the rule.</description></item>
        /// <item><description><b>add</b>: add the server to the rule.</description></item>
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
        /// <para>The type of unusual logon detection for the server. Valid values:</para>
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
