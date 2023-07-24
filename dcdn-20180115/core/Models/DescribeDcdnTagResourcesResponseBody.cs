// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnTagResourcesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The tag of the instance.
        /// </summary>
        [NameInMap("TagResources")]
        [Validation(Required=false)]
        public List<DescribeDcdnTagResourcesResponseBodyTagResources> TagResources { get; set; }
        public class DescribeDcdnTagResourcesResponseBodyTagResources : TeaModel {
            /// <summary>
            /// The ID of the resource.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The tags of the snapshot.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeDcdnTagResourcesResponseBodyTagResourcesTag> Tag { get; set; }
            public class DescribeDcdnTagResourcesResponseBodyTagResourcesTag : TeaModel {
                /// <summary>
                /// The key of the tag.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the tag.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
