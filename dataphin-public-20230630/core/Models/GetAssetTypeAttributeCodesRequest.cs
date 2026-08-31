// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetAssetTypeAttributeCodesRequest : TeaModel {
        /// <summary>
        /// <para>The asset type filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TABLE: table.</description></item>
        /// <item><description>COLUMN: column.</description></item>
        /// <item><description>INDEX: metric.</description></item>
        /// <item><description>BIZ_INDEX: business metric.</description></item>
        /// <item><description>API: API.</description></item>
        /// <item><description>PAGE: dashboard.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TABLE</para>
        /// </summary>
        [NameInMap("AssetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

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
