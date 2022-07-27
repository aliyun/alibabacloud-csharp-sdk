// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpdateHanaBackupSettingRequest : TeaModel {
        [NameInMap("CatalogBackupParameterFile")]
        [Validation(Required=false)]
        public string CatalogBackupParameterFile { get; set; }

        [NameInMap("CatalogBackupUsingBackint")]
        [Validation(Required=false)]
        public bool? CatalogBackupUsingBackint { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("DataBackupParameterFile")]
        [Validation(Required=false)]
        public string DataBackupParameterFile { get; set; }

        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        [NameInMap("EnableAutoLogBackup")]
        [Validation(Required=false)]
        public bool? EnableAutoLogBackup { get; set; }

        [NameInMap("LogBackupParameterFile")]
        [Validation(Required=false)]
        public string LogBackupParameterFile { get; set; }

        [NameInMap("LogBackupTimeout")]
        [Validation(Required=false)]
        public long? LogBackupTimeout { get; set; }

        [NameInMap("LogBackupUsingBackint")]
        [Validation(Required=false)]
        public bool? LogBackupUsingBackint { get; set; }

        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
