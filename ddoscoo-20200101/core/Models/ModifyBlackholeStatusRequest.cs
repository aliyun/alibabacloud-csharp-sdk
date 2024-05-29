// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyBlackholeStatusRequest : TeaModel {
        /// <summary>
        /// The action that you want to perform on the instance. Set the value to **undo**, which indicates that you want to deactivate blackhole filtering.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BlackholeStatus")]
        [Validation(Required=false)]
        public string BlackholeStatus { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// > You can call the [DescribeInstanceIds](https://help.aliyun.com/document_detail/157459.html) operation to query the IDs of all instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
