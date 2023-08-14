// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class GetIdleInstanceCullerResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CpuPercentThreshold")]
        [Validation(Required=false)]
        public int? CpuPercentThreshold { get; set; }

        [NameInMap("GpuPercentThreshold")]
        [Validation(Required=false)]
        public int? GpuPercentThreshold { get; set; }

        [NameInMap("IdleTimeInMinutes")]
        [Validation(Required=false)]
        public int? IdleTimeInMinutes { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("MaxIdleTimeInMinutes")]
        [Validation(Required=false)]
        public int? MaxIdleTimeInMinutes { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
