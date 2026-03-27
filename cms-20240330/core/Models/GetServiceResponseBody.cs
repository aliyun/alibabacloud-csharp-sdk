// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>264C3E89-BE6E-5F82-A484-CE9C2196C7DC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Service object.</para>
        /// </summary>
        [NameInMap("service")]
        [Validation(Required=false)]
        public GetServiceResponseBodyService Service { get; set; }
        public class GetServiceResponseBodyService : TeaModel {
            /// <summary>
            /// <para>Extended information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;language&quot;:&quot;java&quot;}</para>
            /// </summary>
            [NameInMap("attributes")]
            [Validation(Required=false)]
            public string Attributes { get; set; }

            /// <summary>
            /// <para>Creation time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-13T03:32:55Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Description, only valid when serviceType=RUM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Display name, only valid when serviceType=RUM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo应用</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>Legacy ARMS application ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>by6rjzro2j@0fe8dfa799e5906</para>
            /// </summary>
            [NameInMap("pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// <para>Region ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-heyuan</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-aekxxzuad5zzzz</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cwzxvuc6uo@4bc6b15ad81f166174ffb</para>
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>Service name</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo-app</para>
            /// </summary>
            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>Service status, only valid when serviceType=RUM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("serviceStatus")]
            [Validation(Required=false)]
            public string ServiceStatus { get; set; }

            /// <summary>
            /// <para>Service type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TRACE</para>
            /// </summary>
            [NameInMap("serviceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<GetServiceResponseBodyServiceTags> Tags { get; set; }
            public class GetServiceResponseBodyServiceTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>env</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>prod</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Workspace name</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-cms-1106439496876715-cn-hangzhou</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

    }

}
