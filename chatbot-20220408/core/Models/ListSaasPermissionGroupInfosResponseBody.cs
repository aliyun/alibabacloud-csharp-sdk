// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListSaasPermissionGroupInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>The permission details for integrated SaaS pages.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListSaasPermissionGroupInfosResponseBodyData> Data { get; set; }
        public class ListSaasPermissionGroupInfosResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the page in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Release Center</para>
            /// </summary>
            [NameInMap("EnName")]
            [Validation(Required=false)]
            public string EnName { get; set; }

            /// <summary>
            /// <para>The name of the page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>发布中心</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The SaaS permission groups.</para>
            /// </summary>
            [NameInMap("PgInfos")]
            [Validation(Required=false)]
            public List<ListSaasPermissionGroupInfosResponseBodyDataPgInfos> PgInfos { get; set; }
            public class ListSaasPermissionGroupInfosResponseBodyDataPgInfos : TeaModel {
                /// <summary>
                /// <para>The unique permission group code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FAQ</para>
                /// </summary>
                [NameInMap("PgCode")]
                [Validation(Required=false)]
                public string PgCode { get; set; }

                /// <summary>
                /// <para>The English name of the permission group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FAQ</para>
                /// </summary>
                [NameInMap("PgEnName")]
                [Validation(Required=false)]
                public string PgEnName { get; set; }

                /// <summary>
                /// <para>The name of the permission group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FAQ管理</para>
                /// </summary>
                [NameInMap("PgName")]
                [Validation(Required=false)]
                public string PgName { get; set; }

            }

            /// <summary>
            /// <para>The unique code for the SaaS page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FAQ</para>
            /// </summary>
            [NameInMap("SaasCode")]
            [Validation(Required=false)]
            public string SaasCode { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8AD9FA10-7780-5E12-B701-13C928524F32</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
