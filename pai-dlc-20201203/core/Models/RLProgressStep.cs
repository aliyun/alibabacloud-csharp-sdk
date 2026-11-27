// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLProgressStep : TeaModel {
        /// <summary>
        /// <para>The current step.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        /// <summary>
        /// <para>The estimated time remaining, in seconds. This value is not provided when it cannot be estimated. A value of 0 may be returned when the training is confirmed to be complete, even if PaceSec is not provided.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EtaSec")]
        [Validation(Required=false)]
        public long? EtaSec { get; set; }

        /// <summary>
        /// <para>The average time per step over the recent step progress, in seconds. This value is not provided when there is insufficient information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14</para>
        /// </summary>
        [NameInMap("PaceSec")]
        [Validation(Required=false)]
        public double? PaceSec { get; set; }

        /// <summary>
        /// <para>The training progress percentage. A value of 100% may be returned for confirmed completed progress, where Current may be less than Total. Do not determine whether the training is complete based solely on the current step number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Pct")]
        [Validation(Required=false)]
        public double? Pct { get; set; }

        /// <summary>
        /// <para>The timestamp of the latest step (in UNIX seconds).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487</para>
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        /// <summary>
        /// <para>The total number of steps (retrieved from the configuration dump).</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
