// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class Partition : TeaModel {
        /// <summary>
        /// <para>The creation time (millisecond timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700192563000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The storage size of the partition, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4096</para>
        /// </summary>
        [NameInMap("DataSize")]
        [Validation(Required=false)]
        public long? DataSize { get; set; }

        /// <summary>
        /// <para>The modification time (millisecond timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700192563000</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds=20250101</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of records in the partition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000</para>
        /// </summary>
        [NameInMap("RecordCount")]
        [Validation(Required=false)]
        public long? RecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the parent data table. Refer to the <c>Table</c> object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table:::project_name:[schema_name]:table_name</para>
        /// </summary>
        [NameInMap("TableId")]
        [Validation(Required=false)]
        public string TableId { get; set; }

    }

}
