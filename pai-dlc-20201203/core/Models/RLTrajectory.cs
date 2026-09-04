// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLTrajectory : TeaModel {
        /// <summary>
        /// <para>The latest event millisecond UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787293215480</para>
        /// </summary>
        [NameInMap("LatestTimestampMs")]
        [Validation(Required=false)]
        public long? LatestTimestampMs { get; set; }

        /// <summary>
        /// <para>The trajectory ordinal number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SampleIndex")]
        [Validation(Required=false)]
        public string SampleIndex { get; set; }

        /// <summary>
        /// <para>The desired state. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>trained: Training is complete.</description></item>
        /// <item><description>Empty string: In progress.</description></item>
        /// </list>
        /// <para>The current frame does not perform oversampling, so discarded and cancelled do not occur.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trained</para>
        /// </summary>
        [NameInMap("TerminalState")]
        [Validation(Required=false)]
        public string TerminalState { get; set; }

        /// <summary>
        /// <para>The number of trace rows.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TraceCount")]
        [Validation(Required=false)]
        public long? TraceCount { get; set; }

    }

}
