// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class ConnectorCreateInput : TeaModel {
        /// <summary>
        /// <para>The authentication configuration used to access the target service.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("authentication")]
        [Validation(Required=false)]
        public ConnectorAuthenticationInput Authentication { get; set; }

        /// <summary>
        /// <para>The list of capabilities granted to the Connector.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("capabilityGrants")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> CapabilityGrants { get; set; }

        /// <summary>
        /// <para>Idempotency token</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8f73d0f4-3c8a-4eed-91e6-cf2f7ebcb3d7</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Provider configuration</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public Dictionary<string, object> Configuration { get; set; }

        /// <summary>
        /// <para>Connector name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cms2-prod</para>
        /// </summary>
        [NameInMap("connectorName")]
        [Validation(Required=false)]
        public string ConnectorName { get; set; }

        /// <summary>
        /// <para>Description</para>
        /// 
        /// <b>Example:</b>
        /// <para>Production observability data</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Display name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CMS 2.0 production workspace</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Connector after creation.</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The execution policy of the Connector.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("policy")]
        [Validation(Required=false)]
        public Dictionary<string, object> Policy { get; set; }

        /// <summary>
        /// <para>Provider</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AlibabaCloudCms</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The runtime configuration of the Connector.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public ConnectorRuntime Runtime { get; set; }

        /// <summary>
        /// <para>Provider target</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public Dictionary<string, object> Target { get; set; }

    }

}
