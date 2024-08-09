// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ValidateSqlStatementRequest : TeaModel {
        /// <summary>
        /// The content of the code that you want to verify.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public SqlStatementWithContext Body { get; set; }

    }

}
