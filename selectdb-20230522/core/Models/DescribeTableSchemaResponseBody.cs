// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Selectdb20230522.Models
{
    public class DescribeTableSchemaResponseBody : TeaModel {
        /// <summary>
        /// <para>The CREATE TABLE statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE TABLE test_tb
        /// (
        ///     k1 TINYINT,
        ///     k2 DECIMAL(10, 2) DEFAULT &quot;10.05&quot;,
        ///     k3 CHAR(10) COMMENT &quot;string column&quot;,
        ///     k4 INT NOT NULL DEFAULT &quot;1&quot; COMMENT &quot;int column&quot;
        /// )
        /// COMMENT &quot;my first table&quot;
        /// DISTRIBUTED BY HASH(k1) BUCKETS 16</para>
        /// </summary>
        [NameInMap("CreateStatement")]
        [Validation(Required=false)]
        public string CreateStatement { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_db</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4773E4EC-025D-509F-AEA9-D53123FDFB0F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_tb</para>
        /// </summary>
        [NameInMap("Table")]
        [Validation(Required=false)]
        public string Table { get; set; }

    }

}
