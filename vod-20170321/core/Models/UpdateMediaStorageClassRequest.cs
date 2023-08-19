// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateMediaStorageClassRequest : TeaModel {
        /// <summary>
        /// The ID of the media asset. You can specify a maximum of 20 IDs. Separate multiple IDs with commas (,). You can use one of the following methods to obtain the ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD](https://vod.console.aliyun.com) console. In the left-side navigation pane, choose **Media Files** > **Audio/Video**. On the Video and Audio page, you can view the ID of the media asset. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.
        /// *   Obtain the value of VideoId from the response to the [CreateUploadVideo](~~55407~~) operation that you call to upload media assets.
        /// *   Obtain the value of VideoId from the response to the [SearchMedia](~~86044~~) operation that you call to query the media ID after the media asset is uploaded.
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
        /// *   **All**: modifies the storage classes of all resources including the source files, transcoded streams, and snapshots.
        /// *   **SourceFile**: modifies the storage classes of only the source files. The storage class of other resources is Standard.
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// The storage class to which you want to modify. Valid values:
        /// 
        /// *   **Standard**
        /// *   **IA**
        /// *   **Archive**
        /// *   **ColdArchive**
        /// </summary>
        [NameInMap("StorageClass")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

    }

}
