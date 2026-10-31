// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GrantDataServiceApiRequest : TeaModel {
        /// <summary>
        /// <para>The grant command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("GrantCommand")]
        [Validation(Required=false)]
        public GrantDataServiceApiRequestGrantCommand GrantCommand { get; set; }
        public class GrantDataServiceApiRequestGrantCommand : TeaModel {
            /// <summary>
            /// <para>The API ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1021</para>
            /// </summary>
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public long? ApiId { get; set; }

            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1201</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public int? AppId { get; set; }

            /// <summary>
            /// <para>Specifies whether to apply for development environment permissions for operation APIs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ApplyDev")]
            [Validation(Required=false)]
            public bool? ApplyDev { get; set; }

            /// <summary>
            /// <para>Specifies whether to apply for production environment permissions for operation APIs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ApplyProd")]
            [Validation(Required=false)]
            public bool? ApplyProd { get; set; }

            /// <summary>
            /// <para>The list of authorized permission types:</para>
            /// <list type="bullet">
            /// <item><description>When the authorized subject is an application, the following permission types are supported. If you grant the delegation permission, you must also grant the use permission:<list type="bullet">
            /// <item><description>USE: use permission.</description></item>
            /// <item><description>DELEGATION: delegation permission.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>When the authorized subject is an individual, only the USE permission is supported.</description></item>
            /// <item><description>If this parameter is not specified, the default value is USE.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("AuthTypes")]
            [Validation(Required=false)]
            public List<string> AuthTypes { get; set; }

            /// <summary>
            /// <para>The list of development environment permission fields for query APIs. This parameter is required in dev-prod mode. At least one of DevFieldList and ProdFieldList must be specified. This parameter is not required for operation APIs.</para>
            /// </summary>
            [NameInMap("DevFieldList")]
            [Validation(Required=false)]
            public List<GrantDataServiceApiRequestGrantCommandDevFieldList> DevFieldList { get; set; }
            public class GrantDataServiceApiRequestGrantCommandDevFieldList : TeaModel {
                /// <summary>
                /// <para>The API permission field ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

            }

            /// <summary>
            /// <para>The validity period. Date format: yyyy-MM-dd.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30</para>
            /// </summary>
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }

            /// <summary>
            /// <para>The object type of the authorization grantee. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>APP: application.</description></item>
            /// <item><description>USER: user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>APP</para>
            /// </summary>
            [NameInMap("GranteeType")]
            [Validation(Required=false)]
            public string GranteeType { get; set; }

            /// <summary>
            /// <para>The list of production environment permission fields for query APIs. This parameter is required in basic mode and is not required for operation APIs.</para>
            /// </summary>
            [NameInMap("ProdFieldList")]
            [Validation(Required=false)]
            public List<GrantDataServiceApiRequestGrantCommandProdFieldList> ProdFieldList { get; set; }
            public class GrantDataServiceApiRequestGrantCommandProdFieldList : TeaModel {
                /// <summary>
                /// <para>The API permission field ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

            }

            /// <summary>
            /// <para>The reason for the authorization request.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The Data Service project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102102</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public int? ProjectId { get; set; }

    }

}
