// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribePolicyInstancesStatusResponseBody : TeaModel {
        [NameInMap("instances_severity_count")]
        [Validation(Required=false)]
        public Dictionary<string, object> InstancesSeverityCount { get; set; }

        /// <summary>
        /// 不同策略类型下的策略实例计数列表
        /// </summary>
        [NameInMap("policy_instances")]
        [Validation(Required=false)]
        public List<DescribePolicyInstancesStatusResponseBodyPolicyInstances> PolicyInstances { get; set; }
        public class DescribePolicyInstancesStatusResponseBodyPolicyInstances : TeaModel {
            [NameInMap("policy_category")]
            [Validation(Required=false)]
            public string PolicyCategory { get; set; }

            [NameInMap("policy_description")]
            [Validation(Required=false)]
            public string PolicyDescription { get; set; }

            [NameInMap("policy_instances_count")]
            [Validation(Required=false)]
            public long? PolicyInstancesCount { get; set; }

            [NameInMap("policy_name")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            [NameInMap("policy_severity")]
            [Validation(Required=false)]
            public string PolicySeverity { get; set; }

        }

    }

}
