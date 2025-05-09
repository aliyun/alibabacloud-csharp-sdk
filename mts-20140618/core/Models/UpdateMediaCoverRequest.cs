// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UpdateMediaCoverRequest : TeaModel {
        /// <summary>
        /// <para>The URL of the thumbnail that you want to specify for the media file. The URL complies with RFC 2396 and is encoded in UTF-8. The URL can be up to 3,200 bytes in length.</para>
        /// <remarks>
        /// <para> To obtain the thumbnail URL, you can find the image in the Object Storage Service (OSS) bucket and click the image to view details. In the View Details panel, copy the part before the question mark (?) from the URL field. You can enter only an HTTP URL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example-bucket-****.oss-cn-hangzhou.aliyuncs.com//example-****.mp4">http://example-bucket-****.oss-cn-hangzhou.aliyuncs.com//example-****.mp4</a></para>
        /// </summary>
        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// <para>The ID of the media file whose thumbnail you want to update. To obtain the ID of a media file, you can call the <a href="https://help.aliyun.com/document_detail/44458.html">AddMedia</a> operation. Alternatively, perform the following operations in the ApsaraVideo Media Processing (MPS) console: In the left-side navigation pane, choose <b>Media Management</b> &gt; <b>Media List</b>. Find the required video and click <b>Manage</b>. The ID of the video is displayed on the Basics tab.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6cc3aa66d1cb4bb2adf14e726c0a****</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
