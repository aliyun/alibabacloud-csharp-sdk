// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeFilesystemsAssociatedHpnZonesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The collection of file system IDs.</para>
        /// <remarks>
        /// <para> The maximum number of elements in the set must be less than or equal to 20.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Filesystems")]
        [Validation(Required=false)]
        public string FilesystemsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the region where the file system resides.</para>
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
