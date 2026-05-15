// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class WindowLimit : TeaModel {
        /// <summary>
        /// <para>限流时间窗口的持续时间，单位为秒</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("durationSecs")]
        [Validation(Required=false)]
        public long? DurationSecs { get; set; }

        /// <summary>
        /// <para>在指定时间窗口内允许的最大请求数量</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

    }

}
