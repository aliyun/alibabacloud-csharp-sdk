// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateImageRequest : TeaModel {
        /// <summary>
        /// Specifies whether to automatically release the instance after the image is packaged and uploaded. Only image builders are supported. Default value: false. Valid values:
        /// 
        /// *   true: The image is released when the instance is released.
        /// *   false: The image is retained when the instance is released.
        /// *   If you leave this parameter empty, the default value is used.
        /// </summary>
        [NameInMap("DeleteAfterImageUpload")]
        [Validation(Required=false)]
        public string DeleteAfterImageUpload { get; set; }

        /// <summary>
        /// The name of the image. The name must be 2 to 128 characters in length. The name can contain letters, digits, colons (:), underscores (\_), and hyphens (-). It must start with a letter but cannot start with `http://` or `https://`. The name can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the snapshot.
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

    }

}
