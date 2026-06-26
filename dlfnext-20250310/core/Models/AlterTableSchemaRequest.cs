// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class AlterTableSchemaRequest : TeaModel {
        /// <summary>
        /// <para>The table schema.</para>
        /// </summary>
        [NameInMap("schema")]
        [Validation(Required=false)]
        public Schema Schema { get; set; }

    }

}
