// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyCloudDrivePermissionRequest : TeaModel {
        /// <summary>
        /// The ID of the cloud disk in Cloud Drive Service.
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// The IDs of the users who have the download permissions.
        /// </summary>
        [NameInMap("DownloadEndUserIds")]
        [Validation(Required=false)]
        public List<string> DownloadEndUserIds { get; set; }

        /// <summary>
        /// The IDs of the users who have the upload and download permissions.
        /// </summary>
        [NameInMap("DownloadUploadEndUserIds")]
        [Validation(Required=false)]
        public List<string> DownloadUploadEndUserIds { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
