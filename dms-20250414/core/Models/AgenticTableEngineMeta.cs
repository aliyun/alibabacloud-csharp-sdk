// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgenticTableEngineMeta : TeaModel {
        /// <summary>
        /// <para>The checksum of the table metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9f86d081884c7d65****</para>
        /// </summary>
        [NameInMap("Checksum")]
        [Validation(Required=false)]
        public string Checksum { get; set; }

        /// <summary>
        /// <para>The time when the table was created. The format is yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-01 10:00:00</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The data size of the table. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>786432</para>
        /// </summary>
        [NameInMap("DataBytes")]
        [Validation(Required=false)]
        public long? DataBytes { get; set; }

        /// <summary>
        /// <para>The character set encoding of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>utf8mb4</para>
        /// </summary>
        [NameInMap("Encoding")]
        [Validation(Required=false)]
        public string Encoding { get; set; }

        /// <summary>
        /// <para>The storage engine of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InnoDB</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The full checksum of the table metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2c26b46b68ffc68f****</para>
        /// </summary>
        [NameInMap("FullChecksum")]
        [Validation(Required=false)]
        public string FullChecksum { get; set; }

        /// <summary>
        /// <para>The index size of the table. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>262144</para>
        /// </summary>
        [NameInMap("IndexBytes")]
        [Validation(Required=false)]
        public long? IndexBytes { get; set; }

        /// <summary>
        /// <para>The time when the last DDL operation was executed on the table. The format is yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-02 10:00:00</para>
        /// </summary>
        [NameInMap("LastDdlTime")]
        [Validation(Required=false)]
        public string LastDdlTime { get; set; }

        /// <summary>
        /// <para>The number of rows in the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("NumRows")]
        [Validation(Required=false)]
        public long? NumRows { get; set; }

        /// <summary>
        /// <para>The reference information of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order_db.orders_view</para>
        /// </summary>
        [NameInMap("RefInfo")]
        [Validation(Required=false)]
        public string RefInfo { get; set; }

        /// <summary>
        /// <para>The storage capacity of the table. Unit: MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("StorageCapacity")]
        [Validation(Required=false)]
        public long? StorageCapacity { get; set; }

        /// <summary>
        /// <para>The name of the schema to which the table belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("TableSchemaName")]
        [Validation(Required=false)]
        public string TableSchemaName { get; set; }

    }

}
