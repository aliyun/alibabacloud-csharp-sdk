// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetAssetMappingRelationsRequest : TeaModel {
        /// <summary>
        /// <para>The query instruction.</para>
        /// </summary>
        [NameInMap("AssetMappingQuery")]
        [Validation(Required=false)]
        public GetAssetMappingRelationsRequestAssetMappingQuery AssetMappingQuery { get; set; }
        public class GetAssetMappingRelationsRequestAssetMappingQuery : TeaModel {
            /// <summary>
            /// <para>The object type of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>COLUMN: field.</description></item>
            /// <item><description>INDEX: metric.</description></item>
            /// </list>
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
            /// <para>The type of the mapping relationship. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>VALID: mapped.</description></item>
            /// <item><description>INVALID: invalid mapping.</description></item>
            /// </list>
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

    }

}
