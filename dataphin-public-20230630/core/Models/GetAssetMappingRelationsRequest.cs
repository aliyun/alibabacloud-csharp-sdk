// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetAssetMappingRelationsRequest : TeaModel {
        /// <summary>
        /// <para>The query command.</para>
        /// </summary>
        [NameInMap("AssetMappingQuery")]
        [Validation(Required=false)]
        public GetAssetMappingRelationsRequestAssetMappingQuery AssetMappingQuery { get; set; }
        public class GetAssetMappingRelationsRequestAssetMappingQuery : TeaModel {
            /// <summary>
            /// <para>The asset object type. Valid values: COLUMN (field) and INDEX (metric).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INDEX</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public string AssetType { get; set; }

            /// <summary>
            /// <para>The GUID of the asset object.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1121</para>
            /// </summary>
            [NameInMap("Guid")]
            [Validation(Required=false)]
            public string Guid { get; set; }

            /// <summary>
            /// <para>The mapping relationship type. Valid values: VALID (mapped) and INVALID (invalid mapping).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VALID</para>
            /// </summary>
            [NameInMap("RelationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

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

    }

}
