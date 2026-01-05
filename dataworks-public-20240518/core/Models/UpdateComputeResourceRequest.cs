// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateComputeResourceRequest : TeaModel {
        /// <summary>
        /// <para>The specific connection configuration of the computing resource, including the connection address, access identity, and environment information. The environment type (EnvType) of the computing resource is a member attribute of this object, including DEV (development environment) and PROD (production environment). The value is not case-sensitive.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;envType&quot;: &quot;Prod&quot;,
        ///     &quot;regionId&quot;: &quot;cn-beijing&quot;,
        ///     &quot;instanceId&quot;: &quot;hgprecn-cn-x0r3oun4k001&quot;,
        ///     &quot;database&quot;: &quot;testdb&quot;,
        ///     &quot;securityProtocol&quot;: &quot;authTypeNone&quot;,
        ///     &quot;authType&quot;: &quot;Executor&quot;,
        ///     &quot;authIdentity&quot;: &quot;1107550004253538&quot;
        /// }</para>
        /// </summary>
        [NameInMap("ConnectionProperties")]
        [Validation(Required=false)]
        public string ConnectionProperties { get; set; }

        /// <summary>
        /// <para>The category of the computing resource to be added. Different types have different subtypes and corresponding parameter schema constraints. Examples: InstanceMode and UrlMode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceMode</para>
        /// </summary>
        [NameInMap("ConnectionPropertiesMode")]
        [Validation(Required=false)]
        public string ConnectionPropertiesMode { get; set; }

        /// <summary>
        /// <para>The description of the computing resource. The maximum length is 3000 characters.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the computing resource.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
