// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeZonesRequest : TeaModel {
        /// <summary>
        /// <para>The file system type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>standard: General-purpose NAS. This is the default value.</description></item>
        /// <item><description>extreme: Extreme NAS.</description></item>
        /// <item><description>cpfs: Cloud Parallel File Storage.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("FileSystemType")]
        [Validation(Required=false)]
        public string FileSystemType { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the zone belongs. You can call the DescribeRegions operation to query the latest region list.</para>
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
