// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateComputeResourceRequest : TeaModel {
        /// <summary>
        /// <para>The specific connection configuration of the computing resource, including the connection address, access identity, and environment information. The environment for the computing resource is a member attribute of this object. It includes DEV (development environment) and PROD (production environment). The value for EnvType is case-insensitive.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;EndpointMode&quot;: &quot;custom&quot;,     &quot;Database&quot;: &quot;testdb&quot;,     &quot;TaskSubmitter&quot;: &quot;1107550004253538&quot;,     &quot;InstanceId&quot;: &quot;hgprecn-cn-x0r3oun4k001&quot;,     &quot;SecurityProtocol&quot;: &quot;authTypeNone&quot;,     &quot;RegionId&quot;: &quot;cn-beijing&quot;,     &quot;EnvType&quot;: &quot;Prod&quot;,     &quot;AuthType&quot;: &quot;Executor&quot; }</para>
        /// </summary>
        [NameInMap("ConnectionProperties")]
        [Validation(Required=false)]
        public string ConnectionProperties { get; set; }

        /// <summary>
        /// <para>Depending on the added source category, different types may have specific subtypes subject to distinct parameter constraints. For example, Hologres computing resources support InstanceMode and UrlMode.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceMode</para>
        /// </summary>
        [NameInMap("ConnectionPropertiesMode")]
        [Validation(Required=false)]
        public string ConnectionPropertiesMode { get; set; }

        /// <summary>
        /// <para>The description of the computing resource. The maximum length is 3000 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_holo_cs</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the computing resource. It can contain letters, digits, and underscores (_), cannot start with a digit or an underscore, and has a maximum length of 255 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_holo_cs</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The type of the computing resource. Multiple computing resource types are currently supported.</para>
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
