// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeCloudDiskTypesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the edge node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chongqing-cmcc</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        [NameInMap("EnsRegionIds")]
        [Validation(Required=false)]
        public string EnsRegionIdsShrink { get; set; }

    }

}
