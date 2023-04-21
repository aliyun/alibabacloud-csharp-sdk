// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyUserToDesktopGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the desktop group that you want to assign to users.
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// The IDs of the regular users to whom you want to grant the permissions on the cloud desktop.
        /// </summary>
        [NameInMap("NewEndUserIds")]
        [Validation(Required=false)]
        public List<string> NewEndUserIds { get; set; }

        /// <summary>
        /// The IDs of the original regular users who have the permissions on the cloud desktop.
        /// </summary>
        [NameInMap("OldEndUserIds")]
        [Validation(Required=false)]
        public List<string> OldEndUserIds { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
