// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class StartSqlExecutionRequest : TeaModel {
        /// <summary>
        /// <para>The request body, which contains the SQL content to execute and description information.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public StartSqlExecutionBody Body { get; set; }

    }

}
