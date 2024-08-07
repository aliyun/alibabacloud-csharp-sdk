// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitAIJobRequest : TeaModel {
        /// <summary>
        /// The configurations of the AI job. The value is a JSON string.
        /// 
        /// *   If you set `Types` to `AIVideoTag`, you can specify `AnalyseTypes` for `Config` to set the analysis algorithm of a smart tagging job. Valid values:
        /// 
        ///     *   ASR: automatic speech recognition (ASR)
        ///     *   OCR: image optical character recognition (OCR)
        /// 
        /// *   If you set `Types` to `AIMediaDNA`, you can specify `DNADBId` for `Config` to set the ID of the media fingerprint library for video fingerprinting jobs.
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The ID of the video. You can use one of the following methods to obtain the ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD](https://vod.console.aliyun.com) console. In the left-side navigation pane, choose **Media Files** > **Audio/Video**. On the Video and Audio page, view the ID of the audio or video file. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.
        /// *   Obtain the value of VideoId from the response to the [CreateUploadVideo](https://help.aliyun.com/document_detail/55407.html) operation that you call to upload media files.
        /// *   Obtain the value of VideoId from the response to the [SearchMedia](https://help.aliyun.com/document_detail/86044.html) operation after you upload media files.
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

        /// <summary>
        /// The type of the AI job. Separate multiple types with commas (,). Valid values:
        /// 
        /// *   **AIMediaDNA**: The media fingerprinting job.
        /// *   **AIVideoTag**: The smart tagging job.
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public string Types { get; set; }

        /// <summary>
        /// The custom settings. The value is a JSON string. For more information, see [Request parameters](~~86952#h2--userdata-div-id-userdata-div-3~~).
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
