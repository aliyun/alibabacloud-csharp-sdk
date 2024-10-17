// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeZonesRequest : TeaModel {
        /// <summary>
        /// <para>The type of the file system.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>standard (default): General-purpose NAS file system</description></item>
        /// <item><description>extreme: Extreme NAS file system</description></item>
        /// <item><description>cpfs: Cloud Parallel File Storage (CPFS) file system</description></item>
        /// </list>
        /// <remarks>
        /// <para>CPFS file systems are available only on the China site (aliyun.com).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("FileSystemType")]
        [Validation(Required=false)]
        public string FileSystemType { get; set; }

        /// <summary>
        /// <para>The ID of the region where you want to query zones.</para>
        /// <para>You can call the DescribeRegions operation to query the latest region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
