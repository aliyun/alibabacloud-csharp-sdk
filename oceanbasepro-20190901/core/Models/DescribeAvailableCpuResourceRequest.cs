// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeAvailableCpuResourceRequest : TeaModel {
        /// <summary>
        /// The CPU resources available.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// ```
        /// http(s)://[Endpoint]/?Action=DescribeAvailableCpuResource
        /// &InstanceId=ob317v4uif****
        /// &TenantId=ob2mr3oae0****
        /// &ModifyType=update
        /// &Common request parameters
        /// ```
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        /// <summary>
        /// The operation that you want to perform.   
        /// Set the value to **DescribeAvailableCpuResource**.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
