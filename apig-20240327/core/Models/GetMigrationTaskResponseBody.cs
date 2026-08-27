// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetMigrationTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMigrationTaskResponseBodyData Data { get; set; }
        public class GetMigrationTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>api-xxxx</para>
            /// </summary>
            [NameInMap("apiId")]
            [Validation(Required=false)]
            public string ApiId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ingress-api</para>
            /// </summary>
            [NameInMap("apiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c-xxxxxx</para>
            /// </summary>
            [NameInMap("clusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my-cluster</para>
            /// </summary>
            [NameInMap("clusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("clusterNamespace")]
            [Validation(Required=false)]
            public string ClusterNamespace { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1756262400</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>workspace api monitor test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>env-xxxx</para>
            /// </summary>
            [NameInMap("envId")]
            [Validation(Required=false)]
            public string EnvId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>gw-xxxx</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my-gateway</para>
            /// </summary>
            [NameInMap("gatewayName")]
            [Validation(Required=false)]
            public string GatewayName { get; set; }

            [NameInMap("ingressConfig")]
            [Validation(Required=false)]
            public GetMigrationTaskResponseBodyDataIngressConfig IngressConfig { get; set; }
            public class GetMigrationTaskResponseBodyDataIngressConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>nginx</para>
                /// </summary>
                [NameInMap("ingressClass")]
                [Validation(Required=false)]
                public string IngressClass { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("watchNamespace")]
                [Validation(Required=false)]
                public string WatchNamespace { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Nginx Ingress</para>
            /// </summary>
            [NameInMap("migrationType")]
            [Validation(Required=false)]
            public string MigrationType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>nginx-ingress-lb</para>
            /// </summary>
            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>lb-bp1xxxx</para>
            /// </summary>
            [NameInMap("slbId")]
            [Validation(Required=false)]
            public string SlbId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FlowSwitch</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SLB</para>
            /// </summary>
            [NameInMap("switchType")]
            [Validation(Required=false)]
            public string SwitchType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mt-xxxxxxxx</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234567890</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("virtualServices")]
            [Validation(Required=false)]
            public List<GetMigrationTaskResponseBodyDataVirtualServices> VirtualServices { get; set; }
            public class GetMigrationTaskResponseBodyDataVirtualServices : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tcp</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rsp-xxxx</para>
                /// </summary>
                [NameInMap("virtualServiceGroupId")]
                [Validation(Required=false)]
                public string VirtualServiceGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>80-tcp</para>
                /// </summary>
                [NameInMap("virtualServiceGroupName")]
                [Validation(Required=false)]
                public string VirtualServiceGroupName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>42EAF9DB-9082-5F11-8EE1-C2357906DA0F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
