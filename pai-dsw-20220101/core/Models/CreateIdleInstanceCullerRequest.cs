// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class CreateIdleInstanceCullerRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("CpuPercentThreshold")]
        [Validation(Required=false)]
        public int? CpuPercentThreshold { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("GpuPercentThreshold")]
        [Validation(Required=false)]
        public int? GpuPercentThreshold { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("MaxIdleTimeInMinutes")]
        [Validation(Required=false)]
        public int? MaxIdleTimeInMinutes { get; set; }

    }

}
