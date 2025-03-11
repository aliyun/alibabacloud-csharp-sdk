// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeRestoreOrderRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database involved in the backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drds_flashback</para>
        /// </summary>
        [NameInMap("BackupDbNames")]
        [Validation(Required=false)]
        public string BackupDbNames { get; set; }

        /// <summary>
        /// <para>The ID of the backup set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1918df27-4563-11e9-8403-af4fbe******</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The level of the backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DB</b>: The database Level</description></item>
        /// <item><description>**instance **: instance level</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>db</para>
        /// </summary>
        [NameInMap("BackupLevel")]
        [Validation(Required=false)]
        public string BackupLevel { get; set; }

        /// <summary>
        /// <para>The backup mode. Valid values: <b>logic</b> or <b>phy</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>phy</para>
        /// </summary>
        [NameInMap("BackupMode")]
        [Validation(Required=false)]
        public string BackupMode { get; set; }

        /// <summary>
        /// <para>The ID of the instance for which to modify the backup policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drds************</para>
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// <para>The preferred backup time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-16 15:12:53</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

    }

}
