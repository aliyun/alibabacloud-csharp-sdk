// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribePolicyInstancesRequest : TeaModel {
        /// <summary>
        /// 策略实例名称
        /// </summary>
        [NameInMap("instance_name")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 策略类型
        /// </summary>
        [NameInMap("policy_name")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

    }

}
