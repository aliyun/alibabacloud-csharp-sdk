// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class InspectImageRequest : TeaModel {
        /// <summary>
        /// The ID of the E-HPC cluster where the image whose Inspect information you want to view resides.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The container type of the image. Set the value to singularity.
        /// </summary>
        [NameInMap("ContainerType")]
        [Validation(Required=false)]
        public string ContainerType { get; set; }

        /// <summary>
        /// The name of the image whose Inspect information you want to view.
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

    }

}
