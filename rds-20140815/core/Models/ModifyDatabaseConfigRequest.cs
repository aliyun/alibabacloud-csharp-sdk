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
        /// <para>rm-t4nnu1my39q******</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// <remarks>
        /// <para>Specifying multiple database names is not supported.</para>
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
        /// <para>The database attribute that you want to modify.</para>
        /// <list type="bullet">
        /// <item><description><b>Modify database attributes feature</b>: Enter the attribute name of the target database.</description></item>
        /// <item><description><b>Data archiving to OSS feature</b>: Enter the status of the target database. Set this parameter to <c>covert_online_db_to_cold_storage</c> to convert an online database to a cold storage database, or set this parameter to <c>convert_cold_storage_db_to_online</c> to convert a cold storage database to an online database.</description></item>
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
        /// <para>The value of the database attribute that you want to modify.</para>
        /// <list type="bullet">
        /// <item><description><b>Modify database attributes feature</b>: Enter the attribute value of the target database.</description></item>
        /// <item><description><b>Data archiving to OSS feature</b>: Set this parameter to <b>1</b> to convert the target database to cold storage or online status.</description></item>
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
