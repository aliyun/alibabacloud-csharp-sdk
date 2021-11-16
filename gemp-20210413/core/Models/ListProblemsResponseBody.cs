// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListProblemsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListProblemsResponseBodyData> Data { get; set; }
        public class ListProblemsResponseBodyData : TeaModel {
            [NameInMap("affectServices")]
            [Validation(Required=false)]
            public List<ListProblemsResponseBodyDataAffectServices> AffectServices { get; set; }
            public class ListProblemsResponseBodyDataAffectServices : TeaModel {
                /// <summary>
                /// 服务描述
                /// </summary>
                [NameInMap("serviceDescription")]
                [Validation(Required=false)]
                public string ServiceDescription { get; set; }

                /// <summary>
                /// 影响服务ID
                /// </summary>
                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public long? ServiceId { get; set; }

                /// <summary>
                /// 服务名字
                /// </summary>
                [NameInMap("serviceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                /// <summary>
                /// 修改时间
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// 取消时间
            /// </summary>
            [NameInMap("cancelTime")]
            [Validation(Required=false)]
            public string CancelTime { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 发现时间
            /// </summary>
            [NameInMap("discoverTime")]
            [Validation(Required=false)]
            public string DiscoverTime { get; set; }

            /// <summary>
            /// 完结时间
            /// </summary>
            [NameInMap("finishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// 事件ID
            /// </summary>
            [NameInMap("incidentId")]
            [Validation(Required=false)]
            public long? IncidentId { get; set; }

            /// <summary>
            /// 是否手动
            /// </summary>
            [NameInMap("isManual")]
            [Validation(Required=false)]
            public bool? IsManual { get; set; }

            /// <summary>
            /// 是否升级
            /// </summary>
            [NameInMap("isUpgrade")]
            [Validation(Required=false)]
            public bool? IsUpgrade { get; set; }

            /// <summary>
            /// 主要处理人ID
            /// </summary>
            [NameInMap("mainHandlerId")]
            [Validation(Required=false)]
            public long? MainHandlerId { get; set; }

            /// <summary>
            /// 主要处理人名称
            /// </summary>
            [NameInMap("mainHandlerName")]
            [Validation(Required=false)]
            public string MainHandlerName { get; set; }

            /// <summary>
            /// 故障id
            /// </summary>
            [NameInMap("problemId")]
            [Validation(Required=false)]
            public long? ProblemId { get; set; }

            /// <summary>
            /// 故障等级 1=P1 2=P2 3=P3 4=P4
            /// </summary>
            [NameInMap("problemLevel")]
            [Validation(Required=false)]
            public string ProblemLevel { get; set; }

            /// <summary>
            /// 故障名称
            /// </summary>
            [NameInMap("problemName")]
            [Validation(Required=false)]
            public string ProblemName { get; set; }

            /// <summary>
            /// 故障编号
            /// </summary>
            [NameInMap("problemNumber")]
            [Validation(Required=false)]
            public string ProblemNumber { get; set; }

            /// <summary>
            /// 故障状态  HANDLING    处理中 RECOVERED  已恢复  REPLAYING   复盘中  REPLAYED     已复盘 CANCEL        已取消
            /// </summary>
            [NameInMap("problemStatus")]
            [Validation(Required=false)]
            public string ProblemStatus { get; set; }

            /// <summary>
            /// 恢复时间
            /// </summary>
            [NameInMap("recoveryTime")]
            [Validation(Required=false)]
            public string RecoveryTime { get; set; }

            /// <summary>
            /// 关联服务ID
            /// </summary>
            [NameInMap("relatedServiceId")]
            [Validation(Required=false)]
            public string RelatedServiceId { get; set; }

            /// <summary>
            /// 复盘时间
            /// </summary>
            [NameInMap("replayTime")]
            [Validation(Required=false)]
            public string ReplayTime { get; set; }

            /// <summary>
            /// 关联服务名称
            /// </summary>
            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// 修改时间
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// 当前页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
