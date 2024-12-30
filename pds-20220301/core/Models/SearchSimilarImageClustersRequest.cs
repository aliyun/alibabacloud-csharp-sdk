// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SearchSimilarImageClustersRequest : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>YWRzX3VzZXJfcHJvZmlsZV9je1bnQh***</para>
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("order")]
        [Validation(Required=false)]
        public string Order { get; set; }

    }

}
