// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AgenticTableEngineMeta : TeaModel {
        /// <summary>
        /// <para>A checksum to verify the table\&quot;s data integrity.</para>
        /// </summary>
        [NameInMap("Checksum")]
        [Validation(Required=false)]
        public string Checksum { get; set; }

        /// <summary>
        /// <para>The time the table was created, in UTC format (<c>YYYY-MM-DDThh:mm:ssZ</c>).</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The total size of the table\&quot;s data, in bytes.</para>
        /// </summary>
        [NameInMap("DataBytes")]
        [Validation(Required=false)]
        public long? DataBytes { get; set; }

        /// <summary>
        /// <para>The character encoding of the table.</para>
        /// </summary>
        [NameInMap("Encoding")]
        [Validation(Required=false)]
        public string Encoding { get; set; }

        /// <summary>
        /// <para>The table\&quot;s storage engine, such as <c>InnoDB</c>.</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>A checksum of the table\&quot;s data and indexes.</para>
        /// </summary>
        [NameInMap("FullChecksum")]
        [Validation(Required=false)]
        public string FullChecksum { get; set; }

        /// <summary>
        /// <para>The total size of the table\&quot;s indexes, in bytes.</para>
        /// </summary>
        [NameInMap("IndexBytes")]
        [Validation(Required=false)]
        public long? IndexBytes { get; set; }

        /// <summary>
        /// <para>The timestamp of the last DDL (Data Definition Language) operation, in UTC format (<c>YYYY-MM-DDThh:mm:ssZ</c>).</para>
        /// </summary>
        [NameInMap("LastDdlTime")]
        [Validation(Required=false)]
        public string LastDdlTime { get; set; }

        /// <summary>
        /// <para>The number of rows in the table.</para>
        /// </summary>
        [NameInMap("NumRows")]
        [Validation(Required=false)]
        public long? NumRows { get; set; }

        /// <summary>
        /// <para>The table\&quot;s reference information.</para>
        /// </summary>
        [NameInMap("RefInfo")]
        [Validation(Required=false)]
        public string RefInfo { get; set; }

        /// <summary>
        /// <para>The table\&quot;s total storage capacity, in bytes.</para>
        /// </summary>
        [NameInMap("StorageCapacity")]
        [Validation(Required=false)]
        public long? StorageCapacity { get; set; }

        /// <summary>
        /// <para>The name of the table schema.</para>
        /// </summary>
        [NameInMap("TableSchemaName")]
        [Validation(Required=false)]
        public string TableSchemaName { get; set; }

    }

}
