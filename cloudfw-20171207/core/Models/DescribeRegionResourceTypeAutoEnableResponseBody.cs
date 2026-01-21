// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeRegionResourceTypeAutoEnableResponseBody : TeaModel {
        [NameInMap("RegionResourceAutoEnable")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> RegionResourceAutoEnable { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>B2841452-CB8D-4F7D-B247-38E1CF7334F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
