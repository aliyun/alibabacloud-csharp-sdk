// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class PostEventDisposeAndWhiteruleListRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of event handling. The value is a JSON object.</para>
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
        /// <para>The UUID of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
        /// </summary>
        [NameInMap("IncidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        /// <summary>
        /// <para>The configuration of the alert recipient. The value is a JSON object.</para>
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
        /// <para>The region in which the data management center of the threat analysis feature resides. Specify this parameter based on the regions in which your assets reside. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Your assets reside in regions in China.</description></item>
        /// <item><description>ap-southeast-1: Your assets reside in regions outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The remarks of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dealed</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The ID of the account that you switch from the management account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The type of the view. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: the current Alibaba Cloud account</description></item>
        /// <item><description>1: the global account</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// <para>The status of the event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: unhandled</description></item>
        /// <item><description>1: handing</description></item>
        /// <item><description>5: handling failed</description></item>
        /// <item><description>10: handled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("ThreatLevel")]
        [Validation(Required=false)]
        public string ThreatLevel { get; set; }

    }

}
