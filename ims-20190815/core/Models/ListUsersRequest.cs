// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListUsersRequest : TeaModel {
        /// <summary>
        /// The `marker`. If part of a previous response is truncated, you can use this parameter to obtain the truncated part.
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// The number of entries per page. If a response is truncated because it reaches the value of `MaxItems`, the value of `IsTruncated` will be true.
        /// 
        /// Valid values: 1 to 1000. Default value: 1000.
        /// </summary>
        [NameInMap("MaxItems")]
        [Validation(Required=false)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// The tags. A maximum number of 20 tags are supported.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListUsersRequestTag> Tag { get; set; }
        public class ListUsersRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N.
            /// 
            /// Valid values of N: 1 to 20. N must be consecutive.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N.
            /// 
            /// Valid values of N: 1 to 20. N must be consecutive.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
