// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateImagePipelineResponseBody : TeaModel {
        /// <summary>
        /// The ID of the image template.
        /// </summary>
        [NameInMap("ImagePipelineId")]
        [Validation(Required=false)]
        public string ImagePipelineId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
