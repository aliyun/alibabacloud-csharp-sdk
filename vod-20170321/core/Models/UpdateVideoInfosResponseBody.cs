// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateVideoInfosResponseBody : TeaModel {
        /// <summary>
        /// The IDs of the videos that cannot be modified. Generally, videos cannot be modified if you do not have required [permissions](~~113600~~).
        /// </summary>
        [NameInMap("ForbiddenVideoIds")]
        [Validation(Required=false)]
        public List<string> ForbiddenVideoIds { get; set; }

        /// <summary>
        /// The IDs of the videos that do not exist.
        /// </summary>
        [NameInMap("NonExistVideoIds")]
        [Validation(Required=false)]
        public List<string> NonExistVideoIds { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
