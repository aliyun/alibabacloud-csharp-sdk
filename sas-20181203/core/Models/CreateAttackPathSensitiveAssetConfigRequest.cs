// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateAttackPathSensitiveAssetConfigRequest : TeaModel {
        /// <summary>
        /// <para>The list of cloud service assets.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AttackPathAssetList")]
        [Validation(Required=false)]
        public List<CreateAttackPathSensitiveAssetConfigRequestAttackPathAssetList> AttackPathAssetList { get; set; }
        public class CreateAttackPathSensitiveAssetConfigRequestAttackPathAssetList : TeaModel {
            /// <summary>
            /// <para>The subtype of the cloud service asset.</para>
            /// <remarks>
            /// <para>You can call the <a href="~~ListCloudAssetInstances~~">ListCloudAssetInstances</a> operation to query the subtype of the cloud service asset.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetSubType")]
            [Validation(Required=false)]
            public int? AssetSubType { get; set; }

            /// <summary>
            /// <para>The type of the cloud service asset.</para>
            /// <remarks>
            /// <para>You can call the <a href="~~ListCloudAssetInstances~~">ListCloudAssetInstances</a> operation to query the type of the cloud service asset.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            /// <summary>
            /// <para>The instance ID of the cloud service asset.</para>
            /// <remarks>
            /// <para>You can call the <a href="~~ListCloudAssetInstances~~">ListCloudAssetInstances</a> operation to query the instance ID of the cloud service asset.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-8vb0e8qdaj0yyxjo****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The region ID of the cloud service asset instance.</para>
            /// <remarks>
            /// <para>You can call the <a href="~~ListCloudAssetInstances~~">ListCloudAssetInstances</a> operation to query the region ID of the cloud service asset instance.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The vendor of the cloud service asset.</para>
            /// <remarks>
            /// <para>You can call the <a href="~~ListCloudAssetInstances~~">ListCloudAssetInstances</a> operation to query the vendor of the cloud service asset.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

        }

        /// <summary>
        /// <para>The configuration type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asset_instance: asset.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asset_instance</para>
        /// </summary>
        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

    }

}
