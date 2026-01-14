// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeBandwidthPackageAutoRenewAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether auto-renewal is enabled.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal duration. Unit: month. Valid values: <b>1</b> to <b>12</b>.</para>
        /// <remarks>
        /// <para> This parameter is returned only if the value of <b>AutoRenew</b> is <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

        /// <summary>
        /// <para>The ID of the bandwidth plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gbwp-bp1iquvlp8khla5emb3ia</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The auto-renewal status of the bandwidth plan.</para>
        /// <list type="bullet">
        /// <item><description><b>AutoRenewal</b>: The bandwidth plan is automatically renewed.</description></item>
        /// <item><description><b>Normal</b>: You must manually renew the bandwidth plan.</description></item>
        /// <item><description><b>NotRenewal</b>: The bandwidth plan is not renewed after it expires. The system sends a non-renewal reminder three days before the expiration date but no longer sends reminders to renew the bandwidth plan. You can change the auto-renewal status of a bandwidth plan from NotRenewal to <b>Normal</b> or <b>AutoRenewal</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> <b>RenewalStatus</b> takes precedence over <b>AutoRenew</b>. If you do not specify <b>RenewalStatus</b>, <b>AutoRenew</b> is automatically used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("RenewalStatus")]
        [Validation(Required=false)]
        public string RenewalStatus { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B820E9F9-D459-5AE7-8F08-A368B53C1AC3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
