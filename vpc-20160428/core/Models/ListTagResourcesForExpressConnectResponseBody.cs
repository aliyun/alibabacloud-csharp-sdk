// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListTagResourcesForExpressConnectResponseBody : TeaModel {
        /// <summary>
        /// The token that is used for the next query. Valid values:
        /// 
        /// *   If the return value of **NextToken** is empty, no next query is to be sent.
        /// *   If a value is returned for **NextToken**, the value is the token that is used for the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details about the tag.
        /// </summary>
        [NameInMap("TagResources")]
        [Validation(Required=false)]
        public ListTagResourcesForExpressConnectResponseBodyTagResources TagResources { get; set; }
        public class ListTagResourcesForExpressConnectResponseBodyTagResources : TeaModel {
            [NameInMap("TagResource")]
            [Validation(Required=false)]
            public List<ListTagResourcesForExpressConnectResponseBodyTagResourcesTagResource> TagResource { get; set; }
            public class ListTagResourcesForExpressConnectResponseBodyTagResourcesTagResource : TeaModel {
                /// <summary>
                /// The ID of the resource.
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// The type of the resource. The value is set to **PHYSICALCONNECTION**, which indicates the Express Connect circuit.
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// The key of the tag that is added to the resource.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The value of the tag that is added to the resource.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

    }

}
