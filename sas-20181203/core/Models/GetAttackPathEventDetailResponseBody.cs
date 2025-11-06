// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAttackPathEventDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the attack path event.</para>
        /// </summary>
        [NameInMap("AttackPathEvent")]
        [Validation(Required=false)]
        public GetAttackPathEventDetailResponseBodyAttackPathEvent AttackPathEvent { get; set; }
        public class GetAttackPathEventDetailResponseBodyAttackPathEvent : TeaModel {
            /// <summary>
            /// <para>Destination asset.</para>
            /// </summary>
            [NameInMap("DstAsset")]
            [Validation(Required=false)]
            public GetAttackPathEventDetailResponseBodyAttackPathEventDstAsset DstAsset { get; set; }
            public class GetAttackPathEventDetailResponseBodyAttackPathEventDstAsset : TeaModel {
                /// <summary>
                /// <para>Subtype of the cloud product asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("AssetSubType")]
                [Validation(Required=false)]
                public int? AssetSubType { get; set; }

                /// <summary>
                /// <para>Type of the cloud product asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("AssetType")]
                [Validation(Required=false)]
                public int? AssetType { get; set; }

                /// <summary>
                /// <para>ID of the cloud product asset instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp18ifsr1tu1dx39****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>ID of the region where the cloud product asset instance is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>Sensitive asset flag. Values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Non-sensitive asset.</description></item>
                /// <item><description><b>1</b>: Sensitive asset.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SensitiveAssetFlag")]
                [Validation(Required=false)]
                public int? SensitiveAssetFlag { get; set; }

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
            /// <para>Timestamp of the first occurrence, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1735956726000</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// <para>Timestamp of the latest discovery, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1741832168000</para>
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            /// <summary>
            /// <para>Detailed description of the path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The system detects that the role that trusts another Alibaba Cloud account has administrator permissions. This can cause the system to be fully controlled. We recommend that you delete the trust relationship and review the permissions of the role.</para>
            /// </summary>
            [NameInMap("PathDetailDesc")]
            [Validation(Required=false)]
            public string PathDetailDesc { get; set; }

            /// <summary>
            /// <para>List of path event edges.</para>
            /// </summary>
            [NameInMap("PathEventEdgeList")]
            [Validation(Required=false)]
            public List<GetAttackPathEventDetailResponseBodyAttackPathEventPathEventEdgeList> PathEventEdgeList { get; set; }
            public class GetAttackPathEventDetailResponseBodyAttackPathEventPathEventEdgeList : TeaModel {
                /// <summary>
                /// <para>Edge ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("EdgeId")]
                [Validation(Required=false)]
                public long? EdgeId { get; set; }

                /// <summary>
                /// <para>Edge type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>role_trust_user</para>
                /// </summary>
                [NameInMap("EdgeType")]
                [Validation(Required=false)]
                public string EdgeType { get; set; }

                /// <summary>
                /// <para>Edge element type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>branch</para>
                /// </summary>
                [NameInMap("ElementType")]
                [Validation(Required=false)]
                public string ElementType { get; set; }

                /// <summary>
                /// <para>UUID of the end node of the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>52d59cca9d1768bab5fe081317637990</para>
                /// </summary>
                [NameInMap("EndNodeUuid")]
                [Validation(Required=false)]
                public string EndNodeUuid { get; set; }

                /// <summary>
                /// <para>Description of the repair suggestion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The RAM role is granted the administrator permissions and trusts the user of another Alibaba Cloud account. In this case, the current Alibaba Cloud account may be fully controlled by the trusted Alibaba Cloud account. We recommend that you delete the trust relationship. If you need to trust another Alibaba Cloud account, we recommend that you split your business requirements and follow the principle of least privilege to grant permissions across accounts in a fine-grained manner. You can also use RAM.\n\nIf you confirm that the role does not need to trust an Alibaba Cloud account, perform the following operations: In the RAM console, click the required RAM role. On the page that appears, view the trust policy of the role. Then, edit the Service field to delete the trust relationship. If you confirm that permissions can be reduced, perform the following operations: In the RAM console, click the required RAM role. On the page that appears, view the permissions of the role. Then, find the policy that defines the administrator permissions and revoke the policy. Attach another policy to the role based on your business requirements.</para>
                /// </summary>
                [NameInMap("RepairSuggestionDisplay")]
                [Validation(Required=false)]
                public string RepairSuggestionDisplay { get; set; }

                /// <summary>
                /// <para>UUID of the start node of the edge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>b7e1bd42c4ca47f69020f4a27b47d2b4</para>
                /// </summary>
                [NameInMap("StartNodeUuid")]
                [Validation(Required=false)]
                public string StartNodeUuid { get; set; }

            }

            /// <summary>
            /// <para>List of path nodes.</para>
            /// </summary>
            [NameInMap("PathEventNodeList")]
            [Validation(Required=false)]
            public List<GetAttackPathEventDetailResponseBodyAttackPathEventPathEventNodeList> PathEventNodeList { get; set; }
            public class GetAttackPathEventDetailResponseBodyAttackPathEventPathEventNodeList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AiAssetFlag")]
                [Validation(Required=false)]
                public int? AiAssetFlag { get; set; }

                /// <summary>
                /// <para>Node element type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>branch</para>
                /// </summary>
                [NameInMap("ElementType")]
                [Validation(Required=false)]
                public string ElementType { get; set; }

                /// <summary>
                /// <para>Details of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;assetId&quot;:0}</para>
                /// </summary>
                [NameInMap("NodeDetail")]
                [Validation(Required=false)]
                public string NodeDetail { get; set; }

                /// <summary>
                /// <para>Name of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hypermatch_uploader</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>Type of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <para>UUID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>52d59cca9d1768bab5fe081317637990</para>
                /// </summary>
                [NameInMap("NodeUuid")]
                [Validation(Required=false)]
                public string NodeUuid { get; set; }

                /// <summary>
                /// <para>Sensitive asset flag. Values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Non-sensitive asset.</description></item>
                /// <item><description><b>1</b>: Sensitive asset.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SensitiveAssetFlag")]
                [Validation(Required=false)]
                public int? SensitiveAssetFlag { get; set; }

            }

            /// <summary>
            /// <para>Name of the path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs_get_credential_by_create_login_profile</para>
            /// </summary>
            [NameInMap("PathName")]
            [Validation(Required=false)]
            public string PathName { get; set; }

            /// <summary>
            /// <para>Description of the path name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS Instance Can Obtain Long-term Access Credential by Enabling Console Logon for RAM User</para>
            /// </summary>
            [NameInMap("PathNameDesc")]
            [Validation(Required=false)]
            public string PathNameDesc { get; set; }

            /// <summary>
            /// <para>Type of the path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>role_escalation</para>
            /// </summary>
            [NameInMap("PathType")]
            [Validation(Required=false)]
            public string PathType { get; set; }

            /// <summary>
            /// <para>Description of the path type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Privilege Escalation by Role</para>
            /// </summary>
            [NameInMap("PathTypeDesc")]
            [Validation(Required=false)]
            public string PathTypeDesc { get; set; }

            /// <summary>
            /// <para>Risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>suspicious</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>Source asset.</para>
            /// </summary>
            [NameInMap("SrcAsset")]
            [Validation(Required=false)]
            public GetAttackPathEventDetailResponseBodyAttackPathEventSrcAsset SrcAsset { get; set; }
            public class GetAttackPathEventDetailResponseBodyAttackPathEventSrcAsset : TeaModel {
                /// <summary>
                /// <para>Subtype of the cloud product asset</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("AssetSubType")]
                [Validation(Required=false)]
                public int? AssetSubType { get; set; }

                /// <summary>
                /// <para>The type of the cloud product asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>14</para>
                /// </summary>
                [NameInMap("AssetType")]
                [Validation(Required=false)]
                public int? AssetType { get; set; }

                /// <summary>
                /// <para>The ID of the cloud product asset instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-25b24****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The ID of the region where the cloud product asset instance is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>Sensitive asset flag. Values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Non-sensitive asset.</description></item>
                /// <item><description><b>1</b>: Sensitive asset.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SensitiveAssetFlag")]
                [Validation(Required=false)]
                public int? SensitiveAssetFlag { get; set; }

                /// <summary>
                /// <para>The vendor of the cloud product asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public int? Vendor { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of this request, which is a unique identifier generated by Alibaba Cloud for the request, and can be used for troubleshooting and problem localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7BC55C8F-226E-5AF5-9A2C-2EC43864****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
