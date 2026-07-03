// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListTagsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of results to return when using NextToken-based pagination. Valid values: 1 to 100. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next query. Leave this parameter empty for the first query or if no more results exist. If a next query is available, set this parameter to the NextToken value returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The entity tags. The value is a JSON array string in the following format:</para>
        /// <para><c>&quot;[{&quot;tagKey1&quot;:&quot;tagValue1&quot;},{&quot;tagKey2&quot;:&quot;tagValue2&quot;}]&quot;</c></para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListTagsResponseBodyTags> Tags { get; set; }
        public class ListTagsResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The number of quick queries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The key of the tag to query. You can specify multiple keys. N is a positive integer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

    }

}
