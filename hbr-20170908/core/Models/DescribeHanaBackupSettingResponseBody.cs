// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeHanaBackupSettingResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The backup settings.</para>
        /// </summary>
        [NameInMap("HanaBackupSetting")]
        [Validation(Required=false)]
        public DescribeHanaBackupSettingResponseBodyHanaBackupSetting HanaBackupSetting { get; set; }
        public class DescribeHanaBackupSettingResponseBodyHanaBackupSetting : TeaModel {
            /// <summary>
            /// <para>The configuration file for catalog backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/sap/SID/SYS/global/hdb/opt/hdbconfig/param</para>
            /// </summary>
            [NameInMap("CatalogBackupParameterFile")]
            [Validation(Required=false)]
            public string CatalogBackupParameterFile { get; set; }

            /// <summary>
            /// <para>Indicates whether Backint is used to back up catalogs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Backint is used to back up catalogs.</description></item>
            /// <item><description>false: Backint is not used to back up catalogs.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CatalogBackupUsingBackint")]
            [Validation(Required=false)]
            public bool? CatalogBackupUsingBackint { get; set; }

            /// <summary>
            /// <para>The configuration file for data backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/sap/SID/SYS/global/hdb/opt/hdbconfig/param</para>
            /// </summary>
            [NameInMap("DataBackupParameterFile")]
            [Validation(Required=false)]
            public string DataBackupParameterFile { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEMDB</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <para>Indicates whether automatic log backup is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Automatic log backup is enabled.</description></item>
            /// <item><description><b>false</b>: Automatic log backup is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableAutoLogBackup")]
            [Validation(Required=false)]
            public bool? EnableAutoLogBackup { get; set; }

            /// <summary>
            /// <para>The configuration file for log backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/sap/SID/SYS/global/hdb/opt/hdbconfig/param</para>
            /// </summary>
            [NameInMap("LogBackupParameterFile")]
            [Validation(Required=false)]
            public string LogBackupParameterFile { get; set; }

            /// <summary>
            /// <para>The interval at which logs are backed up. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>900</para>
            /// </summary>
            [NameInMap("LogBackupTimeout")]
            [Validation(Required=false)]
            public long? LogBackupTimeout { get; set; }

            /// <summary>
            /// <para>Indicates whether Backint is used to back up logs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Backint is used to back up logs.</description></item>
            /// <item><description>false: Backint is not used to back up logs.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("LogBackupUsingBackint")]
            [Validation(Required=false)]
            public bool? LogBackupUsingBackint { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned. If the call is successful, &quot;successful&quot; is returned. If the call fails, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9D0DB5BC-5071-5ADF-BCD1-14EBB0C17C54</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
