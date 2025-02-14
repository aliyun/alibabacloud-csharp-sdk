// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateHttpApiRouteRequest : TeaModel {
        /// <summary>
        /// <para>Backend service configuration for the route.</para>
        /// </summary>
        [NameInMap("backendConfig")]
        [Validation(Required=false)]
        public UpdateHttpApiRouteRequestBackendConfig BackendConfig { get; set; }
        public class UpdateHttpApiRouteRequestBackendConfig : TeaModel {
            /// <summary>
            /// <para>Backend service scenario.</para>
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
            public List<UpdateHttpApiRouteRequestBackendConfigServices> Services { get; set; }
            public class UpdateHttpApiRouteRequestBackendConfigServices : TeaModel {
                /// <summary>
                /// <para>Service port, do not pass in for dynamic ports.</para>
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
                /// <para>svc-cr6pk4tlhtgm58e***</para>
                /// </summary>
                [NameInMap("serviceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <para>Service version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>Percentage value of traffic ratio.</para>
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
        /// <para>test route</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>List of domain IDs.</para>
        /// </summary>
        [NameInMap("domainIds")]
        [Validation(Required=false)]
        public List<string> DomainIds { get; set; }

        /// <summary>
        /// <para>Environment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-cquqsollhtgid***</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <para>Route match rule.</para>
        /// </summary>
        [NameInMap("match")]
        [Validation(Required=false)]
        public HttpRouteMatch Match { get; set; }

    }

}
