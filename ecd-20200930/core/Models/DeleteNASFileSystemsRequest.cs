// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DeleteNASFileSystemsRequest : TeaModel {
        /// <summary>
        /// The IDs of the NAS file systems that you want to delete.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public List<string> FileSystemId { get; set; }

        /// <summary>
        /// The region ID of the NAS file system that you want to delete.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
