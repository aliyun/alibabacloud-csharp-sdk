// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeResourceStatisticByRegionRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the statistics include the number of shared cloud desktops.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeGroupDesktops")]
        [Validation(Required=false)]
        public bool? IncludeGroupDesktops { get; set; }

        /// <summary>
        /// <para>The ID of the service region. Valid values: China (Shanghai) and Singapore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the region to search. This parameter is used to filter cloud desktops in the specified region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("SearchRegionId")]
        [Validation(Required=false)]
        public string SearchRegionId { get; set; }

    }

}
