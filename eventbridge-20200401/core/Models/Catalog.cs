// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class Catalog : TeaModel {
        /// <summary>
        /// <para>The comment of the data catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test data catalog</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The name of the connection associated with a mounted catalog. This property has a value only when the provider is MySQL, PostgreSQL, Elasticsearch, OSS_TABLES, SLS, OTS, MaxCompute, MongoDB, Redis, SQLServer, ClickHouse, Oracle, Hive, or Iceberg.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_connection</para>
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// <para>The unique name of the data catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_catalog</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The extended properties as a JSON object. The Elasticsearch type includes information such as IndexPattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;IndexPattern&quot;:&quot;my-index-*&quot;}</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public Dictionary<string, object> Properties { get; set; }

        /// <summary>
        /// <para>The data source provider. EventHouse uses built-in storage, while MySQL, PostgreSQL, Elasticsearch, OSS_TABLES, SLS, OTS, MaxCompute, MongoDB, Redis, SQLServer, ClickHouse, Oracle, Hive, and Iceberg are externally mounted.</para>
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
