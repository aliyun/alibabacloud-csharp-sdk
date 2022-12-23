// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitPreprocessJobsRequest : TeaModel {
        /// <summary>
        /// The preprocessing type. Set the value to **LivePreprocess**, which indicates that the video is preprocessed in the production studio.
        /// </summary>
        [NameInMap("PreprocessType")]
        [Validation(Required=false)]
        public string PreprocessType { get; set; }

        /// <summary>
        /// The ID of the video.
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
