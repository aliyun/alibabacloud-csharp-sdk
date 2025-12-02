// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateOrUpdateSwimmingLaneShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The route configuration of the gateway.</para>
        /// <remarks>
        /// <para> This parameter is required if the gateway entry of the lane group is Java.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AppEntryRule")]
        [Validation(Required=false)]
        public string AppEntryRuleShrink { get; set; }

        /// <summary>
        /// <para>Full-link Grayscale Mode:</para>
        /// <list type="bullet">
        /// <item><description>0: The request is routed based on the content of the request.</description></item>
        /// <item><description>1: routing based on percentages</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CanaryModel")]
        [Validation(Required=false)]
        public int? CanaryModel { get; set; }

        /// <summary>
        /// <para>Lane Status</para>
        /// <list type="bullet">
        /// <item><description>true: enabled</description></item>
        /// <item><description>false: disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The ID of the lane group to which the lane belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b2a8a925-477a-eswa-b823-d5e22500****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the lane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13857</para>
        /// </summary>
        [NameInMap("LaneId")]
        [Validation(Required=false)]
        public long? LaneId { get; set; }

        /// <summary>
        /// <para>The name of the lane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("LaneName")]
        [Validation(Required=false)]
        public string LaneName { get; set; }

        /// <summary>
        /// <para>The tag of the lane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;alicloud.service.tag&quot;:&quot;g1&quot;}</para>
        /// </summary>
        [NameInMap("LaneTag")]
        [Validation(Required=false)]
        public string LaneTag { get; set; }

        /// <summary>
        /// <para>The route configuration of the MSE gateway.</para>
        /// <remarks>
        /// <para> If the <b>EntryAppType</b> is set to <b>apig</b> or <b>mse-gw</b>, it is required.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("MseGatewayEntryRule")]
        [Validation(Required=false)]
        public string MseGatewayEntryRuleShrink { get; set; }

        /// <summary>
        /// <para>The namespace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

    }

}
