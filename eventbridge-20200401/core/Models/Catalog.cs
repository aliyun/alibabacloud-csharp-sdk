// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class Catalog : TeaModel {
        /// <summary>
        /// <para>The comment or description of the data catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test data catalog</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The connection name associated with a mounted catalog. This parameter has a value only when Provider is set to MySQL, PostgreSQL, Elasticsearch, OSS_TABLES, SLS, OTS, MaxCompute, MongoDB, Redis, SQLServer, ClickHouse, Oracle, Hive, or Iceberg.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_connection</para>
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// <para>The unique identifier name of the data catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_catalog</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The extended properties (JSON object). For the Elasticsearch type, this includes information such as IndexPattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;IndexPattern&quot;:&quot;my-index-*&quot;}</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public Dictionary<string, object> Properties { get; set; }

        /// <summary>
        /// <para>The data source provider. EventHouse indicates built-in storage. MySQL, PostgreSQL, Elasticsearch, OSS_TABLES, SLS, OTS, MaxCompute, MongoDB, Redis, SQLServer, ClickHouse, Oracle, Hive, and Iceberg indicate externally mounted sources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EventHouse</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The type of the data catalog, such as RELATIONAL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RELATIONAL</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
