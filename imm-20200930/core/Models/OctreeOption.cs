// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class OctreeOption : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DoVoxelGridDownDownSampling")]
        [Validation(Required=false)]
        public bool? DoVoxelGridDownDownSampling { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pcl</para>
        /// </summary>
        [NameInMap("LibraryName")]
        [Validation(Required=false)]
        public string LibraryName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.01</para>
        /// </summary>
        [NameInMap("OctreeResolution")]
        [Validation(Required=false)]
        public double? OctreeResolution { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.01</para>
        /// </summary>
        [NameInMap("PointResolution")]
        [Validation(Required=false)]
        public double? PointResolution { get; set; }

    }

}
