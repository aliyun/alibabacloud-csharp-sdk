// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliyunape20210908.Models
{
    public class WeatherforecastTimeRequest : TeaModel {
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
        /// 经度，范围为（70°E~139.96°E）
        /// </summary>
        [NameInMap("Lon")]
        [Validation(Required=false)]
        public string Lon { get; set; }

        /// <summary>
        /// 20210809090000
        /// </summary>
        [NameInMap("CurHour")]
        [Validation(Required=false)]
        public string CurHour { get; set; }

        /// <summary>
        /// 纬度，范围为（15°N~59.95°N
        /// </summary>
        [NameInMap("Lat")]
        [Validation(Required=false)]
        public string Lat { get; set; }

    }

}
