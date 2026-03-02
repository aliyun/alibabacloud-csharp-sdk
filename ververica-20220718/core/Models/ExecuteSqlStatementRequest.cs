// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ExecuteSqlStatementRequest : TeaModel {
        /// <summary>
        /// <para>The SQL statement to query the metadata.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public SqlStatementWithContext Body { get; set; }

    }

}
