// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnTagResourcesResponseBody : TeaModel {
        /// <summary>
        /// >  You can call this operation up to 10 times per second per account.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Queries the tags of one or more resources.
        /// </summary>
        [NameInMap("TagResources")]
        [Validation(Required=false)]
        public List<DescribeDcdnTagResourcesResponseBodyTagResources> TagResources { get; set; }
        public class DescribeDcdnTagResourcesResponseBodyTagResources : TeaModel {
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeDcdnTagResourcesResponseBodyTagResourcesTag> Tag { get; set; }
            public class DescribeDcdnTagResourcesResponseBodyTagResourcesTag : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
