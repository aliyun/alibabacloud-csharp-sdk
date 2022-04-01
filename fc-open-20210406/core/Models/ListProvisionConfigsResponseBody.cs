// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListProvisionConfigsResponseBody : TeaModel {
        /// <summary>
        /// 下次查询的起始token
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 预留实例列表
        /// </summary>
        [NameInMap("provisionConfigs")]
        [Validation(Required=false)]
        public List<ListProvisionConfigsResponseBodyProvisionConfigs> ProvisionConfigs { get; set; }
        public class ListProvisionConfigsResponseBodyProvisionConfigs : TeaModel {
            /// <summary>
            /// 实际资源个数
            /// </summary>
            [NameInMap("current")]
            [Validation(Required=false)]
            public long? Current { get; set; }

            /// <summary>
            /// 预留实例创建失败时的错误信息
            /// </summary>
            [NameInMap("currentError")]
            [Validation(Required=false)]
            public string CurrentError { get; set; }

            /// <summary>
            /// 资源描述
            /// </summary>
            [NameInMap("resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// 定时策略配置
            /// </summary>
            [NameInMap("scheduledActions")]
            [Validation(Required=false)]
            public List<ScheduledActions> ScheduledActions { get; set; }

            /// <summary>
            /// 目标资源个数
            /// </summary>
            [NameInMap("target")]
            [Validation(Required=false)]
            public long? Target { get; set; }

            /// <summary>
            /// 指标追踪伸缩策略配置
            /// </summary>
            [NameInMap("targetTrackingPolicies")]
            [Validation(Required=false)]
            public List<TargetTrackingPolicies> TargetTrackingPolicies { get; set; }

        }

    }

}
