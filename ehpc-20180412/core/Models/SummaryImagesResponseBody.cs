// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class SummaryImagesResponseBody : TeaModel {
        /// <summary>
        /// The names of all images in the cluster.
        /// </summary>
        [NameInMap("ImagesName")]
        [Validation(Required=false)]
        public string ImagesName { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
