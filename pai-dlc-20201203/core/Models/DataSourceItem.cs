// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class DataSourceItem : TeaModel {
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public string DataSourceId { get; set; }

        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifyTime")]
        [Validation(Required=false)]
        public string GmtModifyTime { get; set; }

        [NameInMap("MountPath")]
        [Validation(Required=false)]
        public string MountPath { get; set; }

        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
