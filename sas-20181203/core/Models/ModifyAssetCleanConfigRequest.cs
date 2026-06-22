// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyAssetCleanConfigRequest : TeaModel {
        /// <summary>
        /// <para>The list of asset cleanup configurations.</para>
        /// </summary>
        [NameInMap("AssetCleanConfigs")]
        [Validation(Required=false)]
        public List<ModifyAssetCleanConfigRequestAssetCleanConfigs> AssetCleanConfigs { get; set; }
        public class ModifyAssetCleanConfigRequestAssetCleanConfigs : TeaModel {
            /// <summary>
            /// <para>The number of offline days after which non-Alibaba Cloud hosts are automatically cleaned up. Valid values: integers from 1 to 30.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("CleanDays")]
            [Validation(Required=false)]
            public int? CleanDays { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable automatic cleanup of offline non-Alibaba Cloud hosts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Disabled.</description></item>
            /// <item><description><b>1</b>: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The type of host to clean up. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: non-Alibaba Cloud host.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

    }

}
