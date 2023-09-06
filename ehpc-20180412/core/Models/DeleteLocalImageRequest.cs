// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DeleteLocalImageRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster from which you want to delete the image.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The image type. Set the value to singularity.
        /// </summary>
        [NameInMap("ContainerType")]
        [Validation(Required=false)]
        public string ContainerType { get; set; }

        /// <summary>
        /// The name of the image that you want to delete.
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

    }

}
