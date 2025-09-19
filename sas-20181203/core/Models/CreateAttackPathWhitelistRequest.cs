// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateAttackPathWhitelistRequest : TeaModel {
        /// <summary>
        /// <para>List of cloud product assets in the attack path.</para>
        /// </summary>
        [NameInMap("AttackPathAssetList")]
        [Validation(Required=false)]
        public List<CreateAttackPathWhitelistRequestAttackPathAssetList> AttackPathAssetList { get; set; }
        public class CreateAttackPathWhitelistRequestAttackPathAssetList : TeaModel {
            /// <summary>
            /// <para>Subtype of the cloud product asset.</para>
            /// <remarks>
            /// <para>You can call <a href="~~ListCloudAssetInstances~~">ListCloudAssetInstances</a> to query the subtype of the cloud product asset.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetSubType")]
            [Validation(Required=false)]
            public int? AssetSubType { get; set; }

            /// <summary>
            /// <para>Type of the cloud product asset.</para>
            /// <remarks>
            /// <para>You can call <a href="~~ListCloudAssetInstances~~">ListCloudAssetInstances</a> to query the type of the cloud product asset.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            /// <summary>
            /// <para>Cloud product asset instance ID.</para>
            /// <remarks>
            /// <para>You can call <a href="~~ListCloudAssetInstances~~">ListCloudAssetInstances</a> to query the cloud product asset instance ID.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>i-8vb0e8qdaj0yyxjo****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Node type, with values:</para>
            /// <list type="bullet">
            /// <item><description><b>start</b>: Start point.</description></item>
            /// <item><description><b>end</b>: End point.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>start</para>
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>Region ID of the cloud product asset instance.</para>
            /// <remarks>
            /// <para>You can call <a href="~~ListCloudAssetInstances~~">ListCloudAssetInstances</a> to query the region ID of the cloud product asset instance.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Vendor of the cloud product asset.</para>
            /// <remarks>
            /// <para>You can call <a href="~~ListCloudAssetInstances~~">ListCloudAssetInstances</a> to query the vendor of the cloud product asset.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public int? Vendor { get; set; }

        }

        /// <summary>
        /// <para>Path name.</para>
        /// <remarks>
        /// <para>You can call <a href="~~ListAvailableAttackPath~~">ListAvailableAttackPath</a> to query the path name.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecs_get_credential_by_create_login_profile</para>
        /// </summary>
        [NameInMap("PathName")]
        [Validation(Required=false)]
        public string PathName { get; set; }

        /// <summary>
        /// <para>Path type.</para>
        /// <remarks>
        /// <para>You can call <a href="~~ListAvailableAttackPath~~">ListAvailableAttackPath</a> to query the path type.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>role_escalation</para>
        /// </summary>
        [NameInMap("PathType")]
        [Validation(Required=false)]
        public string PathType { get; set; }

        /// <summary>
        /// <para>Remark information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>Whitelist name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("WhitelistName")]
        [Validation(Required=false)]
        public string WhitelistName { get; set; }

        /// <summary>
        /// <para>Whitelist type. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALL_ASSET</b>: All assets</description></item>
        /// <item><description><b>PART_ASSET</b>: Partial assets</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL_ASSET</para>
        /// </summary>
        [NameInMap("WhitelistType")]
        [Validation(Required=false)]
        public string WhitelistType { get; set; }

    }

}
