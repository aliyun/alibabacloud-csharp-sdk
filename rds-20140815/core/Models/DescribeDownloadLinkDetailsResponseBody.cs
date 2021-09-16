// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDownloadLinkDetailsResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDownloadLinkDetailsResponseBodyData Data { get; set; }
        public class DescribeDownloadLinkDetailsResponseBodyData : TeaModel {
            [NameInMap("BackupDownloadLinkByDB")]
            [Validation(Required=false)]
            public List<DescribeDownloadLinkDetailsResponseBodyDataBackupDownloadLinkByDB> BackupDownloadLinkByDB { get; set; }
            public class DescribeDownloadLinkDetailsResponseBodyDataBackupDownloadLinkByDB : TeaModel {
                public string DataBase { get; set; }
                public string DownloadLink { get; set; }
                public string IntranetDownloadLink { get; set; }
            }
            [NameInMap("MaxRecordsPerPage")]
            [Validation(Required=false)]
            public int? MaxRecordsPerPage { get; set; }
            [NameInMap("PageNumbers")]
            [Validation(Required=false)]
            public int? PageNumbers { get; set; }
            [NameInMap("TotalRecords")]
            [Validation(Required=false)]
            public int? TotalRecords { get; set; }
            [NameInMap("BackupStartTime")]
            [Validation(Required=false)]
            public string BackupStartTime { get; set; }
            [NameInMap("BackupEndTime")]
            [Validation(Required=false)]
            public string BackupEndTime { get; set; }
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }
            [NameInMap("BackupMethod")]
            [Validation(Required=false)]
            public string BackupMethod { get; set; }
            [NameInMap("BackupStatus")]
            [Validation(Required=false)]
            public string BackupStatus { get; set; }
            [NameInMap("HostInstanceId")]
            [Validation(Required=false)]
            public int? HostInstanceId { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
