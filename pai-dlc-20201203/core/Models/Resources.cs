// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class Resources : TeaModel {
        /// <summary>
        /// CPU核心数
        /// </summary>
        [NameInMap("CPU")]
        [Validation(Required=false)]
        public string CPU { get; set; }

        /// <summary>
        /// GPU卡数
        /// </summary>
        [NameInMap("GPU")]
        [Validation(Required=false)]
        public string GPU { get; set; }

        /// <summary>
        /// 内存大小
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public string Memory { get; set; }

    }

}
