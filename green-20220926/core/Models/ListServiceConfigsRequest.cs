// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class ListServiceConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The classification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>guard-scene</para>
        /// </summary>
        [NameInMap("Classify")]
        [Validation(Required=false)]
        public string Classify { get; set; }

        /// <summary>
        /// <para>The protection type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>modelProtection: model protection.</para>
        /// </description></item>
        /// <item><description><para>agentRealtimeProtection: agent real-time protection.</para>
        /// </description></item>
        /// <item><description><para>agentBehaviorAudit: agent behavior audit.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>modelProtection</para>
        /// </summary>
        [NameInMap("ProtectionType")]
        [Validation(Required=false)]
        public string ProtectionType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The usage status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>in</para>
        /// </summary>
        [NameInMap("UseStatus")]
        [Validation(Required=false)]
        public string UseStatus { get; set; }

    }

}
