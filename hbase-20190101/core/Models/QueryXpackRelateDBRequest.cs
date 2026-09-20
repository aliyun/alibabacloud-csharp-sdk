// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class QueryXpackRelateDBRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the current Spark instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-bp1qtz9rcbbt3p6ng</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>This parameter is valid only when bds queries associated HBase instances.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Single-node HBase instances are included.</para>
        /// </description></item>
        /// <item><description><para>false: Single-node HBase instances are not included. This parameter is optional. For backward compatibility, single-node HBase instances are included when this parameter is left empty.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HasSingleNode")]
        [Validation(Required=false)]
        public bool? HasSingleNode { get; set; }

        /// <summary>
        /// <para>The type of database to query for association.</para>
        /// <list type="bullet">
        /// <item><description>spark can be associated with hdfs, hbase, mongodb, mysql, polardb_mysql, redis, and geomesa.</description></item>
        /// <item><description>bds can be associated with hbase, spark, and hbaseue.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hbase</para>
        /// </summary>
        [NameInMap("RelateDbType")]
        [Validation(Required=false)]
        public string RelateDbType { get; set; }

    }

}
