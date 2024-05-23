// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeCharsetRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 实例的系列  - normal（默认）：标准集群版（云盘）  - normal_ssd：标准集群版（本地盘） - history：历史库集群版。
        /// </summary>
        [NameInMap("Series")]
        [Validation(Required=false)]
        public string Series { get; set; }

        /// <summary>
        /// The return result of the request.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TenantMode")]
        [Validation(Required=false)]
        public string TenantMode { get; set; }

    }

}
