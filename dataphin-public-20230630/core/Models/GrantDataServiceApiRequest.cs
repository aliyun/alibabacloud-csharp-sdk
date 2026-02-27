// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GrantDataServiceApiRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("GrantCommand")]
        [Validation(Required=false)]
        public GrantDataServiceApiRequestGrantCommand GrantCommand { get; set; }
        public class GrantDataServiceApiRequestGrantCommand : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1021</para>
            /// </summary>
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public long? ApiId { get; set; }

            /// <summary>
            /// <para>AppID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1201</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public int? AppId { get; set; }

            [NameInMap("ApplyDev")]
            [Validation(Required=false)]
            public bool? ApplyDev { get; set; }

            [NameInMap("ApplyProd")]
            [Validation(Required=false)]
            public bool? ApplyProd { get; set; }

            [NameInMap("AuthTypes")]
            [Validation(Required=false)]
            public List<string> AuthTypes { get; set; }

            [NameInMap("DevFieldList")]
            [Validation(Required=false)]
            public List<GrantDataServiceApiRequestGrantCommandDevFieldList> DevFieldList { get; set; }
            public class GrantDataServiceApiRequestGrantCommandDevFieldList : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30</para>
            /// </summary>
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>APP</para>
            /// </summary>
            [NameInMap("GranteeType")]
            [Validation(Required=false)]
            public string GranteeType { get; set; }

            [NameInMap("ProdFieldList")]
            [Validation(Required=false)]
            public List<GrantDataServiceApiRequestGrantCommandProdFieldList> ProdFieldList { get; set; }
            public class GrantDataServiceApiRequestGrantCommandProdFieldList : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
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
