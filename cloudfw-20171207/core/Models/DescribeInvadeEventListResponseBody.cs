// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInvadeEventListResponseBody : TeaModel {
        /// <summary>
        /// 事件列表
        /// </summary>
        [NameInMap("EventList")]
        [Validation(Required=false)]
        public List<DescribeInvadeEventListResponseBodyEventList> EventList { get; set; }
        public class DescribeInvadeEventListResponseBodyEventList : TeaModel {
            /// <summary>
            /// 资产实例ID
            /// </summary>
            [NameInMap("AssetsInstanceId")]
            [Validation(Required=false)]
            public string AssetsInstanceId { get; set; }

            /// <summary>
            /// 资产名称
            /// </summary>
            [NameInMap("AssetsInstanceName")]
            [Validation(Required=false)]
            public string AssetsInstanceName { get; set; }

            /// <summary>
            /// 资产类型
            /// </summary>
            [NameInMap("AssetsType")]
            [Validation(Required=false)]
            public string AssetsType { get; set; }

            /// <summary>
            /// CVE编号
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
            /// 事件来源
            /// </summary>
            [NameInMap("EventSrc")]
            [Validation(Required=false)]
            public string EventSrc { get; set; }

            /// <summary>
            /// 事件UUID
            /// </summary>
            [NameInMap("EventUuid")]
            [Validation(Required=false)]
            public string EventUuid { get; set; }

            /// <summary>
            /// 首次出现时间
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public int? FirstTime { get; set; }

            /// <summary>
            /// 是否忽略
            /// </summary>
            [NameInMap("IsIgnore")]
            [Validation(Required=false)]
            public bool? IsIgnore { get; set; }

            /// <summary>
            /// 最近一次时间
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public int? LastTime { get; set; }

            /// <summary>
            /// 成员账号UID
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// 私网IP
            /// </summary>
            [NameInMap("PrivateIP")]
            [Validation(Required=false)]
            public string PrivateIP { get; set; }

            /// <summary>
            /// 处理状态
            /// </summary>
            [NameInMap("ProcessStatus")]
            [Validation(Required=false)]
            public int? ProcessStatus { get; set; }

            /// <summary>
            /// 公网IP
            /// </summary>
            [NameInMap("PublicIP")]
            [Validation(Required=false)]
            public string PublicIP { get; set; }

            /// <summary>
            /// 公开类型
            /// </summary>
            [NameInMap("PublicIpType")]
            [Validation(Required=false)]
            public string PublicIpType { get; set; }

            /// <summary>
            /// 风险等级
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

        }

        /// <summary>
        /// 高风险等级比例
        /// </summary>
        [NameInMap("HighLevelPercent")]
        [Validation(Required=false)]
        public int? HighLevelPercent { get; set; }

        /// <summary>
        /// 低风险等级比例
        /// </summary>
        [NameInMap("LowLevelPercent")]
        [Validation(Required=false)]
        public int? LowLevelPercent { get; set; }

        /// <summary>
        /// 中风险等级比例
        /// </summary>
        [NameInMap("MiddleLevelPercent")]
        [Validation(Required=false)]
        public int? MiddleLevelPercent { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeInvadeEventListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeInvadeEventListResponseBodyPageInfo : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
