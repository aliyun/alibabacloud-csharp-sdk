// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyHybridCloudSdkPullinStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/140857.html">DescribeInstanceInfo</a> operation to view the current WAF instance ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf-cn-7pp2le***01</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the SDK.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b3dbc5153317c79d8ca9f9***ea</para>
        /// </summary>
        [NameInMap("Mid")]
        [Validation(Required=false)]
        public string Mid { get; set; }

        /// <summary>
        /// <para>The status of traffic redirection. Valid values of the parameter:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enable</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: Disable</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("PullinStatus")]
        [Validation(Required=false)]
        public string PullinStatus { get; set; }

    }

}
