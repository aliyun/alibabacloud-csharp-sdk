// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class ConnectorInfo : TeaModel {
        /// <summary>
        /// <para>Safe authentication identity</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("authentication")]
        [Validation(Required=false)]
        public ConnectorAuthentication Authentication { get; set; }

        /// <summary>
        /// <para>The list of capabilities granted to the Connector.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("capabilityGrants")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> CapabilityGrants { get; set; }

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
        /// <para>Creation time</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-25T12:00:00Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

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
        /// <para>Indicates whether the Connector is enabled.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>ETag</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;connector-rev-1&quot;</para>
        /// </summary>
        [NameInMap("etag")]
        [Validation(Required=false)]
        public string Etag { get; set; }

        /// <summary>
        /// <para>Digital employee name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>production-ops</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
        /// <para>Revision</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("revision")]
        [Validation(Required=false)]
        public long? Revision { get; set; }

        /// <summary>
        /// <para>The runtime configuration of the Connector.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public ConnectorRuntime Runtime { get; set; }

        /// <summary>
        /// <para>Resource status</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public Dictionary<string, object> Status { get; set; }

        /// <summary>
        /// <para>Provider target</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public Dictionary<string, object> Target { get; set; }

        /// <summary>
        /// <para>Update time</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-25T12:00:00Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
