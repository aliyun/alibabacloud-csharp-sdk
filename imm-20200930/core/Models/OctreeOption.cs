// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class OctreeOption : TeaModel {
        /// <summary>
        /// <para>Specifies whether to downsample the point cloud file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The point cloud file is downsampled, and the coordinates of the points in a voxel are replaced with the coordinates of the center point of the voxel. The average color of all points in the voxel is used as the color of the voxel. In this case, the PointResolution parameter does not take effect.</description></item>
        /// <item><description>false: Specific coordinates and colors in a voxel are encoded by calculating the offsets from each point to the lower-left corner of the voxel. The offsets are divided by the PointResolution value to obtain the integer coordinates. The residual of the color for each point relative to the average color of all points in the voxel is encoded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DoVoxelGridDownDownSampling")]
        [Validation(Required=false)]
        public bool? DoVoxelGridDownDownSampling { get; set; }

        /// <summary>
        /// <para>The library name. Set the value to pcl. Default value: pcl.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pcl</para>
        /// </summary>
        [NameInMap("LibraryName")]
        [Validation(Required=false)]
        public string LibraryName { get; set; }

        /// <summary>
        /// <para>The minimum block size when an octree is partitioned. The minimum block size indicates the edge length of a voxel. Default value: 0.01.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.01</para>
        /// </summary>
        [NameInMap("OctreeResolution")]
        [Validation(Required=false)]
        public double? OctreeResolution { get; set; }

        /// <summary>
        /// <para>The point cloud resolution. This parameter determines the precision of the point coordinates during encoding. Default value: 0.01.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.01</para>
        /// </summary>
        [NameInMap("PointResolution")]
        [Validation(Required=false)]
        public double? PointResolution { get; set; }

    }

}
