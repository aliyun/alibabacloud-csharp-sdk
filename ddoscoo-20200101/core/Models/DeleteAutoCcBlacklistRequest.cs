// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DeleteAutoCcBlacklistRequest : TeaModel {
        /// <summary>
        /// The IP addresses that you want to manage. This parameter is a JSON string. The string contains the following fields:
        /// 
        /// *   **src**: the IP address. This field is required and must be of the STRING type.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Blacklist")]
        [Validation(Required=false)]
        public string Blacklist { get; set; }

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
