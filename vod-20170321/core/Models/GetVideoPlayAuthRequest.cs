// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoPlayAuthRequest : TeaModel {
        /// <summary>
        /// The API version. Set the value to **1.0.0**.
        /// </summary>
        [NameInMap("ApiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// The validity period of the playback credential. Unit: **seconds**. You cannot obtain the playback URL of a video by using a credential that has expired. A new credential is required.
        /// 
        /// *   Default value: **100**.
        /// *   Valid values: `[100,3000]`.
        /// </summary>
        [NameInMap("AuthInfoTimeout")]
        [Validation(Required=false)]
        public long? AuthInfoTimeout { get; set; }

        /// <summary>
        /// The ID of the media file. You can specify only one ID. You can use one of the following methods to obtain the ID of the file:
        /// 
        /// *   Log on to the [ApsaraVideo VOD](https://vod.console.aliyun.com) console. In the left-side navigation pane, choose **Media Files** > **Audio/Video**. On the Video and Audio page, view the ID of the media file. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.
        /// *   Obtain the value of the VideoId parameter from the response to the [CreateUploadVideo](~~55407~~) operation.
        /// *   Obtain the value of the VideoId parameter from the response to the [SearchMedia](~~86044~~) operation. This method is applicable to files that have been uploaded.
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
