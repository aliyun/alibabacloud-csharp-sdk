// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListSaasPermissionGroupInfosResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListSaasPermissionGroupInfosResponseBodyData> Data { get; set; }
        public class ListSaasPermissionGroupInfosResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Release Center</para>
            /// </summary>
            [NameInMap("EnName")]
            [Validation(Required=false)]
            public string EnName { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PgInfos")]
            [Validation(Required=false)]
            public List<ListSaasPermissionGroupInfosResponseBodyDataPgInfos> PgInfos { get; set; }
            public class ListSaasPermissionGroupInfosResponseBodyDataPgInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>FAQ</para>
                /// </summary>
                [NameInMap("PgCode")]
                [Validation(Required=false)]
                public string PgCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>FAQ</para>
                /// </summary>
                [NameInMap("PgEnName")]
                [Validation(Required=false)]
                public string PgEnName { get; set; }

                [NameInMap("PgName")]
                [Validation(Required=false)]
                public string PgName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FAQ</para>
            /// </summary>
            [NameInMap("SaasCode")]
            [Validation(Required=false)]
            public string SaasCode { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>8AD9FA10-7780-5E12-B701-13C928524F32</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
