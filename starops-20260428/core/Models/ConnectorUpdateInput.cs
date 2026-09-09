// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class ConnectorUpdateInput : TeaModel {
        /// <summary>
        /// <para>The authentication configuration used to replace the existing credentials.</para>
        /// </summary>
        [NameInMap("authentication")]
        [Validation(Required=false)]
        public ConnectorAuthenticationUpdateInput Authentication { get; set; }

        /// <summary>
        /// <para>The list of capabilities used to replace the existing grants.</para>
        /// </summary>
        [NameInMap("capabilityGrants")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> CapabilityGrants { get; set; }

        /// <summary>
        /// <para>The provider configuration used to update the Connector. Only AlibabaCloudResources allows null. Other providers must provide an object.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public Dictionary<string, object> Configuration { get; set; }

        /// <summary>
        /// <para>The description of the Connector.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Production observability data</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the Connector.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CMS 2.0 production workspace</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Connector.</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The execution policy used to replace the existing policy.</para>
        /// </summary>
        [NameInMap("policy")]
        [Validation(Required=false)]
        public Dictionary<string, object> Policy { get; set; }

        /// <summary>
        /// <para>The runtime configuration used to update the Connector.</para>
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public ConnectorRuntime Runtime { get; set; }

        /// <summary>
        /// <para>The provider target used to update the Connector.</para>
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public Dictionary<string, object> Target { get; set; }

    }

}
