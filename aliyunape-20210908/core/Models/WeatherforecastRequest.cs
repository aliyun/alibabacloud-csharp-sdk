// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliyunape20210908.Models
{
    public class WeatherforecastRequest : TeaModel {
        /// <summary>
        /// 纬度，范围为（15°N~59.95°N）
        /// </summary>
        [NameInMap("Lat")]
        [Validation(Required=false)]
        public string Lat { get; set; }

        /// <summary>
        /// 经度，范围为（70°E~139.96°E）
        /// </summary>
        [NameInMap("Lon")]
        [Validation(Required=false)]
        public string Lon { get; set; }

        /// <summary>
        /// 用户中心--我的订单--订单请求--实例名称：aliyunape_meteor12_public_cn-0ju2d2hh90b
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// yyyymmdd080000或yyyymmdd200000
        /// </summary>
        [NameInMap("StartForecast")]
        [Validation(Required=false)]
        public string StartForecast { get; set; }

    }

}
