// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class CreateNetworkReachableAnalysisRequest : TeaModel {
        /// <summary>
        /// The ID of the network path. You can call the [CreateNetworkPath](~~2366522~~) operation to obtain the ID of the network path.
        /// </summary>
        [NameInMap("NetworkPathId")]
        [Validation(Required=false)]
        public string NetworkPathId { get; set; }

        /// <summary>
        /// The ID of the region for which you want to create a task for analyzing network reachability.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The tags to add to the resource.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateNetworkReachableAnalysisRequestTag> Tag { get; set; }
        public class CreateNetworkReachableAnalysisRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag to add to the resource. The tag key can be up to 128 characters in length and cannot contain `http://` or `https://`. The tag key cannot start with `acs:` or `aliyun`.
            /// 
            /// You can add up to 20 tags in each call.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag to add to the resource. The tag value can be up to 128 characters in length and cannot contain `http://` or `https://`. The tag value cannot start with `acs:` or `aliyun`. The tag value can be an empty string.
            /// 
            /// You can add up to 20 tag values in each call.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
