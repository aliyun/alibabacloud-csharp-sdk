// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class ResizeContainerGroupVolumeRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the elastic container instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContainerGroupId")]
        [Validation(Required=false)]
        public string ContainerGroupId { get; set; }

        /// <summary>
        /// The size of the volume after the volume is scaled up. Unit: GiB. Valid values:
        /// 
        /// *   Ultra disk (cloud_efficiency): 20 to 32768
        /// *   Standard SSD (cloud_ssd): 20 to 32768
        /// *   Enhanced SSD (cloud_essd): 20 to 32768
        /// *   Basic disk (cloud): 5 to 2000
        /// 
        /// >  The capacity of the volume after the volume is scaled up must be greater than the original capacity of the volume. If the new capacity is equal to the original capacity of the volume, only the file system is scaled up.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NewSize")]
        [Validation(Required=false)]
        public long? NewSize { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The name of the volume that you want to scale up. The volume must be an Alibaba Cloud disk.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VolumeName")]
        [Validation(Required=false)]
        public string VolumeName { get; set; }

    }

}
