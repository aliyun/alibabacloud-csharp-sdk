// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListCustomImagesRequest : TeaModel {
        /// <summary>
        /// The image tag of the base operating system. The tag is used only by the management node.
        /// </summary>
        [NameInMap("BaseOsTag")]
        [Validation(Required=false)]
        public string BaseOsTag { get; set; }

        /// <summary>
        /// The ID of the cluster where the application resides. If the cluster supports multiple operating systems, all the images in the region where the cluster resides are queried.
        /// 
        /// By default, if you do not specify the cluster ID, the images that are supported by all the clusters is queried.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The source of the image. Valid values:
        /// 
        /// *   self: custom image
        /// *   others: shared image
        /// </summary>
        [NameInMap("ImageOwnerAlias")]
        [Validation(Required=false)]
        public string ImageOwnerAlias { get; set; }

        /// <summary>
        /// Specify the type of the instance. By default, if you do not specify the type of the instance, the list of images that are supported by all the instance types are queried.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

    }

}
