// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateOrUpdateSwimmingLaneShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the gateway route.</para>
        /// <remarks>
        /// <para>This parameter is required if the gateway entry application for the swimlane group is a Java application.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AppEntryRule")]
        [Validation(Required=false)]
        public string AppEntryRuleShrink { get; set; }

        /// <summary>
        /// <para>The end-to-end canary release mode.</para>
        /// <list type="bullet">
        /// <item><description><para><c>0</c>: content-based routing</para>
        /// </description></item>
        /// <item><description><para><c>1</c>: percentage-based routing</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CanaryModel")]
        [Validation(Required=false)]
        public int? CanaryModel { get; set; }

        /// <summary>
        /// <para>The status of the swimlane.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: enabled</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: disabled</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The ID of the swimlane group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b2a8a925-477a-eswa-b823-d5e22500****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the swimlane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13857</para>
        /// </summary>
        [NameInMap("LaneId")]
        [Validation(Required=false)]
        public long? LaneId { get; set; }

        /// <summary>
        /// <para>The name of the swimlane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("LaneName")]
        [Validation(Required=false)]
        public string LaneName { get; set; }

        /// <summary>
        /// <para>The tag of the swimlane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>g1</para>
        /// </summary>
        [NameInMap("LaneTag")]
        [Validation(Required=false)]
        public string LaneTag { get; set; }

        /// <summary>
        /// <para>Configuration for the MSE gateway route.</para>
        /// <remarks>
        /// <para>This parameter is required if the <b>EntryAppType</b> parameter is set to <b>apig</b> or <b>mse-gw</b>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("MseGatewayEntryRule")]
        [Validation(Required=false)]
        public string MseGatewayEntryRuleShrink { get; set; }

        /// <summary>
        /// <para>The ID of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

    }

}
