// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class PointInt64 : TeaModel {
        /// <summary>
        /// <para>The distance from the X-coordinate of the vertex to the left edge. Unit: pixel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("X")]
        [Validation(Required=false)]
        public long? X { get; set; }

        /// <summary>
        /// <para>The distance from the Y-coordinate of the vertex to the top. Unit: pixel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Y")]
        [Validation(Required=false)]
        public long? Y { get; set; }

    }

}
