// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeContext0InfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribeContext0InfoResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribeContext0InfoResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The authentication action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The display name of the authentication principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>The owner ID of the authentication principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>The authentication principal type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>222</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>The encoded diagnostic message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AQEAAAAAaKPfwjY0MzMyODRGLUZCQkQtNTA1RS04MUUxLTc5NTkzODk2MUIzMg==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>The type of missing permission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>The policy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PRIORITY</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The parameter details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeContext0InfoResponseBodyData Data { get; set; }
        public class DescribeContext0InfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The instance information.</para>
            /// </summary>
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public DescribeContext0InfoResponseBodyDataInstance Instance { get; set; }
            public class DescribeContext0InfoResponseBodyDataInstance : TeaModel {
                /// <summary>
                /// <para>The instance specifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql.x2.large.2c</para>
                /// </summary>
                [NameInMap("ClassCode")]
                [Validation(Required=false)]
                public string ClassCode { get; set; }

                /// <summary>
                /// <para>The list of endpoints.</para>
                /// </summary>
                [NameInMap("ConnAddrs")]
                [Validation(Required=false)]
                public List<DescribeContext0InfoResponseBodyDataInstanceConnAddrs> ConnAddrs { get; set; }
                public class DescribeContext0InfoResponseBodyDataInstanceConnAddrs : TeaModel {
                    /// <summary>
                    /// <para>The endpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pxc-spsil01pww4hfz.polarx.singapore.rds.aliyuncs.com</para>
                    /// </summary>
                    [NameInMap("ConnectionString")]
                    [Validation(Required=false)]
                    public string ConnectionString { get; set; }

                    /// <summary>
                    /// <para>The target node type: service or dashboard.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>service</para>
                    /// </summary>
                    [NameInMap("NodeType")]
                    [Validation(Required=false)]
                    public string NodeType { get; set; }

                    /// <summary>
                    /// <para>The port.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3306</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The endpoint type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>VPC</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>VPC ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-t4n4hf9xey7ea3lp4bwwx</para>
                    /// </summary>
                    [NameInMap("VPCId")]
                    [Validation(Required=false)]
                    public string VPCId { get; set; }

                    /// <summary>
                    /// <para>The vSwitch ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-t4ny14pr37spmjsbv5dc2</para>
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <para>The VPC-connected instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pxc-spsil01pww4hfzjayd-cn-20251013180429</para>
                    /// </summary>
                    [NameInMap("VpcInstanceId")]
                    [Validation(Required=false)]
                    public string VpcInstanceId { get; set; }

                }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-02-17T02:00:20Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The database instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxc-hzr9qzafkeury3</para>
                /// </summary>
                [NameInMap("DBInstanceName")]
                [Validation(Required=false)]
                public string DBInstanceName { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxc-spsil01pww4hfz-mem</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The number of nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NodeCount")]
                [Validation(Required=false)]
                public int? NodeCount { get; set; }

                /// <summary>
                /// <para>The PolarDB-X Search instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxs-********</para>
                /// </summary>
                [NameInMap("OpenSearchInstanceName")]
                [Validation(Required=false)]
                public string OpenSearchInstanceName { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-southeast-1</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The endpoints of the nodes.</para>
                /// </summary>
                [NameInMap("ReplicaSets")]
                [Validation(Required=false)]
                public List<DescribeContext0InfoResponseBodyDataInstanceReplicaSets> ReplicaSets { get; set; }
                public class DescribeContext0InfoResponseBodyDataInstanceReplicaSets : TeaModel {
                    /// <summary>
                    /// <para>The instance specifications.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pg.x2.13large.2c</para>
                    /// </summary>
                    [NameInMap("ClassCode")]
                    [Validation(Required=false)]
                    public string ClassCode { get; set; }

                    /// <summary>
                    /// <para>The vSwitch ID.</para>
                    /// </summary>
                    [NameInMap("ConnAddrs")]
                    [Validation(Required=false)]
                    public List<DescribeContext0InfoResponseBodyDataInstanceReplicaSetsConnAddrs> ConnAddrs { get; set; }
                    public class DescribeContext0InfoResponseBodyDataInstanceReplicaSetsConnAddrs : TeaModel {
                        /// <summary>
                        /// <para>The endpoint.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>pxc-hzrlz8e3khuaoz.polarx.rds.aliyuncs.com</para>
                        /// </summary>
                        [NameInMap("ConnectionString")]
                        [Validation(Required=false)]
                        public string ConnectionString { get; set; }

                        /// <summary>
                        /// <para>The target node type: service or dashboard.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>service</para>
                        /// </summary>
                        [NameInMap("NodeType")]
                        [Validation(Required=false)]
                        public string NodeType { get; set; }

                        /// <summary>
                        /// <para>The port.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3306</para>
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        /// <summary>
                        /// <para>The instance type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>ReadWrite</b>: Primary instance.</description></item>
                        /// <item><description><b>ReadOnly</b>: Read-only instance.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>RemoveHeader</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>VPC ID</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-bp1550umsomy2mw24vhwl</para>
                        /// </summary>
                        [NameInMap("VPCId")]
                        [Validation(Required=false)]
                        public string VPCId { get; set; }

                        /// <summary>
                        /// <para>The vSwitch ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vsw-2zedp17pfss1133bvdizl</para>
                        /// </summary>
                        [NameInMap("VSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                        /// <summary>
                        /// <para>The VPC-connected instance ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-8vbdw66evguopfcfvieoi</para>
                        /// </summary>
                        [NameInMap("VpcInstanceId")]
                        [Validation(Required=false)]
                        public string VpcInstanceId { get; set; }

                    }

                    /// <summary>
                    /// <para>The creation time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-07-28T02:01:13Z</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pxc-hzrbqgiocrpu8a</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The number of nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("NodeCount")]
                    [Validation(Required=false)]
                    public int? NodeCount { get; set; }

                    /// <summary>
                    /// <para>The target node type: service or dashboard.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>service</para>
                    /// </summary>
                    [NameInMap("NodeType")]
                    [Validation(Required=false)]
                    public string NodeType { get; set; }

                    /// <summary>
                    /// <para>The node status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: Running.</description></item>
                    /// <item><description><b>1</b>: Creating.</description></item>
                    /// <item><description><b>2</b>: Abnormal.</description></item>
                    /// <item><description><b>3</b>: Expired.</description></item>
                    /// <item><description><b>4</b>: Releasing.</description></item>
                    /// <item><description><b>5</b>: Released.</description></item>
                    /// <item><description><b>6</b>: Locked.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>enabled</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The storage type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cloud_essd</para>
                    /// </summary>
                    [NameInMap("StorageType")]
                    [Validation(Required=false)]
                    public string StorageType { get; set; }

                    /// <summary>
                    /// <para>The zone ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-beijing-i</para>
                    /// </summary>
                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }

                /// <summary>
                /// <para>The instance status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The storage type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>local_ssd</para>
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// <para>VPC ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-t4n4hf9xey7ea3lp4bwwx</para>
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-t4ny14pr37spmjsbv5dc2</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-southeast-1a</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A501A191-BD70-5E50-98A9-C2A486A82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
