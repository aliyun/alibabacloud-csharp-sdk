// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class SummaryImagesRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
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

    }

}
