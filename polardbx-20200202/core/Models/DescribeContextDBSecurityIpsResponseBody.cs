// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeContextDBSecurityIpsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribeContextDBSecurityIpsResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribeContextDBSecurityIpsResponseBodyAccessDeniedDetail : TeaModel {
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
            /// <para>The diagnostic information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AQEAAAAAaKPfwjY0MzMyODRGLUZCQkQtNTA1RS04MUUxLTc5NTkzODk2MUIzMg==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>NoPermissionType</para>
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
        /// <para>The paginated result of the instance list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeContextDBSecurityIpsResponseBodyData Data { get; set; }
        public class DescribeContextDBSecurityIpsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The context service instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxt-*********</para>
            /// </summary>
            [NameInMap("ContextDBInstanceName")]
            [Validation(Required=false)]
            public string ContextDBInstanceName { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxc-*********</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// <para>The whitelist group list.</para>
            /// </summary>
            [NameInMap("GroupItems")]
            [Validation(Required=false)]
            public List<DescribeContextDBSecurityIpsResponseBodyDataGroupItems> GroupItems { get; set; }
            public class DescribeContextDBSecurityIpsResponseBodyDataGroupItems : TeaModel {
                /// <summary>
                /// <para>The whitelist group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>defaultGroup</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The group tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group1</para>
                /// </summary>
                [NameInMap("GroupTag")]
                [Validation(Required=false)]
                public string GroupTag { get; set; }

                /// <summary>
                /// <para>The details of the whitelist group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>127.0.0.1,172.168.0.0</para>
                /// </summary>
                [NameInMap("SecurityIPList")]
                [Validation(Required=false)]
                public string SecurityIPList { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6A4256F-7B83-5BD7-9AC0-72E1FAC05330</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
