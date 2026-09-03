// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class SendVerifyCodeRequest : TeaModel {
        /// <summary>
        /// <para>The information required to send the verification code, in JSON format. When verifying a CEN instance, provide the CEN instance ID and the Alibaba Cloud account ID to which the CEN instance belongs.</para>
        /// <list type="bullet">
        /// <item><description>CenId: the CEN instance ID. </description></item>
        /// <item><description>CenOwnerId: the Alibaba Cloud account ID to which the CEN instance belongs.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the specified CenId belongs to the current Alibaba Cloud account, this parameter is not required. If the specified CenId belongs to a different Alibaba Cloud account, specify the Alibaba Cloud account ID of the owner.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;cenOwnerId&quot;: 1234567890******,&quot;cenId&quot;: &quot;cen-3weq30r6t0s7t4****&quot;}</para>
        /// </summary>
        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// <para>The region ID. Call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The action associated with the verification code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eds_cenID_securityverification</para>
        /// </summary>
        [NameInMap("VerifyCodeAction")]
        [Validation(Required=false)]
        public string VerifyCodeAction { get; set; }

    }

}
