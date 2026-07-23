// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ExecutionResult : TeaModel {
        /// <summary>
        /// <para>Whether truncated due to the maxRows limit</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>Number of rows returned this time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RowCount")]
        [Validation(Required=false)]
        public int? RowCount { get; set; }

        /// <summary>
        /// <para>Two-dimensional array, one array per row</para>
        /// 
        /// <b>Example:</b>
        /// <para>[[&quot;北京&quot;,120],[&quot;上海&quot;,98]]</para>
        /// </summary>
        [NameInMap("Rows")]
        [Validation(Required=false)]
        public string Rows { get; set; }

        /// <summary>
        /// <para>Schema information</para>
        /// </summary>
        [NameInMap("Schema")]
        [Validation(Required=false)]
        public List<SchemaColumn> Schema { get; set; }

        /// <summary>
        /// <para>Total number of rows that meet the criteria. Different from RowCount when IsTruncated=true</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalRows")]
        [Validation(Required=false)]
        public int? TotalRows { get; set; }

    }

}
