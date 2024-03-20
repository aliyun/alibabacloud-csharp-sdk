// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeBackupSetDownloadLinkRequest : TeaModel {
        /// <summary>
        /// The ID of the download task corresponding to the target backup set.
        /// </summary>
        [NameInMap("DownloadTaskId")]
        [Validation(Required=false)]
        public string DownloadTaskId { get; set; }

        /// <summary>
        /// The ID of the OceanBase cluster.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
