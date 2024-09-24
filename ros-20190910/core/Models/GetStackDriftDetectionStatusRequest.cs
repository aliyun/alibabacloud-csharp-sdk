// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackDriftDetectionStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the drift detection operation.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/155098.html">ListStackResourceDrifts</a> operation to obtain the ID of the drift detection operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a7044f0d-6f2e-4128-a307-4524ef88****</para>
        /// </summary>
        [NameInMap("DriftDetectionId")]
        [Validation(Required=false)]
        public string DriftDetectionId { get; set; }

        /// <summary>
        /// <para>The region ID of the stack to be detected for drift.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
