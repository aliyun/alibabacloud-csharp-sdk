// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GPUMetric : TeaModel {
        /// <summary>
        /// <para>The GPU index.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Index")]
        [Validation(Required=false)]
        public long? Index { get; set; }

        /// <summary>
        /// <para>The GPU model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NVIDIA V100</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The card status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0：异常；1：正常</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// <para>The GPU utilization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("UsageRate")]
        [Validation(Required=false)]
        public float? UsageRate { get; set; }

    }

}
