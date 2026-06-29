// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetBelongAssetMappingRequest : TeaModel {
        /// <summary>
        /// <para>Query command.</para>
        /// </summary>
        [NameInMap("AssetMappingQuery")]
        [Validation(Required=false)]
        public GetBelongAssetMappingRequestAssetMappingQuery AssetMappingQuery { get; set; }
        public class GetBelongAssetMappingRequestAssetMappingQuery : TeaModel {
            /// <summary>
            /// <para>The GUID of the belonging asset.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1121</para>
            /// </summary>
            [NameInMap("BelongGuid")]
            [Validation(Required=false)]
            public string BelongGuid { get; set; }

            /// <summary>
            /// <para>The mapping relationship type. Valid values: VALID (mapped) and INVALID (invalid mapping).</para>
            /// 
            /// <b>Example:</b>
            /// <para>VALID</para>
            /// </summary>
            [NameInMap("RelationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

        }

        /// <summary>
        /// <para>Tenant ID.</para>
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
