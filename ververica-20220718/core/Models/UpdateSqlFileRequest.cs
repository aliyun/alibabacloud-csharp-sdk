// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class UpdateSqlFileRequest : TeaModel {
        /// <summary>
        /// <para>The SQL script information to update.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public SqlFile Body { get; set; }

    }

}
