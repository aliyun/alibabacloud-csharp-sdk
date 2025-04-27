// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCInstanceDdosCountRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("DdosRegionId")]
        [Validation(Required=false)]
        public string DdosRegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
