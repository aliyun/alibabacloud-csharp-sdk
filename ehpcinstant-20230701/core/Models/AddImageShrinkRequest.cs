// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class AddImageShrinkRequest : TeaModel {
        [NameInMap("ContainerImageSpec")]
        [Validation(Required=false)]
        public string ContainerImageSpecShrink { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ImageVersion")]
        [Validation(Required=false)]
        public string ImageVersion { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("VMImageSpec")]
        [Validation(Required=false)]
        public string VMImageSpecShrink { get; set; }

    }

}
