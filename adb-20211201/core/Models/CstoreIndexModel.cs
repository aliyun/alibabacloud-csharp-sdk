// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CstoreIndexModel : TeaModel {
        /// <summary>
        /// <para>The order of index columns.</para>
        /// </summary>
        [NameInMap("ColumnOrds")]
        [Validation(Required=false)]
        public List<string> ColumnOrds { get; set; }

        /// <summary>
        /// <para>The time when the index was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-05 13:17:55</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The logical name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleDatabase</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The index columns.</para>
        /// </summary>
        [NameInMap("IndexColumns")]
        [Validation(Required=false)]
        public List<FieldSchemaModel> IndexColumns { get; set; }

        /// <summary>
        /// <para>The name of the index.</para>
        /// 
        /// <b>Example:</b>
        /// <para>indexName</para>
        /// </summary>
        [NameInMap("IndexName")]
        [Validation(Required=false)]
        public string IndexName { get; set; }

        /// <summary>
        /// <para>The type of the index.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("IndexType")]
        [Validation(Required=false)]
        public string IndexType { get; set; }

        /// <summary>
        /// <para>The properties.</para>
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public Dictionary<string, string> Options { get; set; }

        /// <summary>
        /// <para>The physical name of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>physicalDatabase</para>
        /// </summary>
        [NameInMap("PhysicalTableName")]
        [Validation(Required=false)]
        public string PhysicalTableName { get; set; }

        /// <summary>
        /// <para>The time when the index was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-05 13:17:55</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
