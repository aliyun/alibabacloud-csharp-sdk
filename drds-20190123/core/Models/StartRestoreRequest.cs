// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class StartRestoreRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database to be restored. Separate multiple databases with commas (,).</para>
        /// <remarks>
        /// <para> If you do not specify any database name, all databases in the instance are restored by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test1,test2</para>
        /// </summary>
        [NameInMap("BackupDbNames")]
        [Validation(Required=false)]
        public string BackupDbNames { get; set; }

        /// <summary>
        /// <para>The ID of the DRDS backup set.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system restores data by time (PreferredBackupTime).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23***</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The level of the backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>db: The database level.</description></item>
        /// <item><description>instance: the instance level.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>db</para>
        /// </summary>
        [NameInMap("BackupLevel")]
        [Validation(Required=false)]
        public string BackupLevel { get; set; }

        /// <summary>
        /// <para>The backup method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>logic: the logical backup.</description></item>
        /// <item><description>phy: fast backup</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>phy</para>
        /// </summary>
        [NameInMap("BackupMode")]
        [Validation(Required=false)]
        public string BackupMode { get; set; }

        /// <summary>
        /// <para>The ID of the DRDS instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds********</para>
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// <para>The restoration time of the instance, in the format of<c> yyyy-MM-dd HH:mm:ss</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-10 20:18:18</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

    }

}
