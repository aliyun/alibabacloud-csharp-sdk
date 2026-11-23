// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeOpenSearchWhitelistsResponseBody : TeaModel {
        /// <summary>
        /// <para>The access denial details.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribeOpenSearchWhitelistsResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribeOpenSearchWhitelistsResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The authentication action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polardbx:DescribeOpenSearchWhitelists</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The name of the authentication principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample RAM user</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>The OwnerId of the authentication principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>The description is the same as above.</para>
            /// 
            /// <b>Example:</b>
            /// <para>222</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>The diagnostic information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AQEAAAAAaKPfwjY0MzMyODRGLUZCQkQtNTA1RS04MUUxLTc5NTkzODk2MUIzMg==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>The no-permission type.</para>
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
        /// <para>The monitoring data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeOpenSearchWhitelistsResponseBodyData Data { get; set; }
        public class DescribeOpenSearchWhitelistsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The type of the Internet IPv4 whitelist addresses.</para>
            /// </summary>
            [NameInMap("Whitelists")]
            [Validation(Required=false)]
            public List<DescribeOpenSearchWhitelistsResponseBodyDataWhitelists> Whitelists { get; set; }
            public class DescribeOpenSearchWhitelistsResponseBodyDataWhitelists : TeaModel {
                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-07-22T02:26:08Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the group to which the instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GID_QMPRUNTIME_BROADCAST_TASK_CONSUMER_GROUP</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the whitelist group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ack_worker_new</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The list of IP addresses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("Ips")]
                [Validation(Required=false)]
                public string Ips { get; set; }

                /// <summary>
                /// <para>The network type. Only VPC networks are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The policy remark.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-t4nt9qxfgbzab587cshhc</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The last update time of the task in timestamp format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0001-01-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6A4256F-7B83-5BD7-9AC0-72E1FAC05330</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
