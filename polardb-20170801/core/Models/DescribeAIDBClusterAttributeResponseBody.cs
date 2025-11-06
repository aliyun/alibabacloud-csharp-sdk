// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAIDBClusterAttributeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>vnode</para>
        /// </summary>
        [NameInMap("AiNodeType")]
        [Validation(Required=false)]
        public string AiNodeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2020-08-14T05:58:42Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("DBClusterStatus")]
        [Validation(Required=false)]
        public string DBClusterStatus { get; set; }

        [NameInMap("DBNodes")]
        [Validation(Required=false)]
        public List<DescribeAIDBClusterAttributeResponseBodyDBNodes> DBNodes { get; set; }
        public class DescribeAIDBClusterAttributeResponseBodyDBNodes : TeaModel {
            [NameInMap("ChildVolumes")]
            [Validation(Required=false)]
            public List<DescribeAIDBClusterAttributeResponseBodyDBNodesChildVolumes> ChildVolumes { get; set; }
            public class DescribeAIDBClusterAttributeResponseBodyDBNodesChildVolumes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>/tmp/CrowdStrike</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>jueming</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8192</para>
                /// </summary>
                [NameInMap("SizeGB")]
                [Validation(Required=false)]
                public string SizeGB { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PolarFs</para>
                /// </summary>
                [NameInMap("StorageCategory")]
                [Validation(Required=false)]
                public string StorageCategory { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CpuCores")]
            [Validation(Required=false)]
            public string CpuCores { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-08-14T05:58:42Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>polar.pg.g8.8xlarge.gu30</para>
            /// </summary>
            [NameInMap("DBNodeClass")]
            [Validation(Required=false)]
            public string DBNodeClass { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DBNodeDescription")]
            [Validation(Required=false)]
            public string DBNodeDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pi-****************</para>
            /// </summary>
            [NameInMap("DBNodeId")]
            [Validation(Required=false)]
            public string DBNodeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DBNodeStatus")]
            [Validation(Required=false)]
            public string DBNodeStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("GPU")]
            [Validation(Required=false)]
            public string GPU { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10.*.*12</para>
            /// </summary>
            [NameInMap("LinkIP")]
            [Validation(Required=false)]
            public string LinkIP { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("MemorySize")]
            [Validation(Required=false)]
            public string MemorySize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>101.101.101.101</para>
            /// </summary>
            [NameInMap("PublicIp")]
            [Validation(Required=false)]
            public string PublicIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vn-***************</para>
            /// </summary>
            [NameInMap("VNodeId")]
            [Validation(Required=false)]
            public string VNodeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-*******************</para>
            /// </summary>
            [NameInMap("VPCId")]
            [Validation(Required=false)]
            public string VPCId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-*********************</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-d</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        [NameInMap("EndpointList")]
        [Validation(Required=false)]
        public List<DescribeAIDBClusterAttributeResponseBodyEndpointList> EndpointList { get; set; }
        public class DescribeAIDBClusterAttributeResponseBodyEndpointList : TeaModel {
            [NameInMap("NetInfoItems")]
            [Validation(Required=false)]
            public List<DescribeAIDBClusterAttributeResponseBodyEndpointListNetInfoItems> NetInfoItems { get; set; }
            public class DescribeAIDBClusterAttributeResponseBodyEndpointListNetInfoItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>pc-**********.rwlb.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Public</para>
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2020-11-14T16:00:00Z</para>
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
        /// <para>10.<em>.</em>.72</para>
        /// </summary>
        [NameInMap("InternalIp")]
        [Validation(Required=false)]
        public string InternalIp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("KubeClusterId")]
        [Validation(Required=false)]
        public string KubeClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Unlock</para>
        /// </summary>
        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public string LockMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxQPM")]
        [Validation(Required=false)]
        public string MaxQPM { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Qwen3-Embedding-8B</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("PublicIp")]
        [Validation(Required=false)]
        public string PublicIp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>EBEAA83D-1734-42E3-85E3-E25F6E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>container</para>
        /// </summary>
        [NameInMap("RunType")]
        [Validation(Required=false)]
        public string RunType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>essdpl1</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-*******************</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vsw-*********************</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("Volumes")]
        [Validation(Required=false)]
        public List<DescribeAIDBClusterAttributeResponseBodyVolumes> Volumes { get; set; }
        public class DescribeAIDBClusterAttributeResponseBodyVolumes : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>/var/run/secrets/kubernetes.io/serviceaccount</para>
            /// </summary>
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>jueming</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("SizeGB")]
            [Validation(Required=false)]
            public string SizeGB { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("StorageCategory")]
            [Validation(Required=false)]
            public string StorageCategory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PolarFs</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou-d</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i,cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneIds")]
        [Validation(Required=false)]
        public string ZoneIds { get; set; }

    }

}
