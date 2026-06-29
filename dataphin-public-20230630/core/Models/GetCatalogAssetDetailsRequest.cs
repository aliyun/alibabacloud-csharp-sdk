// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetCatalogAssetDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The paging query for the listing asset catalog list.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("GetCatalogAssetDetailsQuery")]
        [Validation(Required=false)]
        public GetCatalogAssetDetailsRequestGetCatalogAssetDetailsQuery GetCatalogAssetDetailsQuery { get; set; }
        public class GetCatalogAssetDetailsRequestGetCatalogAssetDetailsQuery : TeaModel {
            /// <summary>
            /// <para>The asset GUID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dp_ds_table.300023201.7311626611751680256.load_test.abc</para>
            /// </summary>
            [NameInMap("Guid")]
            [Validation(Required=false)]
            public string Guid { get; set; }

            /// <summary>
            /// <para>Specifies whether to include the field list. Default value: false. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false: Not included.</description></item>
            /// <item><description>true: Included.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("IncludeColumns")]
            [Validation(Required=false)]
            public bool? IncludeColumns { get; set; }

            /// <summary>
            /// <para>Specifies whether to include detailed data. Default value: false. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false: Not included.</description></item>
            /// <item><description>true: Included.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("IncludeDetailedAttributes")]
            [Validation(Required=false)]
            public bool? IncludeDetailedAttributes { get; set; }

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

    }

}
