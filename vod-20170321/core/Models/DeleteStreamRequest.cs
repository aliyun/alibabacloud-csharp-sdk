// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteStreamRequest : TeaModel {
        /// <summary>
        /// The job IDs for deleting media streams.
        /// 
        /// *   Separate multiple IDs with commas (,). A maximum of 20 IDs can be specified for one video.
        /// *   You can obtain job IDs from the PlayInfo parameter that is returned after you call the [GetPlayInfo](~~56124~~) operation. Each media stream has a unique job ID.
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public string JobIds { get; set; }

        /// <summary>
        /// The ID of the video.
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
