// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class CreateInstanceShutdownTimerRequest : TeaModel {
        /// <summary>
        /// 定时关机设定时间
        /// </summary>
        [NameInMap("DueTime")]
        [Validation(Required=false)]
        public string DueTime { get; set; }

        /// <summary>
        /// 距离定时关机时间段
        /// </summary>
        [NameInMap("RemainingTimeInMs")]
        [Validation(Required=false)]
        public long? RemainingTimeInMs { get; set; }

    }

}
