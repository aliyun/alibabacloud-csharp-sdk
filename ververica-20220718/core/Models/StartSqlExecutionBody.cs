// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class StartSqlExecutionBody : TeaModel {
        /// <summary>
        /// <para>The description of the SQL execution.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The SQL file ID.</para>
        /// </summary>
        [NameInMap("sqlFileId")]
        [Validation(Required=false)]
        public string SqlFileId { get; set; }

        /// <summary>
        /// <para>The SQL script content.</para>
        /// </summary>
        [NameInMap("sqlScript")]
        [Validation(Required=false)]
        public string SqlScript { get; set; }

    }

}
