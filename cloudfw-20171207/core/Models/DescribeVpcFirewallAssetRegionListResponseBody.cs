// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallAssetRegionListResponseBody : TeaModel {
        [NameInMap("RegionNoList")]
        [Validation(Required=false)]
        public List<string> RegionNoList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>00933CCB-65A4-5E51-B180-3D154281****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
