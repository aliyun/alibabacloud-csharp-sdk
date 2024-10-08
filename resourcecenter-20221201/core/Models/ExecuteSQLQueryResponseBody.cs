// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ExecuteSQLQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The columns.</para>
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<ExecuteSQLQueryResponseBodyColumns> Columns { get; set; }
        public class ExecuteSQLQueryResponseBodyColumns : TeaModel {
            /// <summary>
            /// <para>The name of the column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>resource_id</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>varchar</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D696E6EF-3A6D-5770-801E-4982081FE4D0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array of search results.</para>
        /// </summary>
        [NameInMap("Rows")]
        [Validation(Required=false)]
        public List<object> Rows { get; set; }

    }

}
