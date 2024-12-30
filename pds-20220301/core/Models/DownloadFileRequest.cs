// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class DownloadFileRequest : TeaModel {
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
        /// <para>The method used to generate the thumbnail of an image. If this parameter is specified, you are redirected to the URL of the generated thumbnail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image/resize,m_fill,h_128,w_128,limit_0</para>
        /// </summary>
        [NameInMap("image_thumbnail_process")]
        [Validation(Required=false)]
        public string ImageThumbnailProcess { get; set; }

        /// <summary>
        /// <para>The method used to generate the thumbnail of a document. If this parameter is specified, you are redirected to the URL of the generated thumbnail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image/resize,w_200</para>
        /// </summary>
        [NameInMap("office_thumbnail_process")]
        [Validation(Required=false)]
        public string OfficeThumbnailProcess { get; set; }

        /// <summary>
        /// <para>The share ID. If you want to manage a file by using a share link, carry the <c>x-share-token</c> header for authentication in the request and specify share_id. In this case, <c>drive_id</c> is invalid. Otherwise, use an <c>AccessKey pair</c> or <c>access token</c> for authentication and specify <c>drive_id</c>. You must specify one of <c>share_id</c> and <c>drive_id</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7JQX1FswpQ8</para>
        /// </summary>
        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        /// <summary>
        /// <para>The method used to generate the thumbnail of a video. If this parameter is specified, you are redirected to the URL of the generated thumbnail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video/snapshot,t_7000,f_jpg,w_800,h_600,m_fast</para>
        /// </summary>
        [NameInMap("video_thumbnail_process")]
        [Validation(Required=false)]
        public string VideoThumbnailProcess { get; set; }

    }

}
