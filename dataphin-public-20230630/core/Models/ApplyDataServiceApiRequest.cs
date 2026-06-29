// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ApplyDataServiceApiRequest : TeaModel {
        /// <summary>
        /// <para>The apply command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApplyCommand")]
        [Validation(Required=false)]
        public ApplyDataServiceApiRequestApplyCommand ApplyCommand { get; set; }
        public class ApplyDataServiceApiRequestApplyCommand : TeaModel {
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
            /// <para>1203</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public int? AppId { get; set; }

            /// <summary>
            /// <para>Specifies whether to apply for permissions on operation-type APIs in the development environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ApplyDev")]
            [Validation(Required=false)]
            public bool? ApplyDev { get; set; }

            /// <summary>
            /// <para>Specifies whether to apply for permissions on operation-type APIs in the production environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ApplyProd")]
            [Validation(Required=false)]
            public bool? ApplyProd { get; set; }

            /// <summary>
            /// <para>The application type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>APP: application.</description></item>
            /// <item><description>USER: individual account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>APP</para>
            /// </summary>
            [NameInMap("ApplyType")]
            [Validation(Required=false)]
            public string ApplyType { get; set; }

            /// <summary>
            /// <para>The list of permission types.</para>
            /// <list type="bullet">
            /// <item><description><para>When the principal is an application, the following permission types are supported. To apply for delegation permissions, you must also apply for usage permissions.</para>
            /// <list type="bullet">
            /// <item><description>USE: usage permission.</description></item>
            /// <item><description>DELEGATION: delegation permission.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>When the principal is an individual, only USE (usage) permission is supported.</para>
            /// </description></item>
            /// <item><description><para>If this parameter is not specified, the default value is USE (usage) permission.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("AuthTypes")]
            [Validation(Required=false)]
            public List<string> AuthTypes { get; set; }

            /// <summary>
            /// <para>The list of permission fields for query-type APIs in the development environment. This parameter is required in dev-prod mode. DevFieldList and ProdFieldList cannot both be empty.</para>
            /// </summary>
            [NameInMap("DevFieldList")]
            [Validation(Required=false)]
            public List<ApplyDataServiceApiRequestApplyCommandDevFieldList> DevFieldList { get; set; }
            public class ApplyDataServiceApiRequestApplyCommandDevFieldList : TeaModel {
                /// <summary>
                /// <para>The API permission field ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
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
            /// <para>The list of permission fields for query-type APIs in the production environment. This parameter is required in basic mode.</para>
            /// </summary>
            [NameInMap("ProdFieldList")]
            [Validation(Required=false)]
            public List<ApplyDataServiceApiRequestApplyCommandProdFieldList> ProdFieldList { get; set; }
            public class ApplyDataServiceApiRequestApplyCommandProdFieldList : TeaModel {
                /// <summary>
                /// <para>The API permission field ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

            }

            /// <summary>
            /// <para>The reason for the application.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

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
