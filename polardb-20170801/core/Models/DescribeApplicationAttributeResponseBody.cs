// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeApplicationAttributeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>supabase</para>
        /// </summary>
        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public string ApplicationType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>x86</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<DescribeApplicationAttributeResponseBodyComponents> Components { get; set; }
        public class DescribeApplicationAttributeResponseBodyComponents : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>polar.app.g2.medium</para>
            /// </summary>
            [NameInMap("ComponentClass")]
            [Validation(Required=false)]
            public string ComponentClass { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2C4GB</para>
            /// </summary>
            [NameInMap("ComponentClassDescription")]
            [Validation(Required=false)]
            public string ComponentClassDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pac-*******************</para>
            /// </summary>
            [NameInMap("ComponentId")]
            [Validation(Required=false)]
            public string ComponentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ComponentMaxReplica")]
            [Validation(Required=false)]
            public long? ComponentMaxReplica { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ComponentReplica")]
            [Validation(Required=false)]
            public long? ComponentReplica { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("ComponentReplicaGroupName")]
            [Validation(Required=false)]
            public string ComponentReplicaGroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>gateway</para>
            /// </summary>
            [NameInMap("ComponentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

            [NameInMap("SecurityGroups")]
            [Validation(Required=false)]
            public List<DescribeApplicationAttributeResponseBodyComponentsSecurityGroups> SecurityGroups { get; set; }
            public class DescribeApplicationAttributeResponseBodyComponentsSecurityGroups : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sg-*******************</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MyGroupName</para>
                /// </summary>
                [NameInMap("SecurityGroupName")]
                [Validation(Required=false)]
                public string SecurityGroupName { get; set; }

            }

            [NameInMap("SecurityIPArrays")]
            [Validation(Required=false)]
            public List<DescribeApplicationAttributeResponseBodyComponentsSecurityIPArrays> SecurityIPArrays { get; set; }
            public class DescribeApplicationAttributeResponseBodyComponentsSecurityIPArrays : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("SecurityIPArrayName")]
                [Validation(Required=false)]
                public string SecurityIPArrayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mytag</para>
                /// </summary>
                [NameInMap("SecurityIPArrayTag")]
                [Validation(Required=false)]
                public string SecurityIPArrayTag { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>127.0.0.1</para>
                /// </summary>
                [NameInMap("SecurityIPList")]
                [Validation(Required=false)]
                public string SecurityIPList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mix</para>
                /// </summary>
                [NameInMap("SecurityIPNetType")]
                [Validation(Required=false)]
                public string SecurityIPNetType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ipv4</para>
                /// </summary>
                [NameInMap("SecurityIPType")]
                [Validation(Required=false)]
                public string SecurityIPType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Activated</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Topology")]
            [Validation(Required=false)]
            public DescribeApplicationAttributeResponseBodyComponentsTopology Topology { get; set; }
            public class DescribeApplicationAttributeResponseBodyComponentsTopology : TeaModel {
                [NameInMap("Children")]
                [Validation(Required=false)]
                public List<string> Children { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Layer")]
                [Validation(Required=false)]
                public string Layer { get; set; }

                [NameInMap("Parents")]
                [Validation(Required=false)]
                public List<string> Parents { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-03-25T09:37:10Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>myapp</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<DescribeApplicationAttributeResponseBodyEndpoints> Endpoints { get; set; }
        public class DescribeApplicationAttributeResponseBodyEndpoints : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>myendpoint</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pa-**************</para>
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>172.31.95.252</para>
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Private</para>
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            [NameInMap("PortDescription")]
            [Validation(Required=false)]
            public string PortDescription { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-06-25T09:37:10Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public bool? Expired { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Unlock</para>
        /// </summary>
        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public string LockMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>19:00Z</para>
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18:00Z</para>
        /// </summary>
        [NameInMap("MaintainStartTime")]
        [Validation(Required=false)]
        public string MaintainStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pfs-**************</para>
        /// </summary>
        [NameInMap("PolarFSInstanceId")]
        [Validation(Required=false)]
        public string PolarFSInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3E5CD764-FCCA-5C9C-838E-20E0DE84B2AF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityGroups")]
        [Validation(Required=false)]
        public List<DescribeApplicationAttributeResponseBodySecurityGroups> SecurityGroups { get; set; }
        public class DescribeApplicationAttributeResponseBodySecurityGroups : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc</para>
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sg-**************</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MyGroupName</para>
            /// </summary>
            [NameInMap("SecurityGroupName")]
            [Validation(Required=false)]
            public string SecurityGroupName { get; set; }

        }

        [NameInMap("SecurityIPArrays")]
        [Validation(Required=false)]
        public List<DescribeApplicationAttributeResponseBodySecurityIPArrays> SecurityIPArrays { get; set; }
        public class DescribeApplicationAttributeResponseBodySecurityIPArrays : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("SecurityIPArrayName")]
            [Validation(Required=false)]
            public string SecurityIPArrayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mytag</para>
            /// </summary>
            [NameInMap("SecurityIPArrayTag")]
            [Validation(Required=false)]
            public string SecurityIPArrayTag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("SecurityIPList")]
            [Validation(Required=false)]
            public string SecurityIPList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mix</para>
            /// </summary>
            [NameInMap("SecurityIPNetType")]
            [Validation(Required=false)]
            public string SecurityIPNetType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ipv4</para>
            /// </summary>
            [NameInMap("SecurityIPType")]
            [Validation(Required=false)]
            public string SecurityIPType { get; set; }

        }

        [NameInMap("ServerlessType")]
        [Validation(Required=false)]
        public string ServerlessType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Activated</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing-l</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
