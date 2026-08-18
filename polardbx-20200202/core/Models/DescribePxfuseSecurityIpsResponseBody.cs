// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribePxfuseSecurityIpsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribePxfuseSecurityIpsResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribePxfuseSecurityIpsResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The description is the same as above.</para>
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
            /// <para>The type of the authentication principal.</para>
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
            /// <para>The type of the no-permission error.</para>
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
        /// <para>The instance details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribePxfuseSecurityIpsResponseBodyData Data { get; set; }
        public class DescribePxfuseSecurityIpsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the memory engine instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxc-***-mem</para>
            /// </summary>
            [NameInMap("CustinsName")]
            [Validation(Required=false)]
            public string CustinsName { get; set; }

            /// <summary>
            /// <para>The groups corresponding to the consumed service.</para>
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<DescribePxfuseSecurityIpsResponseBodyDataGroups> Groups { get; set; }
            public class DescribePxfuseSecurityIpsResponseBodyDataGroups : TeaModel {
                /// <summary>
                /// <para>The name of the whitelist group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bigdata</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The group tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("GroupTag")]
                [Validation(Required=false)]
                public string GroupTag { get; set; }

                /// <summary>
                /// <para>Specifies whether an IP address that is already used for a DNAT entry can also be used for an SNAT entry. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Destination IP address can also be used for an SNAT entry.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Destination IP address cannot be used for an SNAT entry.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>127.0.0.1</para>
                /// </summary>
                [NameInMap("IpLists")]
                [Validation(Required=false)]
                public string IpLists { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
