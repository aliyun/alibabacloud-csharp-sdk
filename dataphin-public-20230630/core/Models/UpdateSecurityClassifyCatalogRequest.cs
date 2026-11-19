// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateSecurityClassifyCatalogRequest : TeaModel {
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
        /// <para>The update command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateSecurityClassifyCatalogRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateSecurityClassifyCatalogRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <para>The name of the classification catalog.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of administrator IDs. This parameter is valid only when the parent catalog is the root catalog.</para>
            /// </summary>
            [NameInMap("OwnerList")]
            [Validation(Required=false)]
            public List<string> OwnerList { get; set; }

            /// <summary>
            /// <para>The full path of the parent classification catalog. Default value: /.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/d1/</para>
            /// </summary>
            [NameInMap("ParentPath")]
            [Validation(Required=false)]
            public string ParentPath { get; set; }

            /// <summary>
            /// <para>The original full path of the catalog.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/d1/d2/</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The classification visibility scope. Valid values: PUBLIC (public) and PRIVATE (visible only to administrators). Default value: PUBLIC. This parameter is valid only when the parent catalog is the root catalog.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLIC</para>
            /// </summary>
            [NameInMap("VisibleType")]
            [Validation(Required=false)]
            public string VisibleType { get; set; }

        }

    }

}
