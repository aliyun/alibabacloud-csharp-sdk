// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class ConnectorRuntime : TeaModel {
        /// <summary>
        /// <para>The native client capability referenced by the SATELLITE runtime. This parameter is mutually exclusive with extensionName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bash</para>
        /// </summary>
        [NameInMap("capabilityId")]
        [Validation(Required=false)]
        public string CapabilityId { get; set; }

        /// <summary>
        /// <para>The environment agent extension name referenced by the SATELLITE runtime. This parameter is mutually exclusive with capabilityId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gitlab-corp</para>
        /// </summary>
        [NameInMap("extensionName")]
        [Validation(Required=false)]
        public string ExtensionName { get; set; }

        /// <summary>
        /// <para>Runtime mode</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STAROPS_MANAGED</para>
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>Plugin ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>gitlab</para>
        /// </summary>
        [NameInMap("pluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>Satellite ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>satellite-private-runtime</para>
        /// </summary>
        [NameInMap("satelliteId")]
        [Validation(Required=false)]
        public string SatelliteId { get; set; }

    }

}
