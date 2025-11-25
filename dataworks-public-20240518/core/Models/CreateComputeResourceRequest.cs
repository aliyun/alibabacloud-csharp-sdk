// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateComputeResourceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;EndpointMode&quot;: &quot;custom&quot;,     &quot;Database&quot;: &quot;testdb&quot;,     &quot;TaskSubmitter&quot;: &quot;1107550004253538&quot;,     &quot;InstanceId&quot;: &quot;hgprecn-cn-x0r3oun4k001&quot;,     &quot;SecurityProtocol&quot;: &quot;authTypeNone&quot;,     &quot;RegionId&quot;: &quot;cn-beijing&quot;,     &quot;EnvType&quot;: &quot;Prod&quot;,     &quot;AuthType&quot;: &quot;Executor&quot; }</para>
        /// </summary>
        [NameInMap("ConnectionProperties")]
        [Validation(Required=false)]
        public string ConnectionProperties { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ConnectionPropertiesMode")]
        [Validation(Required=false)]
        public string ConnectionPropertiesMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo_holo_cs</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_holo_cs</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hologres</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
