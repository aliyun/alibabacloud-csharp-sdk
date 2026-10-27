// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribePxfsInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribePxfsInfoResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribePxfsInfoResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The authorization action. Same as described above.</para>
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
            /// <para>The authorization action. Same as described above.</para>
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
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribePxfsInfoResponseBodyData Data { get; set; }
        public class DescribePxfsInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The instance information.</para>
            /// </summary>
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public DescribePxfsInfoResponseBodyDataInstance Instance { get; set; }
            public class DescribePxfsInfoResponseBodyDataInstance : TeaModel {
                /// <summary>
                /// <para>The node specification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>polarx.pxfs.x4.xlarge</para>
                /// </summary>
                [NameInMap("ClassCode")]
                [Validation(Required=false)]
                public string ClassCode { get; set; }

                /// <summary>
                /// <para>The list of connection addresses.</para>
                /// </summary>
                [NameInMap("ConnAddrs")]
                [Validation(Required=false)]
                public List<DescribePxfsInfoResponseBodyDataInstanceConnAddrs> ConnAddrs { get; set; }
                public class DescribePxfsInfoResponseBodyDataInstanceConnAddrs : TeaModel {
                    /// <summary>
                    /// <para>The connection string.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>agent-files.example.com:12049</para>
                    /// </summary>
                    [NameInMap("ConnectionString")]
                    [Validation(Required=false)]
                    public string ConnectionString { get; set; }

                    /// <summary>
                    /// <para>The endpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>agent-files.example.com</para>
                    /// </summary>
                    [NameInMap("Endpoint")]
                    [Validation(Required=false)]
                    public string Endpoint { get; set; }

                    /// <summary>
                    /// <para>The port number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12049</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The access protocol.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NFS</para>
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// <para>Indicates whether TLS is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("TlsEnabled")]
                    [Validation(Required=false)]
                    public bool? TlsEnabled { get; set; }

                    /// <summary>
                    /// <para>The transport protocol.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TLS</para>
                    /// </summary>
                    [NameInMap("Transport")]
                    [Validation(Required=false)]
                    public string Transport { get; set; }

                    /// <summary>
                    /// <para>The connection type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Intranet</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The virtual private cloud (VPC) ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-xxxxxxxx</para>
                    /// </summary>
                    [NameInMap("VPCId")]
                    [Validation(Required=false)]
                    public string VPCId { get; set; }

                    /// <summary>
                    /// <para>The vSwitch ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-xxxxxxxx</para>
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-03T12:00:00Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The PolarDB-X instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxc-xxxxxxxx</para>
                /// </summary>
                [NameInMap("DBInstanceName")]
                [Validation(Required=false)]
                public string DBInstanceName { get; set; }

                /// <summary>
                /// <para>The associated instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxc-xxxxxxxx</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The number of nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("NodeCount")]
                [Validation(Required=false)]
                public int? NodeCount { get; set; }

                /// <summary>
                /// <para>The Agent file service instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxfs-xxxxxxxx</para>
                /// </summary>
                [NameInMap("PxfsInstanceId")]
                [Validation(Required=false)]
                public string PxfsInstanceId { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACTIVE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The storage size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("StorageSize")]
                [Validation(Required=false)]
                public long? StorageSize { get; set; }

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
                /// <para>The virtual private cloud (VPC) ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-xxxxxxxx</para>
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-xxxxxxxx</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The current version.</para>
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
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
