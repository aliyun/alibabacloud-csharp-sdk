// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyCloudDrivePermissionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud disk in Cloud Drive Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+cds-60911*****</para>
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// <para>The IDs of the users who have the download permissions.</para>
        /// </summary>
        [NameInMap("DownloadEndUserIds")]
        [Validation(Required=false)]
        public List<string> DownloadEndUserIds { get; set; }

        /// <summary>
        /// <para>The IDs of the users who have the upload and download permissions.</para>
        /// </summary>
        [NameInMap("DownloadUploadEndUserIds")]
        [Validation(Required=false)]
        public List<string> DownloadUploadEndUserIds { get; set; }

        [NameInMap("NoDownloadNoUploadEndUserIds")]
        [Validation(Required=false)]
        public List<string> NoDownloadNoUploadEndUserIds { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
