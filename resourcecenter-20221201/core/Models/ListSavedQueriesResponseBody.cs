// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ListSavedQueriesResponseBody : TeaModel {
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
        /// <para>AAAAARfZmVDe9NvRXloR5+8CK9nNJufMdRA7W1miLC1P****</para>
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

        /// <summary>
        /// <para>The information about the custom query templates.</para>
        /// </summary>
        [NameInMap("SavedQueries")]
        [Validation(Required=false)]
        public List<ListSavedQueriesResponseBodySavedQueries> SavedQueries { get; set; }
        public class ListSavedQueriesResponseBodySavedQueries : TeaModel {
            /// <summary>
            /// <para>The time when the template was created. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-13T05:50:35Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

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
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Query of All Alibaba Cloud Resources</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sq-GeAck****</para>
            /// </summary>
            [NameInMap("QueryId")]
            [Validation(Required=false)]
            public string QueryId { get; set; }

            /// <summary>
            /// <para>The time when the template was updated. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-14 10:27:07</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
