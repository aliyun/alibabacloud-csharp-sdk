// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class RLFlowSankeyExit : TeaModel {
        /// <summary>
        /// <para>The number of trajectories on the outflow edge.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The key of the outflow source column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataLoader</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The index of the outflow source column (0-based).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FromIdx")]
        [Validation(Required=false)]
        public int? FromIdx { get; set; }

        /// <summary>
        /// <para>The Chinese name of the outflow destination. Valid values vary by the column where the outflow is located: 在途·未下发 / 在途·生成中 / 在途·待采样 / 在途·待训练.</para>
        /// 
        /// <b>Example:</b>
        /// <para>生成轨迹</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

    }

}
