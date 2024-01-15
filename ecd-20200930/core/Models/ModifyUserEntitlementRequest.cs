// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyUserEntitlementRequest : TeaModel {
        /// <summary>
        /// The IDs of the cloud desktops on which you want to grant permissions to users.
        /// </summary>
        [NameInMap("AuthorizeDesktopId")]
        [Validation(Required=false)]
        public List<string> AuthorizeDesktopId { get; set; }

        /// <summary>
        /// The ID of the users.
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public List<string> EndUserId { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The IDs of the cloud desktops on which you want to revoke permissions from users.
        /// </summary>
        [NameInMap("RevokeDesktopId")]
        [Validation(Required=false)]
        public List<string> RevokeDesktopId { get; set; }

    }

}
