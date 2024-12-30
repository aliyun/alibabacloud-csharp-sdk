// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetVideoPreviewPlayInfoRequest : TeaModel {
        /// <summary>
        /// <para>The preview type. You must enable the corresponding video transcoding feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>live_transcoding: previews a live stream while transcoding is in progress.</description></item>
        /// <item><description>quick_video: previews a video while transcoding is in progress.</description></item>
        /// <item><description>offline_audio: previews a piece of audio after the audio is transcoded offline.</description></item>
        /// <item><description>offline_video: previews a video after the video is transcoded offline.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>live_transcoding</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The drive ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <para>The file ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9520943DC264</para>
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        [NameInMap("get_master_url")]
        [Validation(Required=false)]
        public bool? GetMasterUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether not to query the playback URL. If you set this parameter to true, only transcoding metadata is returned. The video is not transcoded in the TS format, and the playback URL is not returned. If you set this parameter to false, the playback URL is returned. If the video has not been transcoded by using the template specified by template_id, the transcoding process is triggered. You are charged for the value-added service fees generated for transcoding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("get_without_url")]
        [Validation(Required=false)]
        public bool? GetWithoutUrl { get; set; }

        [NameInMap("re_transcode")]
        [Validation(Required=false)]
        public bool? ReTranscode { get; set; }

        /// <summary>
        /// <para>The share ID. If you want to manage a file by using a sharing link, carry the <c>x-share-token</c> header in the request and specify share_id. In this case, <c>drive_id</c> is invalid. Otherwise, use an <c>AccessKey pair</c> or <c>access token</c> for authentication and specify <c>drive_id</c>. You must specify at least either <c>share_id</c> or <c>drive_id</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7JQX1FswpQ8</para>
        /// </summary>
        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        /// <summary>
        /// <para>The ID of the definition template. If you leave this parameter empty, all definition templates are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>264_480p</para>
        /// </summary>
        [NameInMap("template_id")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The validity period of the video preview. Unit: seconds. Default value: 900. Maximum value: 14400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("url_expire_sec")]
        [Validation(Required=false)]
        public long? UrlExpireSec { get; set; }

    }

}
