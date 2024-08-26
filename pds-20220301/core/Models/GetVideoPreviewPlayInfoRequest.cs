// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetVideoPreviewPlayInfoRequest : TeaModel {
        /// <summary>
        /// The preview type. You must enable the corresponding video transcoding feature. Valid values:
        /// 
        /// *   live_transcoding: previews a live stream while transcoding is in progress.
        /// *   quick_video: previews a video while transcoding is in progress.
        /// *   offline_audio: previews a piece of audio after the audio is transcoded offline.
        /// *   offline_video: previews a video after the video is transcoded offline.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The drive ID.
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// The file ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        [NameInMap("get_master_url")]
        [Validation(Required=false)]
        public bool? GetMasterUrl { get; set; }

        /// <summary>
        /// Specifies whether not to query the playback URL. If you set this parameter to true, only transcoding metadata is returned. The video is not transcoded in the TS format, and the playback URL is not returned. If you set this parameter to false, the playback URL is returned. If the video has not been transcoded by using the template specified by template_id, the transcoding process is triggered. You are charged for the value-added service fees generated for transcoding.
        /// </summary>
        [NameInMap("get_without_url")]
        [Validation(Required=false)]
        public bool? GetWithoutUrl { get; set; }

        [NameInMap("re_transcode")]
        [Validation(Required=false)]
        public bool? ReTranscode { get; set; }

        /// <summary>
        /// The share ID. If you want to manage a file by using a sharing link, carry the `x-share-token` header in the request and specify share_id. In this case, `drive_id` is invalid. Otherwise, use an `AccessKey pair` or `access token` for authentication and specify `drive_id`. You must specify at least either `share_id` or `drive_id`.
        /// </summary>
        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        /// <summary>
        /// The ID of the definition template. If you leave this parameter empty, all definition templates are available.
        /// </summary>
        [NameInMap("template_id")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The validity period of the video preview. Unit: seconds. Default value: 900. Maximum value: 14400.
        /// </summary>
        [NameInMap("url_expire_sec")]
        [Validation(Required=false)]
        public long? UrlExpireSec { get; set; }

    }

}
