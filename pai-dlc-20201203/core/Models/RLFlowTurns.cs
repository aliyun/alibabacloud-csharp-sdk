// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLFlowTurns : TeaModel {
        /// <summary>
        /// <para>平均生成轮数</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.9</para>
        /// </summary>
        [NameInMap("Avg")]
        [Validation(Required=false)]
        public double? Avg { get; set; }

        /// <summary>
        /// <para>参与统计的轨迹数</para>
        /// 
        /// <b>Example:</b>
        /// <para>96</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>最大生成轮数</para>
        /// 
        /// <b>Example:</b>
        /// <para>9.2</para>
        /// </summary>
        [NameInMap("Max")]
        [Validation(Required=false)]
        public int? Max { get; set; }

        /// <summary>
        /// <para>生成轮数 P50</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.8</para>
        /// </summary>
        [NameInMap("P50")]
        [Validation(Required=false)]
        public int? P50 { get; set; }

        /// <summary>
        /// <para>生成轮数 P90</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.9</para>
        /// </summary>
        [NameInMap("P90")]
        [Validation(Required=false)]
        public int? P90 { get; set; }

    }

}
