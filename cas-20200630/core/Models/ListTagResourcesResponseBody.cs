// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class ListTagResourcesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTagResourcesResponseBodyData Data { get; set; }
        public class ListTagResourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>24262</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("TagResources")]
            [Validation(Required=false)]
            public ListTagResourcesResponseBodyDataTagResources TagResources { get; set; }
            public class ListTagResourcesResponseBodyDataTagResources : TeaModel {
                [NameInMap("TagResources")]
                [Validation(Required=false)]
                public List<ListTagResourcesResponseBodyDataTagResourcesTagResources> TagResources { get; set; }
                public class ListTagResourcesResponseBodyDataTagResourcesTagResources : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cas-upload-xgjcng</para>
                    /// </summary>
                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ALIYUN::CAS::PCACERTIFICATE</para>
                    /// </summary>
                    [NameInMap("ResourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PVDCDC</para>
                    /// </summary>
                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2D69A58F-345C-4FDE-88E4-BF5189484043</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
