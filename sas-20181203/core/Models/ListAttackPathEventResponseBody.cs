// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAttackPathEventResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of attack path events.</para>
        /// </summary>
        [NameInMap("AttackPathEventList")]
        [Validation(Required=false)]
        public List<ListAttackPathEventResponseBodyAttackPathEventList> AttackPathEventList { get; set; }
        public class ListAttackPathEventResponseBodyAttackPathEventList : TeaModel {
            /// <summary>
            /// <para>The destination asset.</para>
            /// </summary>
            [NameInMap("DstAsset")]
            [Validation(Required=false)]
            public ListAttackPathEventResponseBodyAttackPathEventListDstAsset DstAsset { get; set; }
            public class ListAttackPathEventResponseBodyAttackPathEventListDstAsset : TeaModel {
                /// <summary>
                /// <para>The subtype of the cloud service asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AssetSubType")]
                [Validation(Required=false)]
                public int? AssetSubType { get; set; }

                /// <summary>
                /// <para>The type of the cloud service asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AssetType")]
                [Validation(Required=false)]
                public int? AssetType { get; set; }

                /// <summary>
                /// <para>The ID of the cloud service asset instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-uf6a1tt9umxwoxqn****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The region ID of the cloud service asset instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The sensitive asset flag. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Not a sensitive asset.</description></item>
                /// <item><description><b>1</b>: A sensitive asset.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SensitiveAssetFlag")]
                [Validation(Required=false)]
                public int? SensitiveAssetFlag { get; set; }

                /// <summary>
                /// <para>The vendor of the cloud service asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public int? Vendor { get; set; }

            }

            /// <summary>
            /// <para>The ID of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public long? EventId { get; set; }

            /// <summary>
            /// <para>The timestamp of the most recent detection. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1742869699000</para>
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            /// <summary>
            /// <para>The path name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs_get_credential_by_create_login_profile</para>
            /// </summary>
            [NameInMap("PathName")]
            [Validation(Required=false)]
            public string PathName { get; set; }

            /// <summary>
            /// <para>The path name description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS Instance Can Obtain Long-term Access Credential by Enabling Console Logon for RAM User</para>
            /// </summary>
            [NameInMap("PathNameDesc")]
            [Validation(Required=false)]
            public string PathNameDesc { get; set; }

            /// <summary>
            /// <para>The path type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>role_escalation</para>
            /// </summary>
            [NameInMap("PathType")]
            [Validation(Required=false)]
            public string PathType { get; set; }

            /// <summary>
            /// <para>The path type description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Privilege Escalation by Role</para>
            /// </summary>
            [NameInMap("PathTypeDesc")]
            [Validation(Required=false)]
            public string PathTypeDesc { get; set; }

            /// <summary>
            /// <para>The risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>suspicious</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The source asset.</para>
            /// </summary>
            [NameInMap("SrcAsset")]
            [Validation(Required=false)]
            public ListAttackPathEventResponseBodyAttackPathEventListSrcAsset SrcAsset { get; set; }
            public class ListAttackPathEventResponseBodyAttackPathEventListSrcAsset : TeaModel {
                /// <summary>
                /// <para>The subtype of the cloud service asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AssetSubType")]
                [Validation(Required=false)]
                public int? AssetSubType { get; set; }

                /// <summary>
                /// <para>The type of the cloud service asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AssetType")]
                [Validation(Required=false)]
                public int? AssetType { get; set; }

                /// <summary>
                /// <para>The ID of the cloud service asset instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp18ifsr1tu1dx39****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The region ID of the cloud service asset instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The sensitive asset flag. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Not a sensitive asset.</description></item>
                /// <item><description><b>1</b>: A sensitive asset.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SensitiveAssetFlag")]
                [Validation(Required=false)]
                public int? SensitiveAssetFlag { get; set; }

                /// <summary>
                /// <para>The vendor of the cloud service asset.</para>
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
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListAttackPathEventResponseBodyPageInfo PageInfo { get; set; }
        public class ListAttackPathEventResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries on the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3956048F-9D73-5EDB-834B-4827BB48****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
