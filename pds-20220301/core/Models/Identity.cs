// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class Identity : TeaModel {
        /// <summary>
        /// <para>The ID of the user or the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16435bdf934248b788b7b3771ee9a3dw</para>
        /// </summary>
        [NameInMap("identity_id")]
        [Validation(Required=false)]
        public string IdentityId { get; set; }

        /// <summary>
        /// <para>The type of the identity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IT_User</description></item>
        /// <item><description>IT_Group</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IT_User</para>
        /// </summary>
        [NameInMap("identity_type")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

    }

}
