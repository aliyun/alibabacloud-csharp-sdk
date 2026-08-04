// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateUsersStatusRequest : TeaModel {
        /// <summary>
        /// <para>Collection of user IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SaseUserIds")]
        [Validation(Required=false)]
        public List<string> SaseUserIds { get; set; }

        /// <summary>
        /// <para>User status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Enabled</b>: Enable the user.</para>
        /// </description></item>
        /// <item><description><para><b>Disabled</b>: Disable the user.</para>
        /// </description></item>
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
