// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateAttackPathSensitiveAssetConfigRequest : TeaModel {
        /// <summary>
        /// <para>List of cloud product assets in the attack path.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AttackPathAssetList")]
        [Validation(Required=false)]
        public List<UpdateAttackPathSensitiveAssetConfigRequestAttackPathAssetList> AttackPathAssetList { get; set; }
        public class UpdateAttackPathSensitiveAssetConfigRequestAttackPathAssetList : TeaModel {
            /// <summary>
            /// <para>Subtype of the cloud product asset.</para>
            /// <remarks>
            /// <para>You can call <a href="~~ListCloudAssetInstances~~">ListCloudAssetInstances</a> to query the subtype of the cloud product asset.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("AssetSubType")]
            [Validation(Required=false)]
            public int? AssetSubType { get; set; }

            /// <summary>
            /// <para>Type of the cloud product asset.</para>
            /// <remarks>
            /// <para>You can call <a href="~~ListCloudAssetInstances~~">ListCloudAssetInstances</a> to query the type of the cloud product asset.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            /// <summary>
            /// <para>Cloud product asset instance ID.</para>
            /// <remarks>
            /// <para>You can call <a href="~~ListCloudAssetInstances~~">ListCloudAssetInstances</a> to query the cloud product asset instance ID.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-2ze357b4mrkwi7tq****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Region ID of the cloud product asset instance.</para>
            /// <remarks>
            /// <para>You can call <a href="~~ListCloudAssetInstances~~">ListCloudAssetInstances</a> to query the region ID of the cloud product asset instance.</para>
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
            /// <para>Vendor of the cloud product asset.</para>
            /// <remarks>
            /// <para>You can call <a href="~~ListCloudAssetInstances~~">ListCloudAssetInstances</a> to query the vendor of the cloud product asset.</para>
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
        /// <para>ID of the sensitive asset setting for the attack path.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apsac-123</para>
        /// </summary>
        [NameInMap("AttackPathSensitiveAssetConfigId")]
        [Validation(Required=false)]
        public string AttackPathSensitiveAssetConfigId { get; set; }

    }

}
