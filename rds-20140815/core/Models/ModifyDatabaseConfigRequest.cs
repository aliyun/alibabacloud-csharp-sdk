// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDatabaseConfigRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-t4nnu1my39qr8****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// <remarks>
        /// <para> You can specify only one database name.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDB</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <para>The database property that you want to modify.</para>
        /// <list type="bullet">
        /// <item><description><b>If you want to modify a property of the database</b>, set this parameter to the name of the database property.</description></item>
        /// <item><description><b>If you want to archive data from the database to an OSS bucket</b>, specify the database status. If you set this parameter to <c>covert_online_db_to_cold_storage</c>, the system converts an online database to a cold storage database. If you set this parameter to <c>convert_cold_storage_db_to_online</c>, the system converts a cold storage database to an online database.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>compatibility_level</para>
        /// </summary>
        [NameInMap("DatabasePropertyName")]
        [Validation(Required=false)]
        public string DatabasePropertyName { get; set; }

        /// <summary>
        /// <para>The value of the database property that you want to modify.</para>
        /// <list type="bullet">
        /// <item><description><b>If you want to modify a property of the database</b>, set this parameter to the property value.</description></item>
        /// <item><description><b>If you want to archive data from the database to an OSS bucket</b>, set this parameter to <b>1</b>. The system converts a database to a cold storage database or an online database.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>150</para>
        /// </summary>
        [NameInMap("DatabasePropertyValue")]
        [Validation(Required=false)]
        public string DatabasePropertyValue { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
