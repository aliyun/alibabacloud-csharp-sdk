// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListResourceHealthInspectionsResponseBody : TeaModel {
        [NameInMap("HealthInspections")]
        [Validation(Required=false)]
        public List<ListResourceHealthInspectionsResponseBodyHealthInspections> HealthInspections { get; set; }
        public class ListResourceHealthInspectionsResponseBodyHealthInspections : TeaModel {
            /// <summary>
            /// 应用名称。
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// 组件名称。
            /// </summary>
            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            /// <summary>
            /// 健康详细信息。
            /// </summary>
            [NameInMap("HealthMessage")]
            [Validation(Required=false)]
            public string HealthMessage { get; set; }

            /// <summary>
            /// 健康状态。
            /// </summary>
            [NameInMap("HealthStatus")]
            [Validation(Required=false)]
            public string HealthStatus { get; set; }

            /// <summary>
            /// 巡检项名称。
            /// </summary>
            [NameInMap("InspectionName")]
            [Validation(Required=false)]
            public string InspectionName { get; set; }

            /// <summary>
            /// 节点ID。
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// 节点名称。
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// 最近上报时间戳。
            /// </summary>
            [NameInMap("ReportTime")]
            [Validation(Required=false)]
            public long? ReportTime { get; set; }

            /// <summary>
            /// 规则名称。
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

        /// <summary>
        /// 本次请求所返回的最大记录条数。
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 返回读取到的数据位置，空代表数据已经读取完毕。
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 本次请求条件下的数据总量。
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
