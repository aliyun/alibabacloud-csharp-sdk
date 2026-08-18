// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class CreateSasTrialShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The region ID of the access control instance. You can call the DescribeRegions operation to query the region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
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
