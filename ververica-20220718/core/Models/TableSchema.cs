// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class TableSchema : TeaModel {
        /// <summary>
        /// <para>The ID of the collect sink operator.</para>
        /// </summary>
        [NameInMap("collectSinkOperatorId")]
        [Validation(Required=false)]
        public string CollectSinkOperatorId { get; set; }

        /// <summary>
        /// <para>The schema of the table.</para>
        /// </summary>
        [NameInMap("schema")]
        [Validation(Required=false)]
        public Schema Schema { get; set; }

        /// <summary>
        /// <para>The name of the table.</para>
        /// </summary>
        [NameInMap("tableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
