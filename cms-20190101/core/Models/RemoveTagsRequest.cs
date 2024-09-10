// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class RemoveTagsRequest : TeaModel {
        /// <summary>
        /// The IDs of the application groups.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupIds")]
        [Validation(Required=false)]
        public List<string> GroupIds { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The tags.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<RemoveTagsRequestTag> Tag { get; set; }
        public class RemoveTagsRequestTag : TeaModel {
            /// <summary>
            /// The tag key.
            /// 
            /// > The tag key (`Tag.N.Key`) and tag value (`Tag.N.Value`) must be specified at the same time.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// 
            /// > The tag key (`Tag.N.Key`) and tag value (`Tag.N.Value`) must be specified at the same time.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
