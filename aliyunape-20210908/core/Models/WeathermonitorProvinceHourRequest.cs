// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliyunape20210908.Models
{
    public class WeathermonitorProvinceHourRequest : TeaModel {
        /// <summary>
        /// appName
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [NameInMap("ExtendParam")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExtendParam { get; set; }

        /// <summary>
        /// orderId
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
        /// 请求参数
        /// </summary>
        [NameInMap("ServiceParam")]
        [Validation(Required=false)]
        public Dictionary<string, string> ServiceParam { get; set; }

        /// <summary>
        /// UserId
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
