// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class GrayTrafficWeight : TeaModel {
        /// <summary>
        /// <para>灰度版本号</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>流量权重比例（0.0-1.0）</para>
        /// </summary>
        [NameInMap("weight")]
        [Validation(Required=false)]
        public float? Weight { get; set; }

    }

}
