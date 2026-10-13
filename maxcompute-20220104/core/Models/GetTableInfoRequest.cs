// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetTableInfoRequest : TeaModel {
        /// <summary>
        /// <para>The name of the schema to which the table or view to be queried belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("schemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// <para>The type of the table or view to be queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>internal</b>: Internal table.</description></item>
        /// <item><description><b>external</b>: External table.</description></item>
        /// <item><description><b>view</b>: View.</description></item>
        /// <item><description><b>materializedView</b>: &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/maxcompute/user-guide/materialized-view-operations">Materialized view</a>
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/maxcompute/user-guide/materialized-view-operations">Materialized view</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>internal</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
