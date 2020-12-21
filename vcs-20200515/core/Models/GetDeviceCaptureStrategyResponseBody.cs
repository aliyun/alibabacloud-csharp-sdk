// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class GetDeviceCaptureStrategyResponseBody : TeaModel {
        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// 响应数据内容
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDeviceCaptureStrategyResponseBodyData Data { get; set; }
        public class GetDeviceCaptureStrategyResponseBodyData : TeaModel {
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }
            [NameInMap("DeviceCode")]
            [Validation(Required=false)]
            public string DeviceCode { get; set; }
            [NameInMap("MondayCaptureStrategy")]
            [Validation(Required=false)]
            public string MondayCaptureStrategy { get; set; }
            [NameInMap("TuesdayCaptureStrategy")]
            [Validation(Required=false)]
            public string TuesdayCaptureStrategy { get; set; }
            [NameInMap("WednesdayCaptureStrategy")]
            [Validation(Required=false)]
            public string WednesdayCaptureStrategy { get; set; }
            [NameInMap("ThursdayCaptureStrategy")]
            [Validation(Required=false)]
            public string ThursdayCaptureStrategy { get; set; }
            [NameInMap("FridayCaptureStrategy")]
            [Validation(Required=false)]
            public string FridayCaptureStrategy { get; set; }
            [NameInMap("SaturdayCaptureStrategy")]
            [Validation(Required=false)]
            public string SaturdayCaptureStrategy { get; set; }
            [NameInMap("SundayCaptureStrategy")]
            [Validation(Required=false)]
            public string SundayCaptureStrategy { get; set; }
        };

        /// <summary>
        /// RequestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
