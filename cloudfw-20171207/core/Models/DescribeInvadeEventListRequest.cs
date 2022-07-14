// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInvadeEventListRequest : TeaModel {
        /// <summary>
        /// 资产IP
        /// </summary>
        [NameInMap("AssetsIP")]
        [Validation(Required=false)]
        public string AssetsIP { get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [NameInMap("AssetsInstanceId")]
        [Validation(Required=false)]
        public string AssetsInstanceId { get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [NameInMap("AssetsInstanceName")]
        [Validation(Required=false)]
        public string AssetsInstanceName { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 事件key
        /// </summary>
        [NameInMap("EventKey")]
        [Validation(Required=false)]
        public string EventKey { get; set; }

        /// <summary>
        /// 事件名称
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// 事件UUID
        /// </summary>
        [NameInMap("EventUuid")]
        [Validation(Required=false)]
        public string EventUuid { get; set; }

        /// <summary>
        /// 是否忽略
        /// </summary>
        [NameInMap("IsIgnore")]
        [Validation(Required=false)]
        public string IsIgnore { get; set; }

        /// <summary>
        /// 语言
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// 成员账号UID
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public long? MemberUid { get; set; }

        /// <summary>
        /// 每页多少条
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// 处理状态列表
        /// </summary>
        [NameInMap("ProcessStatusList")]
        [Validation(Required=false)]
        public List<int?> ProcessStatusList { get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public List<int?> RiskLevel { get; set; }

        /// <summary>
        /// 源IP
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
