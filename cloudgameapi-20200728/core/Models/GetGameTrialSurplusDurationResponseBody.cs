// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class GetGameTrialSurplusDurationResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public float? Status { get; set; }

        /// <summary>
        /// 剩余试玩时长
        /// </summary>
        [NameInMap("SurplusDuration")]
        [Validation(Required=false)]
        public double? SurplusDuration { get; set; }

    }

}
