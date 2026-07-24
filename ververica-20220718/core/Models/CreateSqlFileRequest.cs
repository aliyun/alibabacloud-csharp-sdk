// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class CreateSqlFileRequest : TeaModel {
        /// <summary>
        /// <para>The request body, which contains the SQL file content and related metadata to be created.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public SqlFile Body { get; set; }

    }

}
