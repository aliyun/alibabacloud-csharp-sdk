// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleBlackListResponseBody : TeaModel {
        /// <summary>
        /// The categories of the Alibaba Cloud service. For example, ApsaraDB for Redis includes the following categories: ApsaraDB for Redis (standard architecture), ApsaraDB for Redis (cluster architecture), and ApsaraDB for Redis (read/write splitting architecture). In this case, the valid values of this parameter for ApsaraDB for Redis include `kvstore_standard`, `kvstore_sharding`, and `kvstore_splitrw`.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The timestamp when the blacklist policy started to take effect.
        /// 
        /// Unit: milliseconds.
        /// </summary>
        [NameInMap("DescribeMetricRuleBlackList")]
        [Validation(Required=false)]
        public List<DescribeMetricRuleBlackListResponseBodyDescribeMetricRuleBlackList> DescribeMetricRuleBlackList { get; set; }
        public class DescribeMetricRuleBlackListResponseBodyDescribeMetricRuleBlackList : TeaModel {
            /// <summary>
            /// The name of the blacklist policy.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The metrics of the instance.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The extended dimension of the instance. For example, `{"device":"C:"}` specifies that the blacklist policy is applied to all C disks of the specified Elastic Compute Service (ECS) instance.
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// The number of entries to return on each page.
            /// 
            /// Default value: 10.
            /// </summary>
            [NameInMap("EnableEndTime")]
            [Validation(Required=false)]
            public long? EnableEndTime { get; set; }

            /// <summary>
            /// The ID of the application group. The value of this parameter is a JSON array.
            /// 
            /// >  This parameter is returned only if the `ScopeType` parameter is set to `GROUP`.
            /// </summary>
            [NameInMap("EnableStartTime")]
            [Validation(Required=false)]
            public long? EnableStartTime { get; set; }

            /// <summary>
            /// The timestamp when the blacklist policy was modified.
            /// 
            /// Unit: milliseconds.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<string> Instances { get; set; }

            /// <summary>
            /// The total number of blacklist policies.
            /// </summary>
            [NameInMap("IsEnable")]
            [Validation(Required=false)]
            public bool? IsEnable { get; set; }

            /// <summary>
            /// The method that is used to sort query results by time. Valid values:
            /// 
            /// *   DESC (default): descending order
            /// *   ASC: ascending order
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public List<DescribeMetricRuleBlackListResponseBodyDescribeMetricRuleBlackListMetrics> Metrics { get; set; }
            public class DescribeMetricRuleBlackListResponseBodyDescribeMetricRuleBlackListMetrics : TeaModel {
                /// <summary>
                /// For more information about common request parameters, see [Common parameters](~~199331~~).
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public string Resource { get; set; }

            }

            /// <summary>
            /// The status of the blacklist policy. Valid values:
            /// 
            /// *   true: The blacklist policy is enabled.
            /// *   false: The blacklist policy is disabled.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The number of the page to return.
            /// 
            /// Default value: 1.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The IDs of instances that belong to the specified cloud service.
            /// </summary>
            [NameInMap("ScopeType")]
            [Validation(Required=false)]
            public string ScopeType { get; set; }

            [NameInMap("ScopeValue")]
            [Validation(Required=false)]
            public List<string> ScopeValue { get; set; }

            /// <summary>
            /// The ID of the blacklist policy.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The namespace of the cloud service.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The namespace of the cloud service.
        /// 
        /// For more information about the namespaces of different cloud services, see [Appendix 1: Metrics](~~163515~~).
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The timestamp when the blacklist policy was created.
        /// 
        /// Unit: milliseconds.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
