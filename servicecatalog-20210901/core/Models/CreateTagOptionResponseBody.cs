// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class CreateTagOptionResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the details of the tag option.
        /// </summary>
        [NameInMap("TagOptionDetail")]
        [Validation(Required=false)]
        public CreateTagOptionResponseBodyTagOptionDetail TagOptionDetail { get; set; }
        public class CreateTagOptionResponseBodyTagOptionDetail : TeaModel {
            /// <summary>
            /// Indicates whether the tag option is enabled. Valid values:
            /// 
            /// *   true (default)
            /// *   false
            /// </summary>
            [NameInMap("Active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// The key of the tag option.
            /// 
            /// The key must be 1 to 128 characters in length. It cannot start with `aliyun` or `acs:` and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the tag option belongs.
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// The ID of the tag option.
            /// </summary>
            [NameInMap("TagOptionId")]
            [Validation(Required=false)]
            public string TagOptionId { get; set; }

            /// <summary>
            /// The value of the tag option.
            /// 
            /// The value must be 1 to 128 characters in length. It cannot start with `acs:` and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
