// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class SummaryImagesInfoResponseBody : TeaModel {
        /// <summary>
        /// The detailed information about the image.
        /// </summary>
        [NameInMap("ImagesInfo")]
        [Validation(Required=false)]
        public string ImagesInfo { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
