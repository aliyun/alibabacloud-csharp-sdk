// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class TableMeta : TeaModel {
        /// <summary>
        /// <para>The catalog name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>paimon</para>
        /// </summary>
        [NameInMap("catalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>paimon-ods</para>
        /// </summary>
        [NameInMap("databaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order-table</para>
        /// </summary>
        [NameInMap("tableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
