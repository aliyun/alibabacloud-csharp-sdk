// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class QueryFeaturesRequest : TeaModel {
        /// <summary>
        /// <para>The AgentTeams instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>at-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The target resource name. Required for <c>WORKER</c>, <c>TEAM</c>, and <c>HUMAN</c>. Not required for <c>INSTANCE</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>worker-a</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The query target type: <c>INSTANCE</c> / <c>WORKER</c> / <c>TEAM</c> / <c>HUMAN</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE</para>
        /// </summary>
        [NameInMap("TargetScope")]
        [Validation(Required=false)]
        public string TargetScope { get; set; }

    }

}
