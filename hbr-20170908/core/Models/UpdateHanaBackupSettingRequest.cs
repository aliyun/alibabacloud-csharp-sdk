// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpdateHanaBackupSettingRequest : TeaModel {
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
        /// <para>Specifies whether to use Backint to back up catalogs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Backint is used to back up catalogs.</description></item>
        /// <item><description>false: Backint is not used to back up catalogs.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CatalogBackupUsingBackint")]
        [Validation(Required=false)]
        public bool? CatalogBackupUsingBackint { get; set; }

        /// <summary>
        /// <para>The ID of the SAP HANA instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cl-000ezvg******8znz</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEMDB</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic log backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables automatic log backup.</description></item>
        /// <item><description><b>false</b>: disables automatic log backup.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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
        /// <para>Specifies whether to use Backint to back up logs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Backint is used to back up logs.</description></item>
        /// <item><description>false: Backint is not used to back up logs.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("LogBackupUsingBackint")]
        [Validation(Required=false)]
        public bool? LogBackupUsingBackint { get; set; }

        /// <summary>
        /// <para>The ID of the backup vault.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-0005n******rluw5</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
