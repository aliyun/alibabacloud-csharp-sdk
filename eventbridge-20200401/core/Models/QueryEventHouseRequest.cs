// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class QueryEventHouseRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of rows to return. If a LIMIT clause is specified in the SQL statement, the LIMIT clause in the SQL statement prevails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The query statement. A three-part table name in the format of catalog.namespace.table is typically used.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT * FROM &quot;test-es&quot;.&quot;default&quot;.&quot;product_info&quot;</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
