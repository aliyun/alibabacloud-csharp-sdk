// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateMetricRuleBlackListRequest : TeaModel {
        /// <summary>
        /// The category of the cloud service. For example, ApsaraDB for Redis includes the following categories: ApsaraDB for Redis (standard architecture), ApsaraDB for Redis (cluster architecture), and ApsaraDB for Redis (read/write splitting architecture). In this case, the valid values of this parameter for ApsaraDB for Redis include `kvstore_standard`, `kvstore_sharding`, and `kvstore_splitrw`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The time range within which the blacklist policy is effective.
        /// 
        /// *   If you do not configure this parameter, the blacklist policy is permanently effective.
        /// 
        /// *   If you configure this parameter, the blacklist policy is effective only within the specified time range. Examples:
        /// 
        ///     *   `03:00-04:59`: The blacklist policy is effective from 03:00 to 05:00 local time. 05:00 local time is excluded.
        ///     *   `03:00-04:59 UTC+0700`: The blacklist policy is effective from 03:00 to 05:00 (UTC+7). 05:00 (UTC+7) is excluded.
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// The timestamp when the blacklist policy expires.
        /// 
        /// Unit: milliseconds.
        /// </summary>
        [NameInMap("EnableEndTime")]
        [Validation(Required=false)]
        public string EnableEndTime { get; set; }

        /// <summary>
        /// The timestamp when the blacklist policy starts to take effect.
        /// 
        /// Unit: milliseconds.
        /// </summary>
        [NameInMap("EnableStartTime")]
        [Validation(Required=false)]
        public string EnableStartTime { get; set; }

        /// <summary>
        /// The IDs of the instances that belong to the specified cloud service.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<string> Instances { get; set; }

        /// <summary>
        /// The metrics of the instance.
        /// 
        /// *   If you do not configure this parameter, the blacklist policy applies to all metrics of the specified cloud service.
        /// *   If you configure this parameter, the blacklist policy applies only to the current metric.
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public List<CreateMetricRuleBlackListRequestMetrics> Metrics { get; set; }
        public class CreateMetricRuleBlackListRequestMetrics : TeaModel {
            /// <summary>
            /// The metric name.
            /// 
            /// Valid values of N: 1 to 10.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// The extended dimension of the instance. For example, `{"device":"C:"}` specifies that the blacklist policy is applied to all C disks of the specified Elastic Compute Service (ECS) instance.
            /// 
            /// Valid values of N: 1 to 10.
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

        }

        /// <summary>
        /// The name of the blacklist policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The namespace of the cloud service.
        /// 
        /// For more information about the namespaces of different cloud services, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The effective scope of the blacklist policy. Valid values:
        /// 
        /// *   USER (default): The blacklist policy takes effect only for the current Alibaba Cloud account.
        /// *   GROUP: The blacklist policy takes effect only for the specified application group. For information about how to query the IDs of application groups, see [DescribeMonitorGroups](https://help.aliyun.com/document_detail/115032.html).
        /// </summary>
        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

        /// <summary>
        /// The ID of the application group. The value of this parameter is a JSON array.
        /// 
        /// > This parameter must be specified when `ScopeType` is set to `GROUP`.
        /// </summary>
        [NameInMap("ScopeValue")]
        [Validation(Required=false)]
        public string ScopeValue { get; set; }

    }

}
