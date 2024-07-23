// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class SendVerifyCodeRequest : TeaModel {
        /// <summary>
        /// <para>The information that is required to send the verification code, in JSON format. When you verify the CEN instance of another Alibaba Cloud account, you must provide the ID of the CEN instance and the ID of the Alibaba Cloud account to which the instance belongs.</para>
        /// <list type="bullet">
        /// <item><description>CenId: the ID of the CEN instance.</description></item>
        /// <item><description>CenOwnerId: the ID of the Alibaba Cloud account to which the CEN instance belongs.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you own the CEN instance, skip this parameter. If you do not own the CEN instance, specify the ID of the Alibaba Cloud account that owns the CEN instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;cenOwnerId&quot;: 1234567890******,&quot;cenId&quot;: &quot;cen-3weq30r6t0s7t4****&quot;}</para>
        /// </summary>
        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The action that you want to perform by using the verification code.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>eds_cenID_securityverification: Use the verification code to verify the CEN instance.</description></item>
        /// </list>
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
