// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class CreateTagsRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// >  Only `cn-hangzhou` is supported.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The tag keys and values list.
        /// </summary>
        [NameInMap("TagKeyValueParamList")]
        [Validation(Required=false)]
        public List<CreateTagsRequestTagKeyValueParamList> TagKeyValueParamList { get; set; }
        public class CreateTagsRequestTagKeyValueParamList : TeaModel {
            /// <summary>
            /// The description of the tag key.
            /// 
            /// Valid values of N: 1 to 10.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The tag key.
            /// 
            /// The tag key can be a maximum of 128 characters in length. It cannot contain `http://` or `https://` and cannot start with `acs:` or `aliyun`.
            /// 
            /// Valid values of N: 1 to 10.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag values list.
            /// </summary>
            [NameInMap("TagValueParamList")]
            [Validation(Required=false)]
            public List<CreateTagsRequestTagKeyValueParamListTagValueParamList> TagValueParamList { get; set; }
            public class CreateTagsRequestTagKeyValueParamListTagValueParamList : TeaModel {
                /// <summary>
                /// The description of the tag value.
                /// 
                /// Valid values of N: 1 to 10.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The tag value.
                /// 
                /// The tag value can be a maximum of 128 characters in length. It cannot contain `http://` or `https://` and cannot start with `acs:` or `aliyun`.
                /// 
                /// Valid values of N: 1 to 10.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
