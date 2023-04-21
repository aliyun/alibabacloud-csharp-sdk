// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateNASFileSystemRequest : TeaModel {
        /// <summary>
        /// The description of the NAS file system.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to encrypt the data in the NAS file system. You can use keys that are managed by Key Management Service (KMS) to encrypt the data that is stored in a NAS file system. When you read and write the encrypted data, the data is automatically decrypted. Valid values:
        /// 
        /// *   0: does not encrypt the data in the NAS file system.
        /// *   1: encrypts the data in the NAS file system by using NAS-managed keys.
        /// 
        /// Default value: 0.
        /// </summary>
        [NameInMap("EncryptType")]
        [Validation(Required=false)]
        public string EncryptType { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the workspace.
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The storage type of the NAS file system. Valid values:
        /// 
        /// *   Capacity
        /// *   Performance
        /// 
        /// Default value: Capacity.
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
