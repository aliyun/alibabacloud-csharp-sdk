// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceAutoRenewAttributeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically renew the instance before it expires.</para>
        /// <list type="bullet">
        /// <item><description>true: enables auto-renewal.</description></item>
        /// <item><description>false: disables auto-renewal.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal duration of the instance.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>When <c>PeriodUnit</c> is set to <c>Year</c>, the valid values of <c>Duration</c> are: {&quot;1&quot;, &quot;2&quot;, &quot;3&quot;, &quot;4&quot;, &quot;5&quot;}</description></item>
        /// <item><description>When <c>PeriodUnit</c> is set to <c>Month</c>, the valid values of <c>Duration</c> are: {&quot;1&quot;, &quot;2&quot;, &quot;3&quot;, &quot;6&quot;, &quot;12&quot;, &quot;24&quot;, &quot;36&quot;, &quot;48&quot;, &quot;60&quot;}</description></item>
        /// <item><description>When <c>PeriodUnit</c> is set to <c>Week</c>, the valid values of <c>Duration</c> are: {&quot;1&quot;, &quot;2&quot;, &quot;3&quot;, &quot;4&quot;}</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>When <c>PeriodUnit</c> is set to <c>Year</c>, the valid values of <c>Duration</c> are: {&quot;1&quot;, &quot;2&quot;, &quot;3&quot;, &quot;4&quot;, &quot;5&quot;}</description></item>
        /// <item><description>When <c>PeriodUnit</c> is set to <c>Month</c>, the valid values of <c>Duration</c> are: {&quot;1&quot;, &quot;2&quot;, &quot;3&quot;, &quot;6&quot;, &quot;12&quot;, &quot;24&quot;, &quot;36&quot;, &quot;48&quot;, &quot;60&quot;}</description></item>
        /// </list>
        /// <para>&lt;props=&quot;partner&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>When <c>PeriodUnit</c> is set to <c>Year</c>, the valid values of <c>Duration</c> are: {&quot;1&quot;, &quot;2&quot;, &quot;3&quot;, &quot;4&quot;, &quot;5&quot;}</description></item>
        /// <item><description>When <c>PeriodUnit</c> is set to <c>Month</c>, the valid values of <c>Duration</c> are: {&quot;1&quot;, &quot;2&quot;, &quot;3&quot;, &quot;6&quot;, &quot;12&quot;, &quot;24&quot;, &quot;36&quot;, &quot;48&quot;, &quot;60&quot;}</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>Instance ID. You can specify up to 100 subscription instances at a time. Separate multiple instance IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4ph****,i-bp67acfmxazb4pi****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The unit of the renewal duration, that is, the unit of the <c>Duration</c> parameter. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Week</description></item>
        /// <item><description>Month (default)</description></item>
        /// <item><description>Year</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Month (default)</description></item>
        /// <item><description>Year</description></item>
        /// </list>
        /// <para>&lt;props=&quot;partner&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>Month (default)</description></item>
        /// <item><description>Year</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to view the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The auto-renewal status of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AutoRenewal: enables auto-renewal.</para>
        /// </description></item>
        /// <item><description><para>Normal: disables auto-renewal.</para>
        /// </description></item>
        /// <item><description><para>NotRenewal: does not renew the instance. After this value is set, the system no longer sends expiration reminders and only sends a non-renewal reminder three days before the instance expires. ECS instances that are set to not renew can be changed to pending renewal (<c>Normal</c>), and then manually renewed or set to auto-renewal.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The <c>RenewalStatus</c> parameter takes precedence over the <c>AutoRenew</c> parameter. If the <c>RenewalStatus</c> parameter is not specified, the <c>AutoRenew</c> parameter takes effect by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AutoRenewal</para>
        /// </summary>
        [NameInMap("RenewalStatus")]
        [Validation(Required=false)]
        public string RenewalStatus { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
