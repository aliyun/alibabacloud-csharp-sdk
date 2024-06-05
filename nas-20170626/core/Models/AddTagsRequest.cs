// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class AddTagsRequest : TeaModel {
        /// <summary>
        /// The ID of the file system.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<AddTagsRequestTag> Tag { get; set; }
        public class AddTagsRequestTag : TeaModel {
            /// <summary>
            /// The key of each tag. The tag includes a TagKey and TagValue. You can add a maximum of 10 tags at a time. You must specify a TagKey. You can leave a TagValue empty.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of each tag. The tag includes a TagKey and TagValue. You can add a maximum of 10 tags at a time. You must specify a TagKey. You can leave a TagValue empty.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
