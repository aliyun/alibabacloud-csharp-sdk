// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ExecuteScriptRequest : TeaModel {
        /// <summary>
        /// Indicates whether the SQL statement is executed.
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public int? DbId { get; set; }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("Logic")]
        [Validation(Required=false)]
        public bool? Logic { get; set; }

        /// <summary>
        /// Specifies whether the database is a logical database.
        /// </summary>
        [NameInMap("Script")]
        [Validation(Required=false)]
        public string Script { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **ExecuteScript**.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
