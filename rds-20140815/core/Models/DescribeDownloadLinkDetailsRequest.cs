// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDownloadLinkDetailsRequest : TeaModel {
        /// <summary>
        /// 实例 ID。
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public int? BackupSetId { get; set; }

        [NameInMap("MaxRecordsPerPage")]
        [Validation(Required=false)]
        public int? MaxRecordsPerPage { get; set; }

        [NameInMap("PageNumbers")]
        [Validation(Required=false)]
        public int? PageNumbers { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("DataBaseName")]
        [Validation(Required=false)]
        public string DataBaseName { get; set; }

    }

}
