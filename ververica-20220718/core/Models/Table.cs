// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Table : TeaModel {
        /// <summary>
        /// <para>The comment.</para>
        /// </summary>
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("metadata")]
        [Validation(Required=false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// <para>The name of the table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order-test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The partition key column.</para>
        /// </summary>
        [NameInMap("partitionKeys")]
        [Validation(Required=false)]
        public List<string> PartitionKeys { get; set; }

        /// <summary>
        /// <para>The parameter configurations of the table.</para>
        /// </summary>
        [NameInMap("properties")]
        [Validation(Required=false)]
        public Dictionary<string, object> Properties { get; set; }

        /// <summary>
        /// <para>The schema information about the table.</para>
        /// </summary>
        [NameInMap("schema")]
        [Validation(Required=false)]
        public Schema Schema { get; set; }

        /// <summary>
        /// <para>TABLE;
        ///   MATERIALIZED_TABLE;
        ///   VIEW;</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("tableType")]
        [Validation(Required=false)]
        public string TableType { get; set; }

    }

}
