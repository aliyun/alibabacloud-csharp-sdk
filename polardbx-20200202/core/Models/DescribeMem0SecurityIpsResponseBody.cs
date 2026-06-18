// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeMem0SecurityIpsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribeMem0SecurityIpsResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribeMem0SecurityIpsResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>Same as above.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The identity used for authentication in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>Same as above.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>Same as above.</para>
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
            /// <para>AQEAAAAAacnceTlBNjlFODgyLTlBMDUtNUUyRC04MzE5LUQwMzZDRjJFQTM3NA==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>The type of no-permission error.</para>
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
            /// <para>System</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The data list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeMem0SecurityIpsResponseBodyData Data { get; set; }
        public class DescribeMem0SecurityIpsResponseBodyData : TeaModel {
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
            public List<DescribeMem0SecurityIpsResponseBodyDataGroups> Groups { get; set; }
            public class DescribeMem0SecurityIpsResponseBodyDataGroups : TeaModel {
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
                /// <para>The tag of the group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("GroupTag")]
                [Validation(Required=false)]
                public string GroupTag { get; set; }

                /// <summary>
                /// <para>Indicates whether the IP addresses that are already used for DNAT entries can also be used for SNAT entries. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: The IP addresses can also be used for SNAT entries.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: The IP addresses cannot be used for SNAT entries.</para>
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
        /// <para>C458B1E8-1683-3645-B154-6BA32080EEA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
