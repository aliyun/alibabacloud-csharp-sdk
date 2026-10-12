// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetMigrationNamespacedServicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMigrationNamespacedServicesResponseBodyData Data { get; set; }
        public class GetMigrationNamespacedServicesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of services grouped by namespace.</para>
            /// </summary>
            [NameInMap("namespacedServices")]
            [Validation(Required=false)]
            public List<GetMigrationNamespacedServicesResponseBodyDataNamespacedServices> NamespacedServices { get; set; }
            public class GetMigrationNamespacedServicesResponseBodyDataNamespacedServices : TeaModel {
                /// <summary>
                /// <para>The Kubernetes namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The list of migratable services in the namespace.</para>
                /// </summary>
                [NameInMap("services")]
                [Validation(Required=false)]
                public List<GetMigrationNamespacedServicesResponseBodyDataNamespacedServicesServices> Services { get; set; }
                public class GetMigrationNamespacedServicesResponseBodyDataNamespacedServicesServices : TeaModel {
                    /// <summary>
                    /// <para>The service name. After you select a Server Load Balancer (SLB) instance, the frontend populates this value into the serviceName field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>nginx-ingress-lb</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The ID of the load balancing instance associated with the service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>lb-xxxx / nlb-xxxx</para>
                    /// </summary>
                    [NameInMap("slbId")]
                    [Validation(Required=false)]
                    public string SlbId { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7D513911-206E-5E93-9C9E-71D63C0D68E7</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
