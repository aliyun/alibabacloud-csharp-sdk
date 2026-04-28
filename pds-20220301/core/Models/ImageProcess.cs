// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ImageProcess : TeaModel {
        /// <summary>
        /// <para>The thumbnail processing rules for images. For more information, see the &quot;IMG implementation modes&quot; topic of Object Storage Service (OSS). Default value: image/resize,m_fill,h_128,w_128,limit_0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image/resize,m_fill,h_128,w_128,limit_0</para>
        /// </summary>
        [NameInMap("image_thumbnail_process")]
        [Validation(Required=false)]
        public string ImageThumbnailProcess { get; set; }

        /// <summary>
        /// <para>The thumbnail processing rules for documents. For a document, the snapshot of one of the pages in the document is used as the thumbnail. This parameter takes effect on this snapshot. Default value: image/resize,m_fill,h_128,w_128,limit_0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image/resize,m_fill,h_128,w_128,limit_0</para>
        /// </summary>
        [NameInMap("office_thumbnail_process")]
        [Validation(Required=false)]
        public string OfficeThumbnailProcess { get; set; }

        /// <summary>
        /// <para>The thumbnail processing rules for videos. For more information, see the &quot;Video snapshots&quot; topic of OSS. Default value: video/snapshot,t_1000,f_jpg,w_0,h_0,m_fast,ar_auto.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video/snapshot,t_1000,f_jpg,w_0,h_0,m_fast,ar_auto</para>
        /// </summary>
        [NameInMap("video_thumbnail_process")]
        [Validation(Required=false)]
        public string VideoThumbnailProcess { get; set; }

    }

}
