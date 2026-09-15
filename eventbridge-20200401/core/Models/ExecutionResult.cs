// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ExecutionResult : TeaModel {
        /// <summary>
        /// <para>Indicates whether the result is truncated because of the maxRows limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>The number of rows returned in this response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RowCount")]
        [Validation(Required=false)]
        public int? RowCount { get; set; }

        /// <summary>
        /// <para>A two-dimensional array where each row is an array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[[&quot;Beijing&quot;,120],[&quot;Shanghai&quot;,98]]</para>
        /// </summary>
        [NameInMap("Rows")]
        [Validation(Required=false)]
        public string Rows { get; set; }

        /// <summary>
        /// <para>The schema information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Name&quot;:&quot;event_date&quot;,&quot;Type&quot;:&quot;varchar&quot;}]</para>
        /// </summary>
        [NameInMap("Schema")]
        [Validation(Required=false)]
        public List<SchemaColumn> Schema { get; set; }

        /// <summary>
        /// <para>The total number of rows that match the condition. This value differs from RowCount when IsTruncated is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalRows")]
        [Validation(Required=false)]
        public int? TotalRows { get; set; }

    }

}
