// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ProduceEditingProjectVideoRequest : TeaModel {
        /// <summary>
        /// >ApsaraVideo VOD sends a FileUploadComplete event notification after video production is complete, which is similar to the action that is performed after video upload. After the produced video is transcoded, ApsaraVideo VOD sends the StreamTranscodeComplete and TranscodeComplete event notifications.
        /// </summary>
        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// The description of the online editing project.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Produces a video from one or more mezzanine files. You can directly submit mezzanine files by specifying the Timeline parameter. Alternatively, you can submit mezzanine files after you create an online editing project.
        /// </summary>
        [NameInMap("MediaMetadata")]
        [Validation(Required=false)]
        public string MediaMetadata { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// 朴灵
        /// </summary>
        [NameInMap("ProduceConfig")]
        [Validation(Required=false)]
        public string ProduceConfig { get; set; }

        /// <summary>
        /// The thumbnail URL of the online editing project.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the produced video.
        /// 
        /// > *   This operation returns the ID of the produced video in synchronous mode.
        /// > *   If this operation returns the MediaId parameter, the video production task is being asynchronously processed.
        /// </summary>
        [NameInMap("Timeline")]
        [Validation(Required=false)]
        public string Timeline { get; set; }

        /// <summary>
        /// The metadata of the produced video, in JSON format. For more information about the structure, see [MediaMetadata](~~52839~~).
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
