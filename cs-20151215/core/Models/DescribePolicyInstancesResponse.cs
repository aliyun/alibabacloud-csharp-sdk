// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribePolicyInstancesResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=true)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=true)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=true)]
        public List<DescribePolicyInstancesResponseBody> Body { get; set; }
        public class DescribePolicyInstancesResponseBody : TeaModel {
            /// <summary>
            /// 策略实例实施者UID
            /// </summary>
            [NameInMap("ali_uid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// 目标集群ID
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// 规则实例名称
            /// </summary>
            [NameInMap("instance_name")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// 策略治理规则名称
            /// </summary>
            [NameInMap("policy_name")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// 策略类型名称
            /// </summary>
            [NameInMap("policy_category")]
            [Validation(Required=false)]
            public string PolicyCategory { get; set; }

            /// <summary>
            /// 规则模板描述
            /// </summary>
            [NameInMap("policy_description")]
            [Validation(Required=false)]
            public string PolicyDescription { get; set; }

            /// <summary>
            /// 当前规则实例的配置参数
            /// </summary>
            [NameInMap("policy_parameters")]
            [Validation(Required=false)]
            public string PolicyParameters { get; set; }

            /// <summary>
            /// 规则实例治理等级
            /// </summary>
            [NameInMap("policy_severity")]
            [Validation(Required=false)]
            public string PolicySeverity { get; set; }

            /// <summary>
            /// 策略实例实施范围： 默认"*"代表集群所有ns 否则返回作用namespaces名称，多个namespaces以逗号分隔
            /// </summary>
            [NameInMap("policy_scope")]
            [Validation(Required=false)]
            public string PolicyScope { get; set; }

            /// <summary>
            /// 规则治理动作  deny: 拦截违规部署  warn：告警
            /// </summary>
            [NameInMap("policy_action")]
            [Validation(Required=false)]
            public string PolicyAction { get; set; }

        }

    }

}
