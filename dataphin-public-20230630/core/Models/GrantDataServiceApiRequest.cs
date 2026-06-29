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
            /// <para>Specifies whether to request development environment permissions for operation-type APIs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ApplyDev")]
            [Validation(Required=false)]
            public bool? ApplyDev { get; set; }

            /// <summary>
            /// <para>Specifies whether to request production environment permissions for operation-type APIs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ApplyProd")]
            [Validation(Required=false)]
            public bool? ApplyProd { get; set; }

            /// <summary>
            /// <para>The list of authorization permission types. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>When the grantee is an application, the following permission types are supported. To grant delegation permissions, you must also grant usage permissions.<list type="bullet">
            /// <item><description>USE: usage permission.</description></item>
            /// <item><description>DELEGATION: delegation permission.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>When the grantee is an individual, only USE (usage) permission is supported.</description></item>
            /// <item><description>If this parameter is not specified, the default value is USE (usage) permission.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("AuthTypes")]
            [Validation(Required=false)]
            public List<string> AuthTypes { get; set; }

            /// <summary>
            /// <para>The list of development environment permission fields for query-type APIs. This parameter is required in dev-prod mode. DevFieldList and ProdFieldList cannot both be empty. This parameter is not required for operation-type APIs.</para>
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
            /// <para>The expiration date in the format of yyyy-MM-dd.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30</para>
            /// </summary>
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }

            /// <summary>
            /// <para>The authorization object type. Valid values:</para>
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
            /// <para>The list of production environment permission fields for query-type APIs. This parameter is required in basic mode. This parameter is not required for operation-type APIs.</para>
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
        /// <para>The data service project ID.</para>
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
