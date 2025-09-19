// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAttackPathWhitelistResponseBody : TeaModel {
        /// <summary>
        /// <para>Attack path whitelist.</para>
        /// </summary>
        [NameInMap("AttackPathWhitelist")]
        [Validation(Required=false)]
        public GetAttackPathWhitelistResponseBodyAttackPathWhitelist AttackPathWhitelist { get; set; }
        public class GetAttackPathWhitelistResponseBodyAttackPathWhitelist : TeaModel {
            /// <summary>
            /// <para>List of cloud product assets in the attack path.</para>
            /// </summary>
            [NameInMap("AttackPathAssetList")]
            [Validation(Required=false)]
            public List<GetAttackPathWhitelistResponseBodyAttackPathWhitelistAttackPathAssetList> AttackPathAssetList { get; set; }
            public class GetAttackPathWhitelistResponseBodyAttackPathWhitelistAttackPathAssetList : TeaModel {
                /// <summary>
                /// <para>Subtype of the cloud product asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AssetSubType")]
                [Validation(Required=false)]
                public int? AssetSubType { get; set; }

                /// <summary>
                /// <para>Type of the cloud product asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AssetType")]
                [Validation(Required=false)]
                public int? AssetType { get; set; }

                /// <summary>
                /// <para>Instance ID of the cloud product asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-8vb0e8qdaj0yyxjo****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xwl</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>Node type, values:</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>Vendor of the cloud product asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public int? Vendor { get; set; }

            }

            /// <summary>
            /// <para>Attack path whitelist ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apwl-b33dec0acf9b42aabde032d656c0****</para>
            /// </summary>
            [NameInMap("AttackPathWhitelistId")]
            [Validation(Required=false)]
            public string AttackPathWhitelistId { get; set; }

            /// <summary>
            /// <para>Last modified timestamp, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1743004587000</para>
            /// </summary>
            [NameInMap("LastModifiedTimestamp")]
            [Validation(Required=false)]
            public long? LastModifiedTimestamp { get; set; }

            /// <summary>
            /// <para>Path name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs_get_credential_by_create_login_profile</para>
            /// </summary>
            [NameInMap("PathName")]
            [Validation(Required=false)]
            public string PathName { get; set; }

            /// <summary>
            /// <para>Path type.</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("WhitelistName")]
            [Validation(Required=false)]
            public string WhitelistName { get; set; }

            /// <summary>
            /// <para>Whitelist type. Possible values:</para>
            /// <list type="bullet">
            /// <item><description><b>ALL_ASSET</b>: All assets</description></item>
            /// <item><description><b>PART_ASSET</b>: Partial assets</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALL_ASSET</para>
            /// </summary>
            [NameInMap("WhitelistType")]
            [Validation(Required=false)]
            public string WhitelistType { get; set; }

        }

        /// <summary>
        /// <para>The ID of this request, which is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting and problem localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D03DD0FD-6041-5107-AC00-383E28F1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
