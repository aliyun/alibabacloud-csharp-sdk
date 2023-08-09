// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class DeleteNetworkPathRequest : TeaModel {
        /// <summary>
        /// The IDs of network paths.
        /// </summary>
        [NameInMap("NetworkPathIds")]
        [Validation(Required=false)]
        public List<string> NetworkPathIds { get; set; }

        /// <summary>
        /// The region ID of the network path that you want to delete.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
