// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyHybridCloudSdkPullinStatusRequest : TeaModel {
        /// <summary>
        /// The ID of the WAF instance.
        /// 
        /// >  You can call the [DescribeInstanceInfo](https://help.aliyun.com/document_detail/140857.html) operation to query the ID of the WAF instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the SDK.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Mid")]
        [Validation(Required=false)]
        public string Mid { get; set; }

        /// <summary>
        /// The status of traffic redirection. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PullinStatus")]
        [Validation(Required=false)]
        public string PullinStatus { get; set; }

    }

}
