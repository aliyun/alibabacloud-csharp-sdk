// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RestoreMediaRequest : TeaModel {
        /// <summary>
        /// The ID of the media asset. You can specify a maximum of 20 IDs. Separate multiple IDs with commas (,). You can use one of the following methods to obtain the ID of the media asset.
        /// 
        /// *   Log on to the ApsaraVideo VOD console. In the left-side navigation pane, choose Media Files > Audio/Video. On the Video and Audio page, view the ID of the media asset. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.
        /// *   Obtain the value of VideoId from the response to the CreateUploadVideo operation that you call to upload media assets.
        /// *   Obtain the value of VideoId from the response to the SearchMedia operation that you call to query the media ID after the media asset is uploaded.
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

        /// <summary>
        /// The number of days during which media assets remain in the restored state. Default value: 1. The maximum validity period of a restored Archive media asset is 7 days and the maximum validity period of a restored Cold Archive media asset is 365 days.
        /// </summary>
        [NameInMap("RestoreDays")]
        [Validation(Required=false)]
        public string RestoreDays { get; set; }

        /// <summary>
        /// The restoration priority. This parameter is required only when you restore a Cold Archive media file. Valid values:
        /// 
        /// *   **Expedited**: The file is restored within 1 hour.
        /// *   **Standard**: The file is restored within 2 to 5 hours.
        /// *   **Bulk**: The file is restored within 5 to 12 hours.
        /// </summary>
        [NameInMap("RestoreTier")]
        [Validation(Required=false)]
        public string RestoreTier { get; set; }

        /// <summary>
        /// The modification range. Valid values:
        /// 
        /// *   **All**: restores all resources, including the source files and transcoded streams.
        /// *   **SourceFile**: restores only the source files.
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
