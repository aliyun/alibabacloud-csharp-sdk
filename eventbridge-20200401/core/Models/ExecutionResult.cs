// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ExecutionResult : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RowCount")]
        [Validation(Required=false)]
        public int? RowCount { get; set; }

        [NameInMap("Rows")]
        [Validation(Required=false)]
        public string Rows { get; set; }

        [NameInMap("Schema")]
        [Validation(Required=false)]
        public List<SchemaColumn> Schema { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalRows")]
        [Validation(Required=false)]
        public int? TotalRows { get; set; }

    }

}
