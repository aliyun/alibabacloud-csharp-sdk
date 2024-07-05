// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UpdateMediaRequest : TeaModel {
        /// <summary>
        /// The ID of the category to which the media file belongs. The value must be an integer.
        /// 
        /// *   If you do not specify this parameter, the value is NULL.
        /// *   The value cannot be negative.
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// The URL of the thumbnail. This parameter is used to specify the storage location of the thumbnail. To obtain the URL, you can log on to the **MPS console** and choose **Workflows** > **Media Buckets** in the left-side navigation pane. Alternatively, you can log on to the **OSS console** and click **Buckets** in the left-side navigation pane.
        /// 
        /// *   The value can be up to 3,200 bytes in length.
        /// *   The URL complies with RFC 2396 and is encoded in UTF-8, with reserved characters being percent-encoded. For more information, see [URL encoding](https://help.aliyun.com/document_detail/423796.html).
        /// </summary>
        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// The description of the media file. Multiple character types, such as letters and digits, are supported.
        /// 
        /// *   If you do not specify this parameter, the value is NULL.
        /// *   The value is encoded in UTF-8 and can be up to 1,024 bytes in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the media file whose basic information you want to update. To obtain the ID of the media file, you can log on to the **ApsaraVideo Media Processing (MPS) console** and choose **Media Management** > **Media List** in the left-side navigation pane.
        /// 
        /// This parameter is required.
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

        /// <summary>
        /// The tags that you want to add to the media file.
        /// 
        /// *   You can specify up to 16 tags for a media file. Separate multiple tags with commas (,).
        /// *   Each tag can be up to 32 bytes in length.
        /// *   The value is encoded in UTF-8.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// The title of the media file. Multiple character types, such as letters and digits, are supported.
        /// 
        /// *   If you do not specify this parameter, the value is NULL.
        /// *   The value is encoded in UTF-8 and can be up to 128 bytes in length.
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
