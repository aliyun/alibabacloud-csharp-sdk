// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ExportImageRequest : TeaModel {
        /// <summary>
        /// The format in which you want to export the custom image. Valid values:
        /// 
        /// *   raw
        /// *   vhd
        /// *   qcow2
        /// *   vmdk
        /// *   vdi
        /// 
        /// Default value: raw.
        /// </summary>
        [NameInMap("ImageFormat")]
        [Validation(Required=false)]
        public string ImageFormat { get; set; }

        /// <summary>
        /// The custom image ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The OSS bucket in which you want to store the exported custom image.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OSSBucket")]
        [Validation(Required=false)]
        public string OSSBucket { get; set; }

        /// <summary>
        /// The prefix for the name of the OSS object. The prefix must be 1 to 30 characters in length and can contain digits and letters.
        /// </summary>
        [NameInMap("OSSPrefix")]
        [Validation(Required=false)]
        public string OSSPrefix { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the custom image. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
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
        /// The name of the RAM role that you want to use to export the custom image.
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

    }

}
