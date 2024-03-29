// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsInstanceInServiceListRequest : TeaModel {
        [NameInMap("NeedResourceInfo")]
        [Validation(Required=false)]
        public bool? NeedResourceInfo { get; set; }

        /// <summary>
        /// The list of tags that are attached to the instance. A maximum of 20 tags can be included in a list.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<OnsInstanceInServiceListRequestTag> Tag { get; set; }
        public class OnsInstanceInServiceListRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag that is attached to the instance you want to query. This parameter is not required. If you configure this parameter, you must also configure the **Value** parameter.**** If you include the Key and Value parameters in a request, this operation queries only the instances that use the specified tags. If you do not include these parameters in a request, this operation queries all instances that you can access.
            /// 
            /// *   The value of this parameter cannot be an empty string.
            /// *   The tag value must be 1 to 128 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag that is attached to the instance you want to query. This parameter is not required. If you configure this parameter, you must also configure the **Value** parameter.**** If you include the Key and Value parameters in a request, this operation queries only the instances that use the specified tags. If you do not include these parameters in a request, this operation queries all instances that you can access.
            /// 
            /// *   The value of this parameter can be an empty string.
            /// *   The tag key must be 1 to 128 characters in length and cannot contain `http://` or `https://`. It cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
