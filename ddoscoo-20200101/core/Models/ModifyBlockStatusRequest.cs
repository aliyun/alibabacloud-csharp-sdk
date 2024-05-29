// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyBlockStatusRequest : TeaModel {
        /// <summary>
        /// The blocking period. Valid values: **15** to **43200**. Unit: minutes.
        /// 
        /// > If you set **Status** to **do**, you must also specify this parameter.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// The ID of the Anti-DDoS Pro instance to manage.
        /// 
        /// > You can call the [DescribeInstanceIds](https://help.aliyun.com/document_detail/157459.html) operation to query the IDs of all instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// An array consisting of the Internet service provider (ISP) lines from which traffic is blocked.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Lines")]
        [Validation(Required=false)]
        public List<string> Lines { get; set; }

        /// <summary>
        /// Specifies the status of the Diversion from Origin Server policy. Valid values:
        /// 
        /// *   **do**: enables the policy.
        /// *   **undo**: disables the policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
