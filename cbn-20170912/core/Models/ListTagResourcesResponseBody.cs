// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTagResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The token that determines the start point of the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> was not returned, it indicates that no additional results exist.</description></item>
        /// <item><description>If <b>NextToken</b> was returned in the previous query, specify the value to obtain the next set of results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>165B5C86-2033-5954-A89D-4CD83BA06C85</para>
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
