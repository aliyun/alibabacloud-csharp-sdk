// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class DeleteNetworkPathShrinkRequest : TeaModel {
        /// <summary>
        /// The IDs of network paths.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NetworkPathIds")]
        [Validation(Required=false)]
        public string NetworkPathIdsShrink { get; set; }

        /// <summary>
        /// The region ID of the network path that you want to delete.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
