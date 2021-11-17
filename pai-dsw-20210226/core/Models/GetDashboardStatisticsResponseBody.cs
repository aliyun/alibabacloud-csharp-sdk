// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class GetDashboardStatisticsResponseBody : TeaModel {
        /// <summary>
        /// 实例数
        /// </summary>
        [NameInMap("InstanceTotal")]
        [Validation(Required=false)]
        public long? InstanceTotal { get; set; }

        /// <summary>
        /// 运行实例数
        /// </summary>
        [NameInMap("InstsanceRunningTotal")]
        [Validation(Required=false)]
        public long? InstsanceRunningTotal { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
