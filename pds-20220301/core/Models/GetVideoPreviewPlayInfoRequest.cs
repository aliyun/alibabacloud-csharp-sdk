// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetVideoPreviewPlayInfoRequest : TeaModel {
        /// <summary>
        /// <para>The category. It is the transcoding mode that you want to use. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>live_transcoding: plays a live stream while transcoding is in progress.</description></item>
        /// <item><description>quick_video: plays a video while transcoding is in progress.</description></item>
        /// <item><description>offline_audio: plays a piece of audio after the audio is transcoded offline.</description></item>
        /// <item><description>offline_video: plays a video after the video is transcoded offline.</description></item>
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

        /// <summary>
        /// <para>Specifies whether to obtain the URL of the master M3U8 playlist. This parameter is valid only if the category parameter is set to quick_video.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("get_master_url")]
        [Validation(Required=false)]
        public bool? GetMasterUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether not to query the playback URL. If you set this parameter to true, only transcoding metadata is returned. The video is not transcoded in the TS format, and the playback URL is not returned. If you set this parameter to false, the playback URL is returned. If the video has not been transcoded by using the template specified by template_id, the transcoding process is triggered. You are charged value-added service fees generated for transcoding.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("get_without_url")]
        [Validation(Required=false)]
        public bool? GetWithoutUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to initiate re-transcoding. If you set this parameter to true, the file is re-transcoded, with a fixed 202 response for retries. Before you use this parameter, contact us to enable it for you.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("re_transcode")]
        [Validation(Required=false)]
        public bool? ReTranscode { get; set; }

        /// <summary>
        /// <para>The share ID. If you want to share a file, carry the <c>x-share-token</c> header for authentication in the request and specify share_id. In this case, <c>drive_id</c> is invalid. Otherwise, use an <c>AccessKey pair</c> or <c>access token</c> for authentication and specify <c>drive_id</c>. You must specify one of <c>share_id</c> and <c>drive_id</c>.</para>
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
        /// <para>The validity period of the URL. Unit: seconds. Default value: 900, which is 15 minutes. Maximum value: 14400, which is 4 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("url_expire_sec")]
        [Validation(Required=false)]
        public long? UrlExpireSec { get; set; }

    }

}
