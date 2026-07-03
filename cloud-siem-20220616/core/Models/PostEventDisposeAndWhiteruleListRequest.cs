// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class PostEventDisposeAndWhiteruleListRequest : TeaModel {
        /// <summary>
        /// <para>A comma-separated list of response strategy IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12,13,14</para>
        /// </summary>
        [NameInMap("DisposeStrategyIds")]
        [Validation(Required=false)]
        public string DisposeStrategyIds { get; set; }

        /// <summary>
        /// <para>A JSON object that defines the incident response configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///       {
        ///             &quot;playbookName&quot;: &quot;WafBlockIP&quot;,
        ///             &quot;entityId&quot;: &quot;104466118&quot;,
        ///             &quot;scope&quot;: [
        ///                   &quot;176618589410****&quot;
        ///             ],
        ///             &quot;startTime&quot;: 1604168946281,
        ///             &quot;endTime&quot;: 1614168946281
        ///       },
        ///       {
        ///             &quot;playbookName&quot;: &quot;WafBlockIP&quot;,
        ///             &quot;entityId&quot;: &quot;104466118&quot;,
        ///             &quot;scope&quot;: [
        ///                   {
        ///                         &quot;instanceId&quot;: &quot;waf-cn-n6w1oy1****&quot;,
        ///                         &quot;domains&quot;: [
        ///                               &quot;lmfip.wafqax.***&quot;
        ///                         ]
        ///                   }
        ///             ],
        ///             &quot;startTime&quot;: 1604168946281,
        ///             &quot;endTime&quot;: 1614168946281
        ///       }
        /// ]</para>
        /// </summary>
        [NameInMap("EventDispose")]
        [Validation(Required=false)]
        public string EventDispose { get; set; }

        /// <summary>
        /// <para>The globally unique UUID of the incident.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
        /// </summary>
        [NameInMap("IncidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        /// <summary>
        /// <para>The UID of the incident owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890xxxxxx</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>A JSON object that defines the alert recipient configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;messageTitle&quot;: &quot;test&quot;,
        ///       &quot;receiver&quot;: &quot;xiaowang&quot;,
        ///       &quot;channel&quot;: &quot;message&quot;
        /// }</para>
        /// </summary>
        [NameInMap("ReceiverInfo")]
        [Validation(Required=false)]
        public string ReceiverInfo { get; set; }

        /// <summary>
        /// <para>The region where the Data Management service for threat analysis is deployed. Select a region based on where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Assets in the Chinese mainland or Hong Kong (China)</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Assets outside China</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>A note about the incident.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dealed</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The source of the response policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("ResponseSource")]
        [Validation(Required=false)]
        public string ResponseSource { get; set; }

        /// <summary>
        /// <para>The UID of the member whose perspective an administrator switches to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Current Alibaba Cloud account view</para>
        /// </description></item>
        /// <item><description><para>1: View for all accounts in your enterprise</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// <para>The incident status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Not handled</para>
        /// </description></item>
        /// <item><description><para>1: Handling</para>
        /// </description></item>
        /// <item><description><para>5: Failed</para>
        /// </description></item>
        /// <item><description><para>10: Handled</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The threat level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>serious: Important</para>
        /// </description></item>
        /// <item><description><para>suspicious: Medium</para>
        /// </description></item>
        /// <item><description><para>remind: Low</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>remind</para>
        /// </summary>
        [NameInMap("ThreatLevel")]
        [Validation(Required=false)]
        public string ThreatLevel { get; set; }

    }

}
