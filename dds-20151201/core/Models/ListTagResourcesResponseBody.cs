// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ListTagResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The token used to start the next query.</para>
        /// <remarks>
        /// <para> If not all results are returned in the first query, this parameter is returned. You can pass in the returned value of this parameter in the next query.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>212db86****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96017AF2-9AB1-4BC9-88D2-7966B3CD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TagResources")]
        [Validation(Required=false)]
        public ListTagResourcesResponseBodyTagResources TagResources { get; set; }
        public class ListTagResourcesResponseBodyTagResources : TeaModel {
            [NameInMap("TagResource")]
            [Validation(Required=false)]
            public List<ListTagResourcesResponseBodyTagResourcesTagResource> TagResource { get; set; }
            public class ListTagResourcesResponseBodyTagResourcesTagResource : TeaModel {
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

}
