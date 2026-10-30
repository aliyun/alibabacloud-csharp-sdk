// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetListGpuClusterRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the region to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The time range to query. Unit: milliseconds. Format: [start,end]. Example: [13254125000, 52451241000].</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1757820000, 1757823600]</para>
        /// </summary>
        [NameInMap("timeRegion")]
        [Validation(Required=false)]
        public object TimeRegion { get; set; }

    }

}
