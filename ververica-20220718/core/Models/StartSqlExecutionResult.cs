// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class StartSqlExecutionResult : TeaModel {
        /// <summary>
        /// <para>Indicates whether the SQL execution is newly created.</para>
        /// </summary>
        [NameInMap("newlyCreated")]
        [Validation(Required=false)]
        public bool? NewlyCreated { get; set; }

        /// <summary>
        /// <para>The SQL execution ID.</para>
        /// </summary>
        [NameInMap("sqlExecutionId")]
        [Validation(Required=false)]
        public string SqlExecutionId { get; set; }

        /// <summary>
        /// <para>Indicates whether the SQL execution is successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
