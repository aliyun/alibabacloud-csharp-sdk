// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class TagResourcesResponseBody : TeaModel {
        /// <summary>
        /// The key of the tag that is attached to the resource.
        /// 
        /// *   If you want to configure this parameter, specify at least one tag key and at most 20 tag keys.
        /// *   This parameter is required.
        /// *   The tag key can be up to 128 characters in length. The tag key cannot start with acs: or aliyun or contain [http:// or https://.](http://或者https://。)
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
