// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ModifyRenderingInstanceBandwidthRequest : TeaModel {
        /// <summary>
        /// <para>The maximum outbound bandwidth for rate limiting. Unit: Mbit/s. You must specify at least one of MaxIngressBandwidth and MaxEgressBandwidth.</para>
        /// <list type="bullet">
        /// <item><description><para>By default, no rate limit is configured for the instance.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter or set it to 0, the last configuration is retained.</para>
        /// </description></item>
        /// <item><description><para>If you set this parameter to a value less than 0, the rate limit is reset to unlimited.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxEgressBandwidth")]
        [Validation(Required=false)]
        public int? MaxEgressBandwidth { get; set; }

        /// <summary>
        /// <para>The maximum inbound bandwidth for rate limiting. Unit: Mbit/s. You must specify at least one of MaxIngressBandwidth and MaxEgressBandwidth.</para>
        /// <list type="bullet">
        /// <item><description><para>By default, no rate limit is configured for the instance.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter or set it to 0, the last configuration is retained.</para>
        /// </description></item>
        /// <item><description><para>If you set this parameter to a value less than 0, the rate limit is reset to unlimited.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxIngressBandwidth")]
        [Validation(Required=false)]
        public int? MaxIngressBandwidth { get; set; }

        /// <summary>
        /// <para>The ID of the cloud application service instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

    }

}
