// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class InstallAddonRequest : TeaModel {
        /// <summary>
        /// The addon name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AddonName")]
        [Validation(Required=false)]
        public string AddonName { get; set; }

        /// <summary>
        /// The addon version.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AddonVersion")]
        [Validation(Required=false)]
        public string AddonVersion { get; set; }

        /// <summary>
        /// The cluster ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The resource configurations of the addon.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourcesSpec")]
        [Validation(Required=false)]
        public string ResourcesSpec { get; set; }

        /// <summary>
        /// The service configurations of the addon.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServicesSpec")]
        [Validation(Required=false)]
        public string ServicesSpec { get; set; }

    }

}
