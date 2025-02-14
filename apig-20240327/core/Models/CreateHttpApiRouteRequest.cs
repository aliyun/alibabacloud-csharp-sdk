// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateHttpApiRouteRequest : TeaModel {
        /// <summary>
        /// <para>Backend service configuration for the route.</para>
        /// </summary>
        [NameInMap("backendConfig")]
        [Validation(Required=false)]
        public CreateHttpApiRouteRequestBackendConfig BackendConfig { get; set; }
        public class CreateHttpApiRouteRequestBackendConfig : TeaModel {
            /// <summary>
            /// <para>Backend service scenario.</para>
            /// <list type="bullet">
            /// <item><description>SingleService: Single service.</description></item>
            /// <item><description>MultiServiceByRatio: Multiple services with ratio-based canary release.</description></item>
            /// <item><description>Mock: Mock service.</description></item>
            /// <item><description>Redirect: Redirect service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SingleService</para>
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>List of backend services.</para>
            /// </summary>
            [NameInMap("services")]
            [Validation(Required=false)]
            public List<CreateHttpApiRouteRequestBackendConfigServices> Services { get; set; }
            public class CreateHttpApiRouteRequestBackendConfigServices : TeaModel {
                /// <summary>
                /// <para>Service port, not provided for dynamic ports.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>Service protocol:</para>
                /// <list type="bullet">
                /// <item><description>HTTP.</description></item>
                /// <item><description>HTTPS.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>Service ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>svc-crbgq0dlhtgr***</para>
                /// </summary>
                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <para>Service version, valid only in label-based scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>Percentage value of traffic distribution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>49</para>
                /// </summary>
                [NameInMap("weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

        }

        /// <summary>
        /// <para>Route description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用户登陆路由。</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Domain IDs.</para>
        /// </summary>
        [NameInMap("domainIds")]
        [Validation(Required=false)]
        public List<string> DomainIds { get; set; }

        /// <summary>
        /// <para>Environment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-cpqnr6tlhtgubcv***</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <para>Route match rules.</para>
        /// </summary>
        [NameInMap("match")]
        [Validation(Required=false)]
        public HttpRouteMatch Match { get; set; }

        /// <summary>
        /// <para>Route name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>login</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
