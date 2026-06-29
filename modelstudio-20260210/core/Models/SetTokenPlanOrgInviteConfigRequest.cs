// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class SetTokenPlanOrgInviteConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the organization role assigned by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SYSTEM_ROLE_ORG_ADMIN</description></item>
        /// <item><description>SYSTEM_ROLE_ORG_MEMBER</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ORG_MEMBER</para>
        /// </summary>
        [NameInMap("DefaultRoleId")]
        [Validation(Required=false)]
        public string DefaultRoleId { get; set; }

        /// <summary>
        /// <para>The default seat allocation policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HIGH_TO_LOW</description></item>
        /// <item><description>LOW_TO_HIGH</description></item>
        /// <item><description>NONE</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("SeatAssignStrategy")]
        [Validation(Required=false)]
        public string SeatAssignStrategy { get; set; }

    }

}
