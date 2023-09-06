// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetUserImageRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The type of the image. Set the value to singularity.
        /// </summary>
        [NameInMap("ContainerType")]
        [Validation(Required=false)]
        public string ContainerType { get; set; }

        /// <summary>
        /// The image name.
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// The path where the image is stored in the OSS bucket.
        /// </summary>
        [NameInMap("ImagePath")]
        [Validation(Required=false)]
        public string ImagePath { get; set; }

        /// <summary>
        /// The OSS bucket.
        /// </summary>
        [NameInMap("OSSBucket")]
        [Validation(Required=false)]
        public string OSSBucket { get; set; }

        /// <summary>
        /// The OSS endpoint.
        /// </summary>
        [NameInMap("OSSEndPoint")]
        [Validation(Required=false)]
        public string OSSEndPoint { get; set; }

    }

}
