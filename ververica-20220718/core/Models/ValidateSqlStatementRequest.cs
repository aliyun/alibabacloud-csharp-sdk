// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ValidateSqlStatementRequest : TeaModel {
        /// <summary>
        /// <para>The content of the code that you want to verify.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public SqlStatementWithContext Body { get; set; }

    }

}
