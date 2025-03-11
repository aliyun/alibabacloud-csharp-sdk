// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class PutStartBackupRequest : TeaModel {
        /// <summary>
        /// <para>If you need to back up data at the database level, you must specify the list of databases to be backed up, and separate multiple databases with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>db_1, db_2</para>
        /// </summary>
        [NameInMap("BackupDbNames")]
        [Validation(Required=false)]
        public string BackupDbNames { get; set; }

        /// <summary>
        /// <para>The backup level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>instance: instance</description></item>
        /// <item><description>db: The database type.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>db</para>
        /// </summary>
        [NameInMap("BackupLevel")]
        [Validation(Required=false)]
        public string BackupLevel { get; set; }

        /// <summary>
        /// <para>The backup mode. For more information, see <a href="https://help.aliyun.com/document_detail/108631.html">backup mode</a> and the valid values are as follows:</para>
        /// <list type="bullet">
        /// <item><description>phy: fast backup</description></item>
        /// <item><description>logic: Consistent backup</description></item>
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
        /// <para>drds****c6vxxyzd</para>
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

    }

}
