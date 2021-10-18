// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliyunape20210908.Models
{
    public class StationDayRequest : TeaModel {
        /// <summary>
        /// UserId
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

        /// <summary>
        /// 用户中心--我的订单--订单请求--实例名称：aliyunape_meteor12_public_cn-0ju2d2hh90b
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 气象预测开始时间
        /// </summary>
        [NameInMap("StartForecast")]
        [Validation(Required=false)]
        public string StartForecast { get; set; }

        /// <summary>
        /// 全国站点（入参单一站点）
        /// </summary>
        [NameInMap("Station")]
        [Validation(Required=false)]
        public string Station { get; set; }

    }

}
