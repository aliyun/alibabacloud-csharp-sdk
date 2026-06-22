// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAttackPathEventRequest : TeaModel {
        /// <summary>
        /// <para>The list of cloud service assets in the attack path.</para>
        /// </summary>
        [NameInMap("AttackPathAssetList")]
        [Validation(Required=false)]
        public List<ListAttackPathEventRequestAttackPathAssetList> AttackPathAssetList { get; set; }
        public class ListAttackPathEventRequestAttackPathAssetList : TeaModel {
            /// <summary>
            /// <para>The subtype of the cloud service asset.</para>
            /// <remarks>
            /// <para>Call <a href="~~ListSupportAttackPathAsset~~">ListSupportAttackPathAsset</a> to query the subtypes of cloud service assets.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AssetSubType")]
            [Validation(Required=false)]
            public int? AssetSubType { get; set; }

            /// <summary>
            /// <para>The type of the cloud service asset.</para>
            /// <remarks>
            /// <para>Call <a href="~~ListSupportAttackPathAsset~~">ListSupportAttackPathAsset</a> to query the types of cloud service assets.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>17</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            /// <summary>
            /// <para>The node type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>start</b>: start node.</description></item>
            /// <item><description><b>end</b>: end node.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>start</para>
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>The vendor of the cloud service asset.</para>
            /// <remarks>
            /// <para>Call <a href="~~ListSupportAttackPathAsset~~">ListSupportAttackPathAsset</a> to query the vendors of cloud service assets.</para>
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
        /// <para>The page number of the results to return. Default value: 1, which indicates the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end time as a timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1668064495000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page in a paged query. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The path name description.</para>
        /// <remarks>
        /// <para>Call <a href="~~ListAvailableAttackPath~~">ListAvailableAttackPath</a> to query path name descriptions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ECS Instance Can Obtain Long-term Access Credential by Enabling Console Logon for RAM User</para>
        /// </summary>
        [NameInMap("PathNameDesc")]
        [Validation(Required=false)]
        public string PathNameDesc { get; set; }

        /// <summary>
        /// <para>The path type.</para>
        /// <remarks>
        /// <para>Call <a href="~~ListAvailableAttackPath~~">ListAvailableAttackPath</a> to query path types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>role_escalation</para>
        /// </summary>
        [NameInMap("PathType")]
        [Validation(Required=false)]
        public string PathType { get; set; }

        /// <summary>
        /// <para>The list of risk levels.</para>
        /// </summary>
        [NameInMap("RiskLevelList")]
        [Validation(Required=false)]
        public List<string> RiskLevelList { get; set; }

        /// <summary>
        /// <para>The start time as a timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1666886400000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
