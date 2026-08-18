// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class DescribeVersionConfigShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the region in which the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-guangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The Security Center SDK request.</para>
        /// </summary>
        [NameInMap("SdkRequest")]
        [Validation(Required=false)]
        public string SdkRequestShrink { get; set; }

    }

}
