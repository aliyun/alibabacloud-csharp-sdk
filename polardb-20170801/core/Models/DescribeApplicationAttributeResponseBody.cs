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
        /// <para>The CPU architecture. Valid values:</para>
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

        [NameInMap("CanDisableSnat")]
        [Validation(Required=false)]
        public bool? CanDisableSnat { get; set; }

        /// <summary>
        /// <para>The list of subcomponents.</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<DescribeApplicationAttributeResponseBodyComponents> Components { get; set; }
        public class DescribeApplicationAttributeResponseBodyComponents : TeaModel {
            /// <summary>
            /// <para>The specification of the application subcomponent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polar.app.g2.medium</para>
            /// </summary>
            [NameInMap("ComponentClass")]
            [Validation(Required=false)]
            public string ComponentClass { get; set; }

            /// <summary>
            /// <para>The specification description of the application subcomponent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2C4GB</para>
            /// </summary>
            [NameInMap("ComponentClassDescription")]
            [Validation(Required=false)]
            public string ComponentClassDescription { get; set; }

            /// <summary>
            /// <para>The subcomponent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pac-*******************</para>
            /// </summary>
            [NameInMap("ComponentId")]
            [Validation(Required=false)]
            public string ComponentId { get; set; }

            /// <summary>
            /// <para>The maximum number of replicas of the application subcomponent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ComponentMaxReplica")]
            [Validation(Required=false)]
            public long? ComponentMaxReplica { get; set; }

            /// <summary>
            /// <para>The number of replicas of the application subcomponent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ComponentReplica")]
            [Validation(Required=false)]
            public long? ComponentReplica { get; set; }

            /// <summary>
            /// <para>The group name of the application subcomponent replicas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("ComponentReplicaGroupName")]
            [Validation(Required=false)]
            public string ComponentReplicaGroupName { get; set; }

            /// <summary>
            /// <para>The type of the application subcomponent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gateway</para>
            /// </summary>
            [NameInMap("ComponentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

            /// <summary>
            /// <para>The list of security groups at the subcomponent level.</para>
            /// <para>If the security groups at the subcomponent level are the same as those at the application level, this response element is omitted.</para>
            /// </summary>
            [NameInMap("SecurityGroups")]
            [Validation(Required=false)]
            public List<DescribeApplicationAttributeResponseBodyComponentsSecurityGroups> SecurityGroups { get; set; }
            public class DescribeApplicationAttributeResponseBodyComponentsSecurityGroups : TeaModel {
                /// <summary>
                /// <para>The network type. Valid values: </para>
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
                /// <para>The ID of the security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-*******************</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The name of the security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MyGroupName</para>
                /// </summary>
                [NameInMap("SecurityGroupName")]
                [Validation(Required=false)]
                public string SecurityGroupName { get; set; }

            }

            /// <summary>
            /// <para>The list of whitelists at the subcomponent level.</para>
            /// <para>If the whitelists at the subcomponent level are the same as those at the application level, this response element is omitted.</para>
            /// </summary>
            [NameInMap("SecurityIPArrays")]
            [Validation(Required=false)]
            public List<DescribeApplicationAttributeResponseBodyComponentsSecurityIPArrays> SecurityIPArrays { get; set; }
            public class DescribeApplicationAttributeResponseBodyComponentsSecurityIPArrays : TeaModel {
                /// <summary>
                /// <para>The name of the IP address group. Default value: <c>default</c>.</para>
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
                /// <para>The IP addresses in the whitelist, separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>127.0.0.1</para>
                /// </summary>
                [NameInMap("SecurityIPList")]
                [Validation(Required=false)]
                public string SecurityIPList { get; set; }

                /// <summary>
                /// <para>The network type of the whitelisted IP addresses. Default value: <c>mix</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mix</para>
                /// </summary>
                [NameInMap("SecurityIPNetType")]
                [Validation(Required=false)]
                public string SecurityIPNetType { get; set; }

                /// <summary>
                /// <para>The type of the IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv4</para>
                /// </summary>
                [NameInMap("SecurityIPType")]
                [Validation(Required=false)]
                public string SecurityIPType { get; set; }

            }

            /// <summary>
            /// <para>The component status. Valid values are the same as the application status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Activated</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The topology information of the application subcomponent.</para>
            /// </summary>
            [NameInMap("Topology")]
            [Validation(Required=false)]
            public DescribeApplicationAttributeResponseBodyComponentsTopology Topology { get; set; }
            public class DescribeApplicationAttributeResponseBodyComponentsTopology : TeaModel {
                /// <summary>
                /// <para>The list of child node IDs or child node component types in the topology of the current application subcomponent.</para>
                /// </summary>
                [NameInMap("Children")]
                [Validation(Required=false)]
                public List<string> Children { get; set; }

                /// <summary>
                /// <para>The topology layer of the current application subcomponent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Layer")]
                [Validation(Required=false)]
                public string Layer { get; set; }

                /// <summary>
                /// <para>The list of parent node IDs or parent node component types in the topology of the current application subcomponent.</para>
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
        /// <para>The instance ID of the PolarDB instance on which the application depends.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The description of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myapp</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of endpoints of the application.</para>
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<DescribeApplicationAttributeResponseBodyEndpoints> Endpoints { get; set; }
        public class DescribeApplicationAttributeResponseBodyEndpoints : TeaModel {
            /// <summary>
            /// <para>The description of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myendpoint</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

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
            /// <item><description>Private: VPC endpoint.</description></item>
            /// <item><description>Public: public endpoint.</description></item>
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
        /// <para>This value is empty when the billing method is Postpaid.</para>
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
        /// <para>Indicates whether the current version is the latest version.</para>
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
        /// <item><description>Unlock: Not locked.</description></item>
        /// <item><description>Lock: Locked.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Unlock</para>
        /// </summary>
        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public string LockMode { get; set; }

        /// <summary>
        /// <para>The end time of the maintenance window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19:00Z</para>
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the maintenance window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18:00Z</para>
        /// </summary>
        [NameInMap("MaintainStartTime")]
        [Validation(Required=false)]
        public string MaintainStartTime { get; set; }

        /// <summary>
        /// <para>The Mem0 application attributes.</para>
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
            /// <para>The embedder model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text-embedding-v4</para>
            /// </summary>
            [NameInMap("EmbedderModelName")]
            [Validation(Required=false)]
            public string EmbedderModelName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qwen3-max</para>
            /// </summary>
            [NameInMap("GraphLlmModelName")]
            [Validation(Required=false)]
            public string GraphLlmModelName { get; set; }

            /// <summary>
            /// <para>The LLM model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3-max</para>
            /// </summary>
            [NameInMap("LlmModelName")]
            [Validation(Required=false)]
            public string LlmModelName { get; set; }

            /// <summary>
            /// <para>The project name, which corresponds to the schema that stores project data in the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-project-name</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The reranker model name.</para>
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
        /// <para>The PolarClaw SaaS application attributes.</para>
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
        /// <para>The instance ID of PolarFS cold storage or high-performance edition.</para>
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
        /// <para>The list of security groups at the application level.</para>
        /// </summary>
        [NameInMap("SecurityGroups")]
        [Validation(Required=false)]
        public List<DescribeApplicationAttributeResponseBodySecurityGroups> SecurityGroups { get; set; }
        public class DescribeApplicationAttributeResponseBodySecurityGroups : TeaModel {
            /// <summary>
            /// <para>The network type. Valid values: </para>
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
            /// <para>The ID of the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-**************</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The name of the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyGroupName</para>
            /// </summary>
            [NameInMap("SecurityGroupName")]
            [Validation(Required=false)]
            public string SecurityGroupName { get; set; }

        }

        /// <summary>
        /// <para>The list of whitelists at the application level.</para>
        /// </summary>
        [NameInMap("SecurityIPArrays")]
        [Validation(Required=false)]
        public List<DescribeApplicationAttributeResponseBodySecurityIPArrays> SecurityIPArrays { get; set; }
        public class DescribeApplicationAttributeResponseBodySecurityIPArrays : TeaModel {
            /// <summary>
            /// <para>The name of the IP address group. Default value: <c>default</c>.</para>
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
            /// <para>The IP addresses in the whitelist, separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("SecurityIPList")]
            [Validation(Required=false)]
            public string SecurityIPList { get; set; }

            /// <summary>
            /// <para>The network type of the whitelisted IP addresses. Default value: <c>mix</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mix</para>
            /// </summary>
            [NameInMap("SecurityIPNetType")]
            [Validation(Required=false)]
            public string SecurityIPNetType { get; set; }

            /// <summary>
            /// <para>The type of the IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ipv4</para>
            /// </summary>
            [NameInMap("SecurityIPType")]
            [Validation(Required=false)]
            public string SecurityIPType { get; set; }

        }

        /// <summary>
        /// <para>The serverless type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>2: agile.</description></item>
        /// <item><description>3: steady.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ServerlessType")]
        [Validation(Required=false)]
        public string ServerlessType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("SnatStatus")]
        [Validation(Required=false)]
        public string SnatStatus { get; set; }

        /// <summary>
        /// <para>The application status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating: Being created.</description></item>
        /// <item><description>Activated: Running.</description></item>
        /// <item><description>Maintaining: Under maintenance.</description></item>
        /// <item><description>ClassChanging: Changing specifications.</description></item>
        /// <item><description>Transing: Being migrated.</description></item>
        /// <item><description>MinorVersionUpgrading: Minor version being upgraded.</description></item>
        /// <item><description>NetCreating: Endpoint being created.</description></item>
        /// <item><description>NetDeleting: Endpoint being deleted.</description></item>
        /// <item><description>NetModifying: Endpoint being modified.</description></item>
        /// <item><description>Restarting: Being restarted.</description></item>
        /// <item><description>Locking: Being locked.</description></item>
        /// <item><description>Locked: Locked.</description></item>
        /// <item><description>Unlocking: Being unlocked.</description></item>
        /// <item><description>Deleting: Being deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Activated</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The storage resource information.</para>
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
            /// <para>The storage performance level (PL).</para>
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
        /// <para>VPC ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-*******************</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>VSwitch ID</para>
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
