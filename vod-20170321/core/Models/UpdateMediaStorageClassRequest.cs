// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateMediaStorageClassRequest : TeaModel {
        /// <summary>
        /// Specifies whether to change the storage class of a media asset that is stored for less than the minimum storage duration. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// >  If you forcibly change the storage class of a media asset that is stored for less than the minimum storage duration, additional data retrieval fees are incurred.
        /// </summary>
        [NameInMap("AllowUpdateWithoutTimeLimit")]
        [Validation(Required=false)]
        public bool? AllowUpdateWithoutTimeLimit { get; set; }

        /// <summary>
        /// The media asset ID. You can specify a maximum of 20 IDs. Separate multiple IDs with commas (,). You can use one of the following methods to obtain the ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD](https://vod.console.aliyun.com) console. In the left-side navigation pane, choose **Media Files** > **Audio/Video**. On the Video and Audio page, you can view the ID of the media asset. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.
        /// *   Obtain the value of the VideoId parameter from the response to the [CreateUploadVideo](https://help.aliyun.com/document_detail/55407.html) operation that you call to upload media assets.
        /// *   Obtain the value of the VideoId parameter from the response to the [SearchMedia](https://help.aliyun.com/document_detail/86044.html) operation that you call to query the media ID after the media asset is uploaded.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

        /// <summary>
        /// The restoration priority. This parameter is required only when you restore a Cold Archive media asset. Valid values:
        /// 
        /// *   **Expedited**
        /// *   **Standard**
        /// *   **Bulk**
        /// </summary>
        [NameInMap("RestoreTier")]
        [Validation(Required=false)]
        public string RestoreTier { get; set; }

        /// <summary>
        /// The modification range. Valid values:
        /// 
        /// *   **All**: modifies the storage classes of all resources including the source files and transcoded streams.
        /// *   **SourceFile**: modifies the storage classes of only the source files. The storage class of other resources is Standard.
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// The storage class. Valid values:
        /// 
        /// *   **Standard**
        /// *   **IA**
        /// *   **Archive**
        /// *   **ColdArchive**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StorageClass")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

    }

}
