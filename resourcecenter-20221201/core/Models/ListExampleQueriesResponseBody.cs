// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ListExampleQueriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the sample query templates.</para>
        /// </summary>
        [NameInMap("ExampleQueries")]
        [Validation(Required=false)]
        public List<ListExampleQueriesResponseBodyExampleQueries> ExampleQueries { get; set; }
        public class ListExampleQueriesResponseBodyExampleQueries : TeaModel {
            /// <summary>
            /// <para>The description of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Queries all resources on which you have permissions and sorts the resources by resource type and resource ID.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Query of All Alibaba Cloud Resources</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sq-0PfKy****</para>
            /// </summary>
            [NameInMap("QueryId")]
            [Validation(Required=false)]
            public string QueryId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
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
        /// <para>D696E6EF-3A6D-5770-801E-4982081FE4D0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
