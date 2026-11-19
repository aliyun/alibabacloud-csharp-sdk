// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class ListServiceConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The category.</para>
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
        /// <item><description>modelProtection: model protection</description></item>
        /// <item><description>agentRealtimeProtection: real-time agent protection</description></item>
        /// <item><description>agentBehaviorAudit: agent behavior audit</description></item>
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
        /// <para>The resource type. This parameter is required. If you do not specify this parameter, the service returns a 400 error.</para>
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
