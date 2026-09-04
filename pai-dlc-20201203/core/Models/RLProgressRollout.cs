// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLProgressRollout : TeaModel {
        /// <summary>
        /// <para>窗口内完成总数</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("Finished")]
        [Validation(Required=false)]
        public int? Finished { get; set; }

        /// <summary>
        /// <para>rollout 已处理计数</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Processed")]
        [Validation(Required=false)]
        public RLProgressProcessed Processed { get; set; }

        /// <summary>
        /// <para>完成速率（条/分钟），由最近 120 条完成事件估算</para>
        /// 
        /// <b>Example:</b>
        /// <para>31.2</para>
        /// </summary>
        [NameInMap("RatePerMin")]
        [Validation(Required=false)]
        public double? RatePerMin { get; set; }

    }

}
