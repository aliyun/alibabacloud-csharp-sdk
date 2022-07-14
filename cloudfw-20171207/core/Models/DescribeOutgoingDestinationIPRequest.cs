// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingDestinationIPRequest : TeaModel {
        /// <summary>
        /// 当前页
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// 目的IP
        /// </summary>
        [NameInMap("DstIP")]
        [Validation(Required=false)]
        public string DstIP { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 语言
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
        /// 每页大小
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// 端口号
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// 私网IP
        /// </summary>
        [NameInMap("PrivateIP")]
        [Validation(Required=false)]
        public string PrivateIP { get; set; }

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
