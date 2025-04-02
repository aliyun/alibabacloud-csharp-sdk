// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ExecuteMultiAccountSQLQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The columns.</para>
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<ExecuteMultiAccountSQLQueryResponseBodyColumns> Columns { get; set; }
        public class ExecuteMultiAccountSQLQueryResponseBodyColumns : TeaModel {
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

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJzZWFyY2hBZnRlcnMiOlsiMTAwMTU2Nzk4MTU1OSJd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44C8A952-D6B0-5BC8-82D5-93BA02E26F2E</para>
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
