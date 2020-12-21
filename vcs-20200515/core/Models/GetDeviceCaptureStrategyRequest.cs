// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class GetDeviceCaptureStrategyRequest : TeaModel {
        /// <summary>
        /// 设备通道号
        /// </summary>
        [NameInMap("DeviceCode")]
        [Validation(Required=false)]
        public string DeviceCode { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [NameInMap("DeviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

    }

}
