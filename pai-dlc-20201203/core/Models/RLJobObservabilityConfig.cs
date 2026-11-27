// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLJobObservabilityConfig : TeaModel {
        /// <summary>
        /// <para>是否开启 Ray Dashboard 入口。Ray 后端缺省 true，Monarch 后端缺省 false；Monarch 不接受 true</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RayDashboardEnabled")]
        [Validation(Required=false)]
        public bool? RayDashboardEnabled { get; set; }

        /// <summary>
        /// <para>是否启用训练观测数据采集，默认 true。</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("XfuseEnabled")]
        [Validation(Required=false)]
        public bool? XfuseEnabled { get; set; }

    }

}
