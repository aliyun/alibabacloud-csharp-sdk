// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListTerraformProviderVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of records retrieved in a single request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. An empty value indicates that no more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rnD7wyAII+yDi0UGlV519J4dD+2BRJj42DLT6GrZysw=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>73588ebb-9d40-4660-a59f-764636ae6034</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of versions.</para>
        /// </summary>
        [NameInMap("versions")]
        [Validation(Required=false)]
        public List<ListTerraformProviderVersionsResponseBodyVersions> Versions { get; set; }
        public class ListTerraformProviderVersionsResponseBodyVersions : TeaModel {
            /// <summary>
            /// <para>The publish time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-24T05:06:51Z</para>
            /// </summary>
            [NameInMap("publishedTime")]
            [Validation(Required=false)]
            public string PublishedTime { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.242.0</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
