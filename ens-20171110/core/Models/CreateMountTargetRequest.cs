// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateMountTargetRequest : TeaModel {
        /// <summary>
        /// The ID of the region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// The ID of the file system.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// The name of the mount target.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MountTargetName")]
        [Validation(Required=false)]
        public string MountTargetName { get; set; }

        /// <summary>
        /// The ID of the network.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NetWorkId")]
        [Validation(Required=false)]
        public string NetWorkId { get; set; }

    }

}
