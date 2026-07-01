// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class SqlStatement : TeaModel {
        /// <summary>
        /// <para>The index of the SQL statement.</para>
        /// </summary>
        [NameInMap("index")]
        [Validation(Required=false)]
        public int? Index { get; set; }

        /// <summary>
        /// <para>The message returned for the SQL statement.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The SQL script content.</para>
        /// </summary>
        [NameInMap("sqlScript")]
        [Validation(Required=false)]
        public string SqlScript { get; set; }

        /// <summary>
        /// <para>The status of the SQL statement.</para>
        /// </summary>
        [NameInMap("statusState")]
        [Validation(Required=false)]
        public string StatusState { get; set; }

        /// <summary>
        /// <para>The type of the SQL statement.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
