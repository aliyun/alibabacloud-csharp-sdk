// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyAssetCleanConfigRequest : TeaModel {
        /// <summary>
        /// <para>The asset cleanup configurations.</para>
        /// </summary>
        [NameInMap("AssetCleanConfigs")]
        [Validation(Required=false)]
        public List<ModifyAssetCleanConfigRequestAssetCleanConfigs> AssetCleanConfigs { get; set; }
        public class ModifyAssetCleanConfigRequestAssetCleanConfigs : TeaModel {
            /// <summary>
            /// <para>The number of days before hosts whose provider cannot be identified are automatically cleaned after they enter the offline state. Valid value: an integer that ranges from 1 to 30.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("CleanDays")]
            [Validation(Required=false)]
            public int? CleanDays { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the feature of cleaning the offline hosts whose provider cannot be identified. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disables the feature.</description></item>
            /// <item><description><b>1</b>: enables the feature.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The type of hosts that you want to clean.</para>
            /// <para>Set the value to <b>1</b>, which indicates hosts whose provider cannot be identified.</para>
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
