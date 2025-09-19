// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAttackPathEventRequest : TeaModel {
        /// <summary>
        /// <para>List of cloud product assets in the attack path.</para>
        /// </summary>
        [NameInMap("AttackPathAssetList")]
        [Validation(Required=false)]
        public List<ListAttackPathEventRequestAttackPathAssetList> AttackPathAssetList { get; set; }
        public class ListAttackPathEventRequestAttackPathAssetList : TeaModel {
            /// <summary>
            /// <para>Subtype of the cloud product asset.</para>
            /// <remarks>
            /// <para>You can call <a href="~~ListSupportAttackPathAsset~~">ListSupportAttackPathAsset</a> to query the subtype of the cloud product asset.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AssetSubType")]
            [Validation(Required=false)]
            public int? AssetSubType { get; set; }

            /// <summary>
            /// <para>Type of the cloud product asset.</para>
            /// <remarks>
            /// <para>You can call <a href="~~ListSupportAttackPathAsset~~">ListSupportAttackPathAsset</a> to query the type of the cloud product asset.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>17</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public int? AssetType { get; set; }

            /// <summary>
            /// <para>Node type, values:</para>
            /// <list type="bullet">
            /// <item><description><b>start</b>: start point.</description></item>
            /// <item><description><b>end</b>: end point.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>start</para>
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>Vendor of the cloud product asset.</para>
            /// <remarks>
            /// <para>You can call <a href="~~ListSupportAttackPathAsset~~">ListSupportAttackPathAsset</a> to query the vendor of the cloud product asset.</para>
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
        /// <para>Specifies from which page of the returned results the query results should be displayed. The default value is 1, indicating that the display starts from the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Timestamp of the end time. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1668064495000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Sets the language type for requests and received messages, with the default being <b>zh</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of data entries displayed per page in a paginated query. The default value is <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Description of the path name.</para>
        /// <remarks>
        /// <para>You can call <a href="~~ListAvailableAttackPath~~">ListAvailableAttackPath</a> to query the path name description.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ECS Instance Can Obtain Long-term Access Credential by Enabling Console Logon for RAM User</para>
        /// </summary>
        [NameInMap("PathNameDesc")]
        [Validation(Required=false)]
        public string PathNameDesc { get; set; }

        /// <summary>
        /// <para>Path type.</para>
        /// <remarks>
        /// <para>You can call <a href="~~ListAvailableAttackPath~~">ListAvailableAttackPath</a> to query the path type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>role_escalation</para>
        /// </summary>
        [NameInMap("PathType")]
        [Validation(Required=false)]
        public string PathType { get; set; }

        /// <summary>
        /// <para>List of risk level information.</para>
        /// </summary>
        [NameInMap("RiskLevelList")]
        [Validation(Required=false)]
        public List<string> RiskLevelList { get; set; }

        /// <summary>
        /// <para>Timestamp of the start time. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1666886400000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
