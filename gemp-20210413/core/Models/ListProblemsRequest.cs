// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListProblemsRequest : TeaModel {
        /// <summary>
        /// 影响服务ID
        /// </summary>
        [NameInMap("affectServiceId")]
        [Validation(Required=false)]
        public long? AffectServiceId { get; set; }

        /// <summary>
        /// 幂等号
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 发现结束时间
        /// </summary>
        [NameInMap("discoveryEndTime")]
        [Validation(Required=false)]
        public string DiscoveryEndTime { get; set; }

        /// <summary>
        /// 发现开始时间
        /// </summary>
        [NameInMap("discoveryStartTime")]
        [Validation(Required=false)]
        public string DiscoveryStartTime { get; set; }

        /// <summary>
        /// 主要处理人
        /// </summary>
        [NameInMap("mainHandlerId")]
        [Validation(Required=false)]
        public long? MainHandlerId { get; set; }

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
        /// 故障等级 1=P1 2=P2 3=P3 4=P4
        /// </summary>
        [NameInMap("problemLevel")]
        [Validation(Required=false)]
        public string ProblemLevel { get; set; }

        /// <summary>
        /// 故障状态  HANDLING   处理中 RECOVERED 已恢复  REPLAYING   复盘中  REPLAYED     已复盘 CANCEL        已取消
        /// </summary>
        [NameInMap("problemStatus")]
        [Validation(Required=false)]
        public string ProblemStatus { get; set; }

        /// <summary>
        /// RESPONSIBLE 我负责的       PARTICIPATED 我参与的  ALL 全部
        /// </summary>
        [NameInMap("queryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// 复盘负责人
        /// </summary>
        [NameInMap("repeaterId")]
        [Validation(Required=false)]
        public long? RepeaterId { get; set; }

        /// <summary>
        /// 恢复结束时间
        /// </summary>
        [NameInMap("restoreEndTime")]
        [Validation(Required=false)]
        public string RestoreEndTime { get; set; }

        /// <summary>
        /// 恢复开始时间
        /// </summary>
        [NameInMap("restoreStartTime")]
        [Validation(Required=false)]
        public string RestoreStartTime { get; set; }

        /// <summary>
        /// 应急协同组
        /// </summary>
        [NameInMap("serviceGroupId")]
        [Validation(Required=false)]
        public long? ServiceGroupId { get; set; }

    }

}
