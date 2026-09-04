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
        /// <para>The estimated remaining seconds, calculated as (Total - Current) × PaceSec.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EtaSec")]
        [Validation(Required=false)]
        public long? EtaSec { get; set; }

        /// <summary>
        /// <para>The per-step duration, calculated as the differential between contiguous step marks, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14</para>
        /// </summary>
        [NameInMap("PaceSec")]
        [Validation(Required=false)]
        public double? PaceSec { get; set; }

        /// <summary>
        /// <para>The progress percentage, which is the ratio of Current to Total.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Pct")]
        [Validation(Required=false)]
        public double? Pct { get; set; }

        /// <summary>
        /// <para>The latest step mark time, in UNIX seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787474487</para>
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

        /// <summary>
        /// <para>The total number of steps, obtained from the configuration dump.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
