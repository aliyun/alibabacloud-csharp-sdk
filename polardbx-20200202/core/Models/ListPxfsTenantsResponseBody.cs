// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class ListPxfsTenantsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public ListPxfsTenantsResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class ListPxfsTenantsResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The authentication action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polardbx:ListPxfsTenants</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The display name of the authentication principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample RAM user</para>
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
            /// <para>The type of the permission denial.</para>
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
        /// <para>The data structure.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListPxfsTenantsResponseBodyData Data { get; set; }
        public class ListPxfsTenantsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of PXFS tenants.</para>
            /// </summary>
            [NameInMap("Tenants")]
            [Validation(Required=false)]
            public List<ListPxfsTenantsResponseBodyDataTenants> Tenants { get; set; }
            public class ListPxfsTenantsResponseBodyDataTenants : TeaModel {
                /// <summary>
                /// <para>The number of bytes saved by data deduplication for the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>268435456</para>
                /// </summary>
                [NameInMap("DedupBytes")]
                [Validation(Required=false)]
                public long? DedupBytes { get; set; }

                /// <summary>
                /// <para>The current logical usage of the tenant, in bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1073741824</para>
                /// </summary>
                [NameInMap("LogicalBytes")]
                [Validation(Required=false)]
                public long? LogicalBytes { get; set; }

                /// <summary>
                /// <para>The current number of logical files for the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("LogicalFiles")]
                [Validation(Required=false)]
                public long? LogicalFiles { get; set; }

                /// <summary>
                /// <para>The actual physical storage space occupied by the tenant, in bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>805306368</para>
                /// </summary>
                [NameInMap("PhysicalBytes")]
                [Validation(Required=false)]
                public long? PhysicalBytes { get; set; }

                /// <summary>
                /// <para>The storage capacity quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>107374182400</para>
                /// </summary>
                [NameInMap("QuotaBytes")]
                [Validation(Required=false)]
                public long? QuotaBytes { get; set; }

                /// <summary>
                /// <para>The file count quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000000</para>
                /// </summary>
                [NameInMap("QuotaFiles")]
                [Validation(Required=false)]
                public long? QuotaFiles { get; set; }

                /// <summary>
                /// <para>The maximum request rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RateLimitRps")]
                [Validation(Required=false)]
                public long? RateLimitRps { get; set; }

                /// <summary>
                /// <para>The maximum write bandwidth.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RateLimitWbps")]
                [Validation(Required=false)]
                public long? RateLimitWbps { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zero-v1zhme7mtddrkfn40hrr9ifk</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>The tenant name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zero-v1zhme7mtddrkfn40hrr9ifk</para>
                /// </summary>
                [NameInMap("TenantName")]
                [Validation(Required=false)]
                public string TenantName { get; set; }

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
