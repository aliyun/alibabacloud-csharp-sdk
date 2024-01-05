// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeHanaBackupSettingResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the call is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The backup settings.
        /// </summary>
        [NameInMap("HanaBackupSetting")]
        [Validation(Required=false)]
        public DescribeHanaBackupSettingResponseBodyHanaBackupSetting HanaBackupSetting { get; set; }
        public class DescribeHanaBackupSettingResponseBodyHanaBackupSetting : TeaModel {
            /// <summary>
            /// The configuration file for catalog backup.
            /// </summary>
            [NameInMap("CatalogBackupParameterFile")]
            [Validation(Required=false)]
            public string CatalogBackupParameterFile { get; set; }

            /// <summary>
            /// Indicates whether Backint is used to back up catalogs. Valid values:
            /// 
            /// *   true: Backint is used to back up catalogs.
            /// *   false: Backint is not used to back up catalogs.
            /// </summary>
            [NameInMap("CatalogBackupUsingBackint")]
            [Validation(Required=false)]
            public bool? CatalogBackupUsingBackint { get; set; }

            /// <summary>
            /// The configuration file for data backup.
            /// </summary>
            [NameInMap("DataBackupParameterFile")]
            [Validation(Required=false)]
            public string DataBackupParameterFile { get; set; }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// Indicates whether automatic log backup is enabled. Valid values:
            /// 
            /// *   **true**: Automatic log backup is enabled.
            /// *   **false**: Automatic log backup is disabled.
            /// </summary>
            [NameInMap("EnableAutoLogBackup")]
            [Validation(Required=false)]
            public bool? EnableAutoLogBackup { get; set; }

            /// <summary>
            /// The configuration file for log backup.
            /// </summary>
            [NameInMap("LogBackupParameterFile")]
            [Validation(Required=false)]
            public string LogBackupParameterFile { get; set; }

            /// <summary>
            /// The interval at which logs are backed up. Unit: seconds.
            /// </summary>
            [NameInMap("LogBackupTimeout")]
            [Validation(Required=false)]
            public long? LogBackupTimeout { get; set; }

            /// <summary>
            /// Indicates whether Backint is used to back up logs. Valid values:
            /// 
            /// *   true: Backint is used to back up logs.
            /// *   false: Backint is not used to back up logs.
            /// </summary>
            [NameInMap("LogBackupUsingBackint")]
            [Validation(Required=false)]
            public bool? LogBackupUsingBackint { get; set; }

        }

        /// <summary>
        /// The message that is returned. If the call is successful, "successful" is returned. If the call fails, an error message is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call is successful. Valid values:
        /// 
        /// *   true: The call is successful.
        /// *   false: The call fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
