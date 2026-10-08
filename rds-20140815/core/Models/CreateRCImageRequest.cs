// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateRCImageRequest : TeaModel {
        /// <summary>
        /// <para>The name of the custom image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Created_from_rc-vma9w5z699x9********</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The instance ID of the RDS Custom instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-vma9w5z699x93204****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call DescribeRegions to query the available regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The snapshot ID used to create the custom image. You can call DescribeRCSnapshots to query snapshot IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rcds-c9bjdl79vz5dx********</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

    }

}
