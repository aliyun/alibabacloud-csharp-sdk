// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetComputeResourceResponseBody : TeaModel {
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public GetComputeResourceResponseBodyComputeResource ComputeResource { get; set; }
        public class GetComputeResourceResponseBodyComputeResource : TeaModel {
            /// <summary>
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
            public object ConnectionProperties { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>InstanceMode</para>
            /// </summary>
            [NameInMap("ConnectionPropertiesMode")]
            [Validation(Required=false)]
            public string ConnectionPropertiesMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1698286929333</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1107550004253538</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>My Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>16738</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1698286929333</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1107550004253538</para>
            /// </summary>
            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MyCs</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>52660</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1107550004253538:cn-beijing:holo:hgprecn-cn-x0r3oun4k001:testdb</para>
            /// </summary>
            [NameInMap("QualifiedName")]
            [Validation(Required=false)]
            public string QualifiedName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hologres</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("WhetherDefault")]
            [Validation(Required=false)]
            public bool? WhetherDefault { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9252F32F-D855-549E-8898-61CF5A733050</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
