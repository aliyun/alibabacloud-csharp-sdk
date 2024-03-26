// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteMezzaninesResponseBody : TeaModel {
        /// <summary>
        /// The IDs of the audio or video files that do not exist.
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

        /// <summary>
        /// The IDs of the audio or video files whose source files cannot be deleted.
        /// 
        /// >  In most cases, source files cannot be deleted if they are used for original-quality playback or you do not have required permissions to delete them. For more information, see [Overview](~~113600~~).
        /// </summary>
        [NameInMap("UnRemoveableVideoIds")]
        [Validation(Required=false)]
        public List<string> UnRemoveableVideoIds { get; set; }

    }

}
