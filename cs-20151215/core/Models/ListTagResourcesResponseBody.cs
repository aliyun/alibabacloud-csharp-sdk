// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListTagResourcesResponseBody : TeaModel {
        /// <summary>
        /// 资源标签列表。
        /// </summary>
        [NameInMap("tag_resources")]
        [Validation(Required=false)]
        public ListTagResourcesResponseBodyTagResources TagResources { get; set; }
        public class ListTagResourcesResponseBodyTagResources : TeaModel {
            [NameInMap("next_token")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
            [NameInMap("request_id")]
            [Validation(Required=false)]
            public string RequestId { get; set; }
            [NameInMap("tag_resource")]
            [Validation(Required=false)]
            public ListTagResourcesResponseBodyTagResourcesTagResource TagResource { get; set; }
            public class ListTagResourcesResponseBodyTagResourcesTagResource : TeaModel {
                /// <summary>
                /// 资源ID。
                /// </summary>
                [NameInMap("resource_id")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// 资源类型
                /// </summary>
                [NameInMap("resource_type")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// 标签key。
                /// </summary>
                [NameInMap("tag_key")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// 标签值。
                /// </summary>
                [NameInMap("tag_value")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }
        };

    }

}
