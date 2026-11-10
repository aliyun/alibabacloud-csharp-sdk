// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class RemoveUsersRequest : TeaModel {
        /// <summary>
        /// <para>The business channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("BusinessChannel")]
        [Validation(Required=false)]
        public string BusinessChannel { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically revoke cloud desktop authorization before deleting convenience users. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Asynchronously revokes cloud desktop authorization and deletes convenience users. The API returns the task acceptance result.</description></item>
        /// <item><description>false (default): Synchronously deletes convenience users without automatically revoking cloud desktop authorization. If associated resources prevent deletion, a deletion failure is returned.</description></item>
        /// </list>
        /// <para>When this parameter is set to true, the caller must also have the ecd:ModifyUserEntitlement permission. Task acceptance does not mean that the convenience users have been deleted.</para>
        /// </summary>
        [NameInMap("UnbindDesktops")]
        [Validation(Required=false)]
        public bool? UnbindDesktops { get; set; }

        /// <summary>
        /// <para>The list of usernames of the convenience users to be deleted.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<string> Users { get; set; }

    }

}
