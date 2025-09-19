// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListSupportAttackPathAssetRequest : TeaModel {
        /// <summary>
        /// <para>Node type, with values:</para>
        /// <list type="bullet">
        /// <item><description><b>start</b>: Start point.</description></item>
        /// <item><description><b>end</b>: End point.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>end</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// <para>Path name.</para>
        /// <remarks>
        /// <para>You can call <a href="~~ListAvailableAttackPath~~">ListAvailableAttackPath</a> to query the path names.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecs_get_credential_by_create_login_profile</para>
        /// </summary>
        [NameInMap("PathName")]
        [Validation(Required=false)]
        public string PathName { get; set; }

        /// <summary>
        /// <para>Path type.</para>
        /// <remarks>
        /// <para>You can call <a href="~~ListAvailableAttackPath~~">ListAvailableAttackPath</a> to query the path types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>role_escalation</para>
        /// </summary>
        [NameInMap("PathType")]
        [Validation(Required=false)]
        public string PathType { get; set; }

        /// <summary>
        /// <para>Support type, with values:</para>
        /// <list type="bullet">
        /// <item><description><b>event</b>: Attack path alert event.</description></item>
        /// <item><description><b>whitelist</b>: Attack path whitelist.</description></item>
        /// <item><description><b>sensitive</b>: Sensitive assets in the attack path.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>event</para>
        /// </summary>
        [NameInMap("SupportType")]
        [Validation(Required=false)]
        public string SupportType { get; set; }

    }

}
