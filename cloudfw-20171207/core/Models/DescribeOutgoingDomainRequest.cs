// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingDomainRequest : TeaModel {
        /// <summary>
        /// 分类, 枚举值.
        /// 默认值: 空
        /// 可选值: 
        /// All (全部分类)
        /// RiskDomain (风险域名分类)
        /// RiskIP (风险IP分类)
        /// AliYun (云产品分类)
        /// NotAliYun (非云产品分类)
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// 结束时间,Unix timestamp, 精确到秒
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 语言, 枚举值.
        /// 默认值: zh
        /// 可选值: en
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// 排序字段, 枚举值.
        /// 默认值: SessionCount
        /// 可选值: InBytes, OutBytes,TotalBytes,SessionCount
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// 每页条数, 不得超过100, 超过100会设置为100
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// 公网IP
        /// </summary>
        [NameInMap("PublicIP")]
        [Validation(Required=false)]
        public string PublicIP { get; set; }

        /// <summary>
        /// 顺序, 枚举值, 可选:asc, desc
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// 开始时间,Unix timestamp, 精确到秒
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
