// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateComputeResourceRequest : TeaModel {
        /// <summary>
        /// <para>The specific connection configuration information of the compute resource, including the endpoint, access identity, and environment context. The EnvType property of the compute resource environment is a member attribute of this object. Valid values include DEV (development environment) and PROD (production environment). The value is case-insensitive.</para>
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
        /// <para>The category of the added compute resource. Different types have different subtypes, which correspond to different parameter schema constraints. Examples: InstanceMode for instance mode and UrlMode for connection string mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceMode</para>
        /// </summary>
        [NameInMap("ConnectionPropertiesMode")]
        [Validation(Required=false)]
        public string ConnectionPropertiesMode { get; set; }

        /// <summary>
        /// <para>The description of the compute resource. The description can be up to 3,000 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hierarchical description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The compute resource ID.</para>
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
