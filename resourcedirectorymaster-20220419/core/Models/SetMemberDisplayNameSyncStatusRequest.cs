// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class SetMemberDisplayNameSyncStatusRequest : TeaModel {
        /// <summary>
        /// <para>The status of the Member Display Name Synchronization feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: The feature is enabled. This indicates that the display names specified by the management account for the members will be synchronized to the basic account information of the members. The display name information will be visible and perceptible to the members. If a notification is sent to a member, the display name of the member will be used as the appellation of the member.</description></item>
        /// <item><description>Disabled: The feature is disabled. This indicates that the display names specified by the management account for the members are valid only in the resource directory and will not be updated to the basic account information of the members.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
