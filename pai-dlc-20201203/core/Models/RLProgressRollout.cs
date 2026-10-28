// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLProgressRollout : TeaModel {
        /// <summary>
        /// <para>The total number of completed items within the window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("Finished")]
        [Validation(Required=false)]
        public int? Finished { get; set; }

        /// <summary>
        /// <para>The rollout processed count.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Processed")]
        [Validation(Required=false)]
        public RLProgressProcessed Processed { get; set; }

        /// <summary>
        /// <para>The completion rate (items per minute), estimated from the last 120 completion events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31.2</para>
        /// </summary>
        [NameInMap("RatePerMin")]
        [Validation(Required=false)]
        public double? RatePerMin { get; set; }

    }

}
