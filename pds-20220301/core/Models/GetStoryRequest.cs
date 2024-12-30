// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetStoryRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>image/resize,m_fill,h_128,w_128,limit_0/format,jpg</para>
        /// </summary>
        [NameInMap("cover_image_thumbnail_process")]
        [Validation(Required=false)]
        [Obsolete]
        public string CoverImageThumbnailProcess { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>video/snapshot,t_1000,f_jpg,w_0,h_0,m_fast,ar_auto</para>
        /// </summary>
        [NameInMap("cover_video_thumbnail_process")]
        [Validation(Required=false)]
        [Obsolete]
        public string CoverVideoThumbnailProcess { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>image/resize,m_fill,h_128,w_128,limit_0/format,jpg</para>
        /// </summary>
        [NameInMap("image_thumbnail_process")]
        [Validation(Required=false)]
        [Obsolete]
        public string ImageThumbnailProcess { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>image/resize,m_fill,h_128,w_128,limit_0/format,jpg</para>
        /// </summary>
        [NameInMap("image_url_process")]
        [Validation(Required=false)]
        [Obsolete]
        public string ImageUrlProcess { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9132e0d8-fe92-4e56-86c3-f5f112308003</para>
        /// </summary>
        [NameInMap("story_id")]
        [Validation(Required=false)]
        public string StoryId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>900</para>
        /// </summary>
        [NameInMap("url_expire_sec")]
        [Validation(Required=false)]
        [Obsolete]
        public long? UrlExpireSec { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>video/snapshot,t_1000,f_jpg,w_0,h_0,m_fast,ar_auto</para>
        /// </summary>
        [NameInMap("video_thumbnail_process")]
        [Validation(Required=false)]
        [Obsolete]
        public string VideoThumbnailProcess { get; set; }

    }

}
