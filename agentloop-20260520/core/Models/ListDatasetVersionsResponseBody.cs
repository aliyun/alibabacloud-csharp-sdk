// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListDatasetVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of versions per page used for this query, which is not the actual number of versions returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. This parameter is returned when a next page exists. To query the next page, pass this value as is to nextToken. If this parameter is not returned or is empty, no next page exists. The example is for demonstration purposes only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>umaQfI7x758Ns4TgWrj8yA3fYlnk7dJgsfhMrSViRY8=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D17DE39E-6C62-50E3-9EB7-FDE41BB0D43D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of versions of the dataset, excluding deleted versions. This value is not limited by the current page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        /// <summary>
        /// <para>The list of historical versions of the dataset on the current page. An empty array is returned if no versions meet the conditions.</para>
        /// </summary>
        [NameInMap("versions")]
        [Validation(Required=false)]
        public List<ListDatasetVersionsResponseBodyVersions> Versions { get; set; }
        public class ListDatasetVersionsResponseBodyVersions : TeaModel {
            /// <summary>
            /// <para>The creation time of the version, in RFC 3339 format, including time zone information. For example, the Z in 2026-11-11T06:00:00Z indicates UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-11T06:00:00Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description provided when the version was created. If no description was provided, an empty string is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The dataset version used for the first evaluation</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the historical version, which corresponds to the name specified when the version was created. This value can be used as the version parameter for DeleteDatasetVersion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
