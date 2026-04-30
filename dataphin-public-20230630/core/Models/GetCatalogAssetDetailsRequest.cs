// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetCatalogAssetDetailsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("GetCatalogAssetDetailsQuery")]
        [Validation(Required=false)]
        public GetCatalogAssetDetailsRequestGetCatalogAssetDetailsQuery GetCatalogAssetDetailsQuery { get; set; }
        public class GetCatalogAssetDetailsRequestGetCatalogAssetDetailsQuery : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dp_ds_table.300023201.7311626611751680256.load_test.abc</para>
            /// </summary>
            [NameInMap("Guid")]
            [Validation(Required=false)]
            public string Guid { get; set; }

            [NameInMap("IncludeColumns")]
            [Validation(Required=false)]
            public bool? IncludeColumns { get; set; }

            [NameInMap("IncludeDetailedAttributes")]
            [Validation(Required=false)]
            public bool? IncludeDetailedAttributes { get; set; }

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

    }

}
