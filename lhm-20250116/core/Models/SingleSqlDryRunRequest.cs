// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class SingleSqlDryRunRequest : TeaModel {
        /// <summary>
        /// <para>The data source name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds_demo</para>
        /// </summary>
        [NameInMap("datasourceName")]
        [Validation(Required=false)]
        public string DatasourceName { get; set; }

        /// <summary>
        /// <para>The SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT id, name FROM src_table WHERE ds = \&quot;20260116\&quot;</para>
        /// </summary>
        [NameInMap("sql")]
        [Validation(Required=false)]
        public string Sql { get; set; }

    }

}
