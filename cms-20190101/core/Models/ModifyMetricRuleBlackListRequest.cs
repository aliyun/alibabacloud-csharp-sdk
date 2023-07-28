// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifyMetricRuleBlackListRequest : TeaModel {
        /// <summary>
        /// The IDs of instances that belong to the specified cloud service. The value of this parameter is a JSON array.
        /// 
        /// Valid values of N: 1 to 20.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The ID of the application group. The value of this parameter is a JSON array.
        /// 
        /// >  This parameter is required only if the `ScopeType` parameter is set to `GROUP`.
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("EnableEndTime")]
        [Validation(Required=false)]
        public string EnableEndTime { get; set; }

        /// <summary>
        /// The effective scope of the blacklist policy. Valid values:
        /// 
        /// *   USER: The blacklist policy takes effect only for the current Alibaba Cloud account.
        /// 
        /// *   GROUP: The blacklist policy takes effect only for the specified application group. This is the default value.
        /// 
        ///     For information about how to obtain the ID of an application group, see [DescribeMonitorGroups](~~115032~~).
        /// </summary>
        [NameInMap("EnableStartTime")]
        [Validation(Required=false)]
        public string EnableStartTime { get; set; }

        /// <summary>
        /// The namespace of the cloud service.
        /// 
        /// For more information about the namespaces of different cloud services, see [Appendix 1: Metrics](~~163515~~).
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<string> Instances { get; set; }

        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public List<ModifyMetricRuleBlackListRequestMetrics> Metrics { get; set; }
        public class ModifyMetricRuleBlackListRequestMetrics : TeaModel {
            /// <summary>
            /// The ID of the blacklist policy.
            /// 
            /// For information about how to obtain the ID of a blacklist policy, see [DescribeMetricRuleBlackList](~~457257~~).
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// The categories of the Alibaba Cloud service. For example, ApsaraDB for Redis includes the following categories: ApsaraDB for Redis (standard architecture), ApsaraDB for Redis (cluster architecture), and ApsaraDB for Redis (read/write splitting architecture). In this case, the valid values of this parameter for ApsaraDB for Redis include `kvstore_standard`, `kvstore_sharding`, and `kvstore_splitrw`.
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

        }

        /// <summary>
        /// The timestamp when the blacklist policy starts to take effect.
        /// 
        /// Unit: milliseconds.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **ModifyMetricRuleBlackList**.
        /// </summary>
        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

        /// <summary>
        /// The extended dimension of the instance. For example, `{"device":"C:"}` specifies that the blacklist policy is applied to all C disks of the specified Elastic Compute Service (ECS) instance.
        /// 
        /// Valid values of N: 1 to 10
        /// </summary>
        [NameInMap("ScopeValue")]
        [Validation(Required=false)]
        public string ScopeValue { get; set; }

    }

}
