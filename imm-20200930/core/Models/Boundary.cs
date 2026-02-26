// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Boundary : TeaModel {
        /// <summary>
        /// <para>The height. Unit: pixel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public long? Height { get; set; }

        /// <summary>
        /// <para>The distance from the X-coordinate of the vertex to the left edge.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Left")]
        [Validation(Required=false)]
        public long? Left { get; set; }

        /// <summary>
        /// <para>The polygon formed by a number of points. This parameter takes effect only when the boundary describes a polygon rather than a rectangle.</para>
        /// <remarks>
        /// <para> This parameter is mutually exclusive to the following parameters that form a rectangle: Width, Height, Left, and Top. A boundary describes only a rectangle or a polygon.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Polygon")]
        [Validation(Required=false)]
        public List<PointInt64> Polygon { get; set; }

        /// <summary>
        /// <para>The distance from the Y-coordinate of the vertex to the top.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Top")]
        [Validation(Required=false)]
        public long? Top { get; set; }

        /// <summary>
        /// <para>The width. Unit: pixel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public long? Width { get; set; }

    }

}
