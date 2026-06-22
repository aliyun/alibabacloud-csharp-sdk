// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListSupportAttackPathAssetRequest : TeaModel {
        /// <summary>
        /// <para>The node type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>start</b>: start node.</description></item>
        /// <item><description><b>end</b>: end node.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>end</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// <para>The path name.</para>
        /// <remarks>
        /// <para>Call <a href="~~ListAvailableAttackPath~~">ListAvailableAttackPath</a> to query path names.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecs_get_credential_by_create_login_profile</para>
        /// </summary>
        [NameInMap("PathName")]
        [Validation(Required=false)]
        public string PathName { get; set; }

        /// <summary>
        /// <para>The path type.</para>
        /// <remarks>
        /// <para>Call <a href="~~ListAvailableAttackPath~~">ListAvailableAttackPath</a> to query path types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>role_escalation</para>
        /// </summary>
        [NameInMap("PathType")]
        [Validation(Required=false)]
        public string PathType { get; set; }

        /// <summary>
        /// <para>The support type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>event</b>: attack path alert event.</description></item>
        /// <item><description><b>whitelist</b>: attack path whitelist.</description></item>
        /// <item><description><b>sensitive</b>: attack path sensitive asset.</description></item>
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
