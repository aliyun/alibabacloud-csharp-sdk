// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class GetUserSpecialVersionGpuResourceInfoResponseBody : TeaModel {
        [NameInMap("GpuAvailableQuota")]
        [Validation(Required=false)]
        public long? GpuAvailableQuota { get; set; }

        [NameInMap("GpuTotalQuota")]
        [Validation(Required=false)]
        public long? GpuTotalQuota { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ResourceInfo> Resources { get; set; }

    }

}
