// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class TriggerPatrolRequest : TeaModel {
        /// <summary>
        /// <para>The inspection scope configuration.</para>
        /// </summary>
        [NameInMap("scopeConfig")]
        [Validation(Required=false)]
        public TriggerPatrolRequestScopeConfig ScopeConfig { get; set; }
        public class TriggerPatrolRequestScopeConfig : TeaModel {
            /// <summary>
            /// <para>The list of deployment IDs. This parameter is valid only when scopeType is set to DEPLOYMENTS.</para>
            /// </summary>
            [NameInMap("deploymentIds")]
            [Validation(Required=false)]
            public List<string> DeploymentIds { get; set; }

            /// <summary>
            /// <para>The tag mapping. This parameter is valid only when scopeType is set to TAGS. The key is the tag name, and the value is a list of tag values.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> Tags { get; set; }

        }

        /// <summary>
        /// <para>The inspection scope type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("scopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

    }

}
