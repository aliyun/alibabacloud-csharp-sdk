// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetVideoPreviewPlayMetaRequest : TeaModel {
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

        /// <summary>
        /// <para>The share ID. If you want to manage a file by using a sharing link, carry the <c>x-share-token</c> header in the request and specify share_id. In this case, <c>drive_id</c> is invalid. Otherwise, use an <c>AccessKey pair</c> or <c>access token</c> for authentication and specify <c>drive_id</c>. You must specify at least either <c>share_id</c> or <c>drive_id</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7JQX1FswpQ8</para>
        /// </summary>
        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

    }

}
