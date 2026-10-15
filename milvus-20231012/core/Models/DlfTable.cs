// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class DlfTable : TeaModel {
        /// <summary>
        /// <para>The table description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test table</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The table storage location.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://bucket/path</para>
        /// </summary>
        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// <para>The table format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PAIMON</para>
        /// </summary>
        [NameInMap("tableFormat")]
        [Validation(Required=false)]
        public string TableFormat { get; set; }

        /// <summary>
        /// <para>The table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_table</para>
        /// </summary>
        [NameInMap("tableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The table type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MANAGED</para>
        /// </summary>
        [NameInMap("tableType")]
        [Validation(Required=false)]
        public string TableType { get; set; }

    }

}
