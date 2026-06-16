// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class ListTagResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTagResourcesResponseBodyData Data { get; set; }
        public class ListTagResourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The maximum number of entries returned for this call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token that is used to start the next query. If this parameter is empty, no more results exist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24262</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The tag resources.</para>
            /// </summary>
            [NameInMap("TagResources")]
            [Validation(Required=false)]
            public ListTagResourcesResponseBodyDataTagResources TagResources { get; set; }
            public class ListTagResourcesResponseBodyDataTagResources : TeaModel {
                [NameInMap("TagResources")]
                [Validation(Required=false)]
                public List<ListTagResourcesResponseBodyDataTagResourcesTagResources> TagResources { get; set; }
                public class ListTagResourcesResponseBodyDataTagResourcesTagResources : TeaModel {
                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    [NameInMap("ResourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D69A58F-345C-4FDE-88E4-BF5189484043</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
