// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class SqlExecutionFetchResult : TeaModel {
        /// <summary>
        /// <para>The result of the data query language (DQL) statement.</para>
        /// </summary>
        [NameInMap("dqlResult")]
        [Validation(Required=false)]
        public DqlResult DqlResult { get; set; }

        /// <summary>
        /// <para>The information about the SQL execution.</para>
        /// </summary>
        [NameInMap("sqlExecution")]
        [Validation(Required=false)]
        public SqlExecution SqlExecution { get; set; }

    }

}
