// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class CreateContextDBResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public CreateContextDBResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class CreateContextDBResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>As described above.</para>
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
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateContextDBResponseBodyData Data { get; set; }
        public class CreateContextDBResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The administrator key of the context service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ctx-admin-***</para>
            /// </summary>
            [NameInMap("ContextDBAdminKey")]
            [Validation(Required=false)]
            public string ContextDBAdminKey { get; set; }

            /// <summary>
            /// <para>The name of the context service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxt-*********</para>
            /// </summary>
            [NameInMap("ContextDBInstanceName")]
            [Validation(Required=false)]
            public string ContextDBInstanceName { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxc-*********</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// <para>The name of the context service dashboard instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxt-*********-d</para>
            /// </summary>
            [NameInMap("DashboardReplicaSetName")]
            [Validation(Required=false)]
            public string DashboardReplicaSetName { get; set; }

            /// <summary>
            /// <para>The name of the PolarDB-X Search instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxs-*********</para>
            /// </summary>
            [NameInMap("OpenSearchInstanceName")]
            [Validation(Required=false)]
            public string OpenSearchInstanceName { get; set; }

            /// <summary>
            /// <para>The name of the context service service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxt-*********-s</para>
            /// </summary>
            [NameInMap("ServiceReplicaSetName")]
            [Validation(Required=false)]
            public string ServiceReplicaSetName { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2209883</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A501A191-BD70-5E50-98A9-C2A486A82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
