// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class SetMemberDeletionPermissionRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the member deletion feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: enables the member deletion feature.</description></item>
        /// <item><description>Disabled: disables the member deletion feature.</description></item>
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
