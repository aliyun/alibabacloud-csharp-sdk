// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ProduceEditingProjectVideoResponseBody : TeaModel {
        /// <summary>
        /// The ID of the produced video.
        /// 
        /// > *   This parameter is returned for each request.
        /// > *   If a value is returned for this parameter, the video production task is being asynchronously processed.
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// The ID of the online editing project.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
