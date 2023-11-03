// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetDigitalWatermarkExtractResultRequest : TeaModel {
        /// <summary>
        /// The type of the digital watermark. Valid values:
        /// 
        /// *   TraceMark: tracing watermark
        /// *   CopyrightMark: copyright watermark
        /// </summary>
        [NameInMap("ExtractType")]
        [Validation(Required=false)]
        public string ExtractType { get; set; }

        /// <summary>
        /// The ID of the job.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// The ID of the video file. You can query the video ID by using the ApsaraVideo VOD console or calling the SearchMedia operation.
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public string ResourceOwnerId { get; set; }

    }

}
