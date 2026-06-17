// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeApplicationAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The application type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>supabase</para>
        /// </summary>
        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        /// <summary>
        /// <para>The CPU architecture. The value is:</para>
        /// <list type="bullet">
        /// <item><description><c>x86</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>x86</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// <para>Indicates whether SNAT can be disabled.</para>
        /// </summary>
        [NameInMap("CanDisableSnat")]
        [Validation(Required=false)]
        public bool? CanDisableSnat { get; set; }

        /// <summary>
        /// <para>The child components.</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<DescribeApplicationAttributeResponseBodyComponents> Components { get; set; }
        public class DescribeApplicationAttributeResponseBodyComponents : TeaModel {
            /// <summary>
            /// <para>The class of the child component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polar.app.g2.medium</para>
            /// </summary>
            [NameInMap("ComponentClass")]
            [Validation(Required=false)]
            public string ComponentClass { get; set; }

            /// <summary>
            /// <para>The description of the child component\&quot;s class.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2C4GB</para>
            /// </summary>
            [NameInMap("ComponentClassDescription")]
            [Validation(Required=false)]
            public string ComponentClassDescription { get; set; }

            /// <summary>
            /// <para>The child component ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pac-*******************</para>
            /// </summary>
            [NameInMap("ComponentId")]
            [Validation(Required=false)]
            public string ComponentId { get; set; }

            /// <summary>
            /// <para>The maximum number of replicas for the child component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ComponentMaxReplica")]
            [Validation(Required=false)]
            public long? ComponentMaxReplica { get; set; }

            /// <summary>
            /// <para>The number of replicas of the child component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ComponentReplica")]
            [Validation(Required=false)]
            public long? ComponentReplica { get; set; }

            /// <summary>
            /// <para>The group name of the child component replicas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("ComponentReplicaGroupName")]
            [Validation(Required=false)]
            public string ComponentReplicaGroupName { get; set; }

            /// <summary>
            /// <para>The type of the child component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gateway</para>
            /// </summary>
            [NameInMap("ComponentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

            /// <summary>
            /// <para>The component-level security groups.</para>
            /// <para>This parameter is not returned if the component-level security groups are the same as the application-level security groups.</para>
            /// </summary>
            [NameInMap("SecurityGroups")]
            [Validation(Required=false)]
            public List<DescribeApplicationAttributeResponseBodyComponentsSecurityGroups> SecurityGroups { get; set; }
            public class DescribeApplicationAttributeResponseBodyComponentsSecurityGroups : TeaModel {
                /// <summary>
                /// <para>The network type. The value is:</para>
                /// <list type="bullet">
                /// <item><description>vpc</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The security group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-*******************</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The security group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MyGroupName</para>
                /// </summary>
                [NameInMap("SecurityGroupName")]
                [Validation(Required=false)]
                public string SecurityGroupName { get; set; }

            }

            /// <summary>
            /// <para>The component-level whitelists.</para>
            /// <para>This parameter is not returned if the component-level whitelists are the same as the application-level whitelists.</para>
            /// </summary>
            [NameInMap("SecurityIPArrays")]
            [Validation(Required=false)]
            public List<DescribeApplicationAttributeResponseBodyComponentsSecurityIPArrays> SecurityIPArrays { get; set; }
            public class DescribeApplicationAttributeResponseBodyComponentsSecurityIPArrays : TeaModel {
                /// <summary>
                /// <para>The name of the IP address group. The default value is <c>default</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("SecurityIPArrayName")]
                [Validation(Required=false)]
                public string SecurityIPArrayName { get; set; }

                /// <summary>
                /// <para>The tag of the IP address group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mytag</para>
                /// </summary>
                [NameInMap("SecurityIPArrayTag")]
                [Validation(Required=false)]
                public string SecurityIPArrayTag { get; set; }

                /// <summary>
                /// <para>The whitelisted IP addresses, separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>127.0.0.1</para>
                /// </summary>
                [NameInMap("SecurityIPList")]
                [Validation(Required=false)]
                public string SecurityIPList { get; set; }

                /// <summary>
                /// <para>The network type of the whitelisted IP addresses. The default value is <c>mix</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mix</para>
                /// </summary>
                [NameInMap("SecurityIPNetType")]
                [Validation(Required=false)]
                public string SecurityIPNetType { get; set; }

                /// <summary>
                /// <para>The IP address type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv4</para>
                /// </summary>
                [NameInMap("SecurityIPType")]
                [Validation(Required=false)]
                public string SecurityIPType { get; set; }

            }

            /// <summary>
            /// <para>The component status. The valid values are the same as those for the application status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Activated</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The topology of the child component.</para>
            /// </summary>
            [NameInMap("Topology")]
            [Validation(Required=false)]
            public DescribeApplicationAttributeResponseBodyComponentsTopology Topology { get; set; }
            public class DescribeApplicationAttributeResponseBodyComponentsTopology : TeaModel {
                /// <summary>
                /// <para>The IDs or component types of the child nodes for this child component.</para>
                /// </summary>
                [NameInMap("Children")]
                [Validation(Required=false)]
                public List<string> Children { get; set; }

                /// <summary>
                /// <para>The topology layer of the child component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Layer")]
                [Validation(Required=false)]
                public string Layer { get; set; }

                /// <summary>
                /// <para>The IDs or component types of the parent nodes for this child component.</para>
                /// </summary>
                [NameInMap("Parents")]
                [Validation(Required=false)]
                public List<string> Parents { get; set; }

            }

        }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-25T09:37:10Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The ID of the PolarDB instance that the application depends on.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The application description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myapp</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The application endpoints.</para>
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<DescribeApplicationAttributeResponseBodyEndpoints> Endpoints { get; set; }
        public class DescribeApplicationAttributeResponseBodyEndpoints : TeaModel {
            /// <summary>
            /// <para>The endpoint description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myendpoint</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The endpoint ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pa-**************</para>
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// <para>The IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.31.95.252</para>
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// <para>The endpoint type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Private: a VPC endpoint</para>
            /// </description></item>
            /// <item><description><para>Public: a public endpoint</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Private</para>
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

            /// <summary>
            /// <para>The port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The port description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kong_http</para>
            /// </summary>
            [NameInMap("PortDescription")]
            [Validation(Required=false)]
            public string PortDescription { get; set; }

        }

        /// <summary>
        /// <para>The expiration time.</para>
        /// <para>This parameter is not returned for Postpaid instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-25T09:37:10Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the application has expired.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public bool? Expired { get; set; }

        /// <summary>
        /// <para>Indicates whether the application is the latest version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsLatestVersion")]
        [Validation(Required=false)]
        public bool? IsLatestVersion { get; set; }

        /// <summary>
        /// <para>The latest version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2026.3.13-1#20260320</para>
        /// </summary>
        [NameInMap("LatestVersion")]
        [Validation(Required=false)]
        public string LatestVersion { get; set; }

        /// <summary>
        /// <para>The lock mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Unlock: The application is not locked.</para>
        /// </description></item>
        /// <item><description><para>Lock: The application is locked.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Unlock</para>
        /// </summary>
        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public string LockMode { get; set; }

        /// <summary>
        /// <para>The maintenance end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19:00Z</para>
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        /// <summary>
        /// <para>The maintenance start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18:00Z</para>
        /// </summary>
        [NameInMap("MaintainStartTime")]
        [Validation(Required=false)]
        public string MaintainStartTime { get; set; }

        /// <summary>
        /// <para>The attributes of the Mem0 application.</para>
        /// </summary>
        [NameInMap("MemApplicationAttribute")]
        [Validation(Required=false)]
        public DescribeApplicationAttributeResponseBodyMemApplicationAttribute MemApplicationAttribute { get; set; }
        public class DescribeApplicationAttributeResponseBodyMemApplicationAttribute : TeaModel {
            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-database-name</para>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>The name of the embedder model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text-embedding-v4</para>
            /// </summary>
            [NameInMap("EmbedderModelName")]
            [Validation(Required=false)]
            public string EmbedderModelName { get; set; }

            /// <summary>
            /// <para>The name of the graph LLM model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3-max</para>
            /// </summary>
            [NameInMap("GraphLlmModelName")]
            [Validation(Required=false)]
            public string GraphLlmModelName { get; set; }

            /// <summary>
            /// <para>The name of the LLM model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3-max</para>
            /// </summary>
            [NameInMap("LlmModelName")]
            [Validation(Required=false)]
            public string LlmModelName { get; set; }

            /// <summary>
            /// <para>The project name. It corresponds to the database schema where project data is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-project-name</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The name of the reranker model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3-rerank</para>
            /// </summary>
            [NameInMap("RerankerModelName")]
            [Validation(Required=false)]
            public string RerankerModelName { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-user</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The minor version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2026.3.13-1#20260320</para>
        /// </summary>
        [NameInMap("MinorVersion")]
        [Validation(Required=false)]
        public string MinorVersion { get; set; }

        /// <summary>
        /// <para>The ID of the NAT Gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-xxx</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The attributes of the PolarClaw SaaS application.</para>
        /// </summary>
        [NameInMap("PolarClawSaaSApplicationAttribute")]
        [Validation(Required=false)]
        public DescribeApplicationAttributeResponseBodyPolarClawSaaSApplicationAttribute PolarClawSaaSApplicationAttribute { get; set; }
        public class DescribeApplicationAttributeResponseBodyPolarClawSaaSApplicationAttribute : TeaModel {
            /// <summary>
            /// <para>The authentication callback URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://8.xxx.xxx.xxx.xxx/xxx">http://8.xxx.xxx.xxx.xxx/xxx</a></para>
            /// </summary>
            [NameInMap("AuthCallbackURL")]
            [Validation(Required=false)]
            public string AuthCallbackURL { get; set; }

            /// <summary>
            /// <para>The enabled authentication providers.</para>
            /// </summary>
            [NameInMap("AuthProviders")]
            [Validation(Required=false)]
            public List<string> AuthProviders { get; set; }

            /// <summary>
            /// <para>The Supabase cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pa-**************</para>
            /// </summary>
            [NameInMap("SupabaseClusterId")]
            [Validation(Required=false)]
            public string SupabaseClusterId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the PolarFS Cold Storage or PolarFS High-performance instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-**************</para>
        /// </summary>
        [NameInMap("PolarFSInstanceId")]
        [Validation(Required=false)]
        public string PolarFSInstanceId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3E5CD764-FCCA-5C9C-838E-20E0DE84B2AF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The application-level security groups.</para>
        /// </summary>
        [NameInMap("SecurityGroups")]
        [Validation(Required=false)]
        public List<DescribeApplicationAttributeResponseBodySecurityGroups> SecurityGroups { get; set; }
        public class DescribeApplicationAttributeResponseBodySecurityGroups : TeaModel {
            /// <summary>
            /// <para>The network type. The value is:</para>
            /// <list type="bullet">
            /// <item><description>vpc</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vpc</para>
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The security group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-**************</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The security group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyGroupName</para>
            /// </summary>
            [NameInMap("SecurityGroupName")]
            [Validation(Required=false)]
            public string SecurityGroupName { get; set; }

        }

        /// <summary>
        /// <para>The application-level whitelists.</para>
        /// </summary>
        [NameInMap("SecurityIPArrays")]
        [Validation(Required=false)]
        public List<DescribeApplicationAttributeResponseBodySecurityIPArrays> SecurityIPArrays { get; set; }
        public class DescribeApplicationAttributeResponseBodySecurityIPArrays : TeaModel {
            /// <summary>
            /// <para>The name of the IP address group. The default value is <c>default</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("SecurityIPArrayName")]
            [Validation(Required=false)]
            public string SecurityIPArrayName { get; set; }

            /// <summary>
            /// <para>The tag of the IP address group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mytag</para>
            /// </summary>
            [NameInMap("SecurityIPArrayTag")]
            [Validation(Required=false)]
            public string SecurityIPArrayTag { get; set; }

            /// <summary>
            /// <para>The whitelisted IP addresses, separated by commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("SecurityIPList")]
            [Validation(Required=false)]
            public string SecurityIPList { get; set; }

            /// <summary>
            /// <para>The network type of the whitelisted IP addresses. The default value is <c>mix</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mix</para>
            /// </summary>
            [NameInMap("SecurityIPNetType")]
            [Validation(Required=false)]
            public string SecurityIPNetType { get; set; }

            /// <summary>
            /// <para>The IP address type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ipv4</para>
            /// </summary>
            [NameInMap("SecurityIPType")]
            [Validation(Required=false)]
            public string SecurityIPType { get; set; }

        }

        /// <summary>
        /// <para>The Serverless type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>2: Agile</para>
        /// </description></item>
        /// <item><description><para>3: Stable</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ServerlessType")]
        [Validation(Required=false)]
        public string ServerlessType { get; set; }

        /// <summary>
        /// <para>The SNAT status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("SnatStatus")]
        [Validation(Required=false)]
        public string SnatStatus { get; set; }

        /// <summary>
        /// <para>The application status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Creating: The application is being created.</para>
        /// </description></item>
        /// <item><description><para>Activated: The application is running.</para>
        /// </description></item>
        /// <item><description><para>Maintaining: The application is being maintained.</para>
        /// </description></item>
        /// <item><description><para>ClassChanging: The application configuration is being changed.</para>
        /// </description></item>
        /// <item><description><para>Transing: The application is being migrated.</para>
        /// </description></item>
        /// <item><description><para>MinorVersionUpgrading: The minor version of the application is being upgraded.</para>
        /// </description></item>
        /// <item><description><para>NetCreating: The endpoint is being created.</para>
        /// </description></item>
        /// <item><description><para>NetDeleting: The endpoint is being deleted.</para>
        /// </description></item>
        /// <item><description><para>NetModifying: The endpoint is being modified.</para>
        /// </description></item>
        /// <item><description><para>Restarting: The application is restarting.</para>
        /// </description></item>
        /// <item><description><para>Locking: The application is being locked.</para>
        /// </description></item>
        /// <item><description><para>Locked: The application is locked.</para>
        /// </description></item>
        /// <item><description><para>Unlocking: The application is being unlocked.</para>
        /// </description></item>
        /// <item><description><para>Deleting: The application is being deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Activated</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The details of the storage resources.</para>
        /// </summary>
        [NameInMap("Storages")]
        [Validation(Required=false)]
        public List<DescribeApplicationAttributeResponseBodyStorages> Storages { get; set; }
        public class DescribeApplicationAttributeResponseBodyStorages : TeaModel {
            /// <summary>
            /// <para>The storage capacity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20Gi</para>
            /// </summary>
            [NameInMap("StorageCapacity")]
            [Validation(Required=false)]
            public string StorageCapacity { get; set; }

            /// <summary>
            /// <para>The storage instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pa-**************</para>
            /// </summary>
            [NameInMap("StorageInstanceId")]
            [Validation(Required=false)]
            public string StorageInstanceId { get; set; }

            /// <summary>
            /// <para>The storage performance level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("StoragePerformanceLevel")]
            [Validation(Required=false)]
            public string StoragePerformanceLevel { get; set; }

            /// <summary>
            /// <para>The storage type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>essd</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether an upgrade is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UpgradeAvailable")]
        [Validation(Required=false)]
        public string UpgradeAvailable { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-*******************</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The VSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-*******************</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The application version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-l</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
