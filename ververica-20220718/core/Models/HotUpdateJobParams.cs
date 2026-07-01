// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class HotUpdateJobParams : TeaModel {
        /// <summary>
        /// <para>资源动态更新。</para>
        /// </summary>
        [NameInMap("rescaleJobParam")]
        [Validation(Required=false)]
        public RescaleJobParam RescaleJobParam { get; set; }

        /// <summary>
        /// <para>运行参数动态更新。</para>
        /// </summary>
        [NameInMap("updateJobConfigParam")]
        [Validation(Required=false)]
        public UpdateJobConfigParam UpdateJobConfigParam { get; set; }

    }

}
