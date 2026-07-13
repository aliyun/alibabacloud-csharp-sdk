// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmInstanceStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of unavailable addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AddrNotAvailableNum")]
        [Validation(Required=false)]
        public int? AddrNotAvailableNum { get; set; }

        /// <summary>
        /// <para>The number of unavailable address pools.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AddrPoolNotAvailableNum")]
        [Validation(Required=false)]
        public int? AddrPoolNotAvailableNum { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>389DFFA3-77A5-4A9E-BF3D-147C6F98A5BA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ALLOW: Operations are allowed.</para>
        /// </description></item>
        /// <item><description><para>DENY: Operations are denied.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALLOW</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>A list of reasons for the instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>INSTANCE_OPERATE_BLACK_LIST: The instance is in a blacklist.</para>
        /// </description></item>
        /// <item><description><para>BETA_INSTANCE: The instance is in public preview.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;BETA_INSTANCE&quot;]</para>
        /// </summary>
        [NameInMap("StatusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        /// <summary>
        /// <para>The number of access policies for which the active address pool is unavailable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("StrategyNotAvailableNum")]
        [Validation(Required=false)]
        public int? StrategyNotAvailableNum { get; set; }

        /// <summary>
        /// <para>The number of access policies that are switched to the failover address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SwitchToFailoverStrategyNum")]
        [Validation(Required=false)]
        public int? SwitchToFailoverStrategyNum { get; set; }

    }

}
