// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class AllocateSupabaseForAdminResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>or</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        [NameInMap("Module")]
        [Validation(Required=false)]
        public AllocateSupabaseForAdminResponseBodyModule Module { get; set; }
        public class AllocateSupabaseForAdminResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1111</para>
            /// </summary>
            [NameInMap("AnonKey")]
            [Validation(Required=false)]
            public string AnonKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>WS20250915163734000001</para>
            /// </summary>
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("DbInstanceCreateTime")]
            [Validation(Required=false)]
            public string DbInstanceCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>selectdb-cn-2bl4djolb02</para>
            /// </summary>
            [NameInMap("DbInstanceId")]
            [Validation(Required=false)]
            public string DbInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("DbPublicUrl")]
            [Validation(Required=false)]
            public string DbPublicUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ORACLE</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;appId\&quot;:\&quot;APP_NTJAK8P11SNZDJ3M6BWC\&quot;}</para>
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("InstanceCreateFinishedTime")]
            [Validation(Required=false)]
            public string InstanceCreateFinishedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1111</para>
            /// </summary>
            [NameInMap("InstanceCreateStatus")]
            [Validation(Required=false)]
            public string InstanceCreateStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsDeleted")]
            [Validation(Required=false)]
            public int? IsDeleted { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("RdsDatabasePassword")]
            [Validation(Required=false)]
            public string RdsDatabasePassword { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e80f5a7a08514709a2fb</para>
            /// </summary>
            [NameInMap("ServiceKey")]
            [Validation(Required=false)]
            public string ServiceKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1111</para>
            /// </summary>
            [NameInMap("SupabaseDashboardPassword")]
            [Validation(Required=false)]
            public string SupabaseDashboardPassword { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("SupabaseDashboardUserName")]
            [Validation(Required=false)]
            public string SupabaseDashboardUserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("SupabaseInstanceCreateTime")]
            [Validation(Required=false)]
            public string SupabaseInstanceCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1111</para>
            /// </summary>
            [NameInMap("SupabaseInstanceId")]
            [Validation(Required=false)]
            public string SupabaseInstanceId { get; set; }

            /// <summary>
            /// <para>Supabase Kong URL</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("SupabaseKongUrl")]
            [Validation(Required=false)]
            public string SupabaseKongUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1111</para>
            /// </summary>
            [NameInMap("SupabasePrivateIp")]
            [Validation(Required=false)]
            public string SupabasePrivateIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("SupabasePublicIp")]
            [Validation(Required=false)]
            public string SupabasePublicIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("SupabasePublicUrl")]
            [Validation(Required=false)]
            public string SupabasePublicUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>GFCBAMJH-zh_CN</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1111</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
