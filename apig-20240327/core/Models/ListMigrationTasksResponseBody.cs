// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListMigrationTasksResponseBody : TeaModel {
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
        public ListMigrationTasksResponseBodyData Data { get; set; }
        public class ListMigrationTasksResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of migration tasks.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListMigrationTasksResponseBodyDataItems> Items { get; set; }
            public class ListMigrationTasksResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The associated HTTP API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>api-xxxx</para>
                /// </summary>
                [NameInMap("apiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// <para>The associated HTTP API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>api-name</para>
                /// </summary>
                [NameInMap("apiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// <para>The source ACK cluster. A hyphen (-) is displayed if the cluster name fails to be queried.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c-xxxxxx</para>
                /// </summary>
                [NameInMap("clusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The cluster name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc_hz_domain_1</para>
                /// </summary>
                [NameInMap("clusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                /// <summary>
                /// <para>The namespace for SLB traffic switching.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("clusterNamespace")]
                [Validation(Required=false)]
                public string ClusterNamespace { get; set; }

                /// <summary>
                /// <para>The creation time, in Unix seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1756262400</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The task description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Migration test</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the destination environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env-xxxx</para>
                /// </summary>
                [NameInMap("envId")]
                [Validation(Required=false)]
                public string EnvId { get; set; }

                /// <summary>
                /// <para>The ID of the destination gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-xxxx</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <para>The name of the gateway to which the rule belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>prod-gateway</para>
                /// </summary>
                [NameInMap("gatewayName")]
                [Validation(Required=false)]
                public string GatewayName { get; set; }

                /// <summary>
                /// <para>The monitored Ingress Class configuration.</para>
                /// </summary>
                [NameInMap("ingressConfig")]
                [Validation(Required=false)]
                public ListMigrationTasksResponseBodyDataItemsIngressConfig IngressConfig { get; set; }
                public class ListMigrationTasksResponseBodyDataItemsIngressConfig : TeaModel {
                    /// <summary>
                    /// <para>The monitored Ingress Class.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>nginx</para>
                    /// </summary>
                    [NameInMap("ingressClass")]
                    [Validation(Required=false)]
                    public string IngressClass { get; set; }

                    /// <summary>
                    /// <para>The monitored namespace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("watchNamespace")]
                    [Validation(Required=false)]
                    public string WatchNamespace { get; set; }

                }

                /// <summary>
                /// <para>The migration type. Currently, only Nginx Ingress is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Nginx Ingress</para>
                /// </summary>
                [NameInMap("migrationType")]
                [Validation(Required=false)]
                public string MigrationType { get; set; }

                /// <summary>
                /// <para>The name of the SLB service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nginx-ingress-lb</para>
                /// </summary>
                [NameInMap("serviceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                /// <summary>
                /// <para>The ID of the SLB instance used for traffic switching.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lb-bp1xxxx</para>
                /// </summary>
                [NameInMap("slbId")]
                [Validation(Required=false)]
                public string SlbId { get; set; }

                /// <summary>
                /// <para>The task status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FlowSwitch</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The traffic switching method. Valid values: DNS and SLB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SLB</para>
                /// </summary>
                [NameInMap("switchType")]
                [Validation(Required=false)]
                public string SwitchType { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mt-xxxxxxxx</para>
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The ID of the user to whom the task belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567890</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The list of virtual server groups.</para>
                /// </summary>
                [NameInMap("virtualServices")]
                [Validation(Required=false)]
                public List<ListMigrationTasksResponseBodyDataItemsVirtualServices> VirtualServices { get; set; }
                public class ListMigrationTasksResponseBodyDataItemsVirtualServices : TeaModel {
                    /// <summary>
                    /// <para>The listener port. Valid values: 1 to 65535. This parameter is required in Step 3 of the frontend form.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>443</para>
                    /// </summary>
                    [NameInMap("port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The listener protocol. This parameter is required for CLB migration. During MSE migration validation, CLB requests without a protocol are directly rejected. See migrationtask.go#L95-L97. This parameter can be left empty for NLB scenarios.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tcp</para>
                    /// </summary>
                    [NameInMap("protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// <para>The virtual server group ID. For CLB, this is the VServerGroupId. For NLB, this is the ServerGroupId. This parameter is required in Step 3 of the frontend form.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rsp-xxxx</para>
                    /// </summary>
                    [NameInMap("virtualServiceGroupId")]
                    [Validation(Required=false)]
                    public string VirtualServiceGroupId { get; set; }

                    /// <summary>
                    /// <para>The name of the virtual server group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80-tcp</para>
                    /// </summary>
                    [NameInMap("virtualServiceGroupName")]
                    [Validation(Required=false)]
                    public string VirtualServiceGroupName { get; set; }

                }

                /// <summary>
                /// <para>The weight of the service on the API gateway side in the legacy workflow. Valid values: 0 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("totalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FB5FB-615B-52AB-A92F-D40A3193DA96</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
