// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAuthSummaryResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether you can purchase protection quota on demand when you purchase Security Center. Valid values:
        /// 
        /// *   **0**: no
        /// *   **1**: yes
        /// </summary>
        [NameInMap("AllowPartialBuy")]
        [Validation(Required=false)]
        public int? AllowPartialBuy { get; set; }

        /// <summary>
        /// Indicates whether you can purchase protection quota on demand after an upgrade. Valid values:
        /// 
        /// *   **0**: no
        /// *   **1**: yes
        /// </summary>
        [NameInMap("AllowUpgradePartialBuy")]
        [Validation(Required=false)]
        public int? AllowUpgradePartialBuy { get; set; }

        /// <summary>
        /// Indicates whether all bound assets can be immediately unbound. Valid values:
        /// 
        /// *   **0**: no
        /// *   **1**: yes
        /// </summary>
        [NameInMap("AllowUserUnbind")]
        [Validation(Required=false)]
        public int? AllowUserUnbind { get; set; }

        /// <summary>
        /// Indicates whether automatic binding is enabled. Valid values:
        /// 
        /// *   **0**: disabled
        /// *   **1**: enabled
        /// </summary>
        [NameInMap("AutoBind")]
        [Validation(Required=false)]
        public int? AutoBind { get; set; }

        /// <summary>
        /// Indicates whether the protection quota is supported for all assets. Valid values:
        /// 
        /// *   **0**: no
        /// *   **1**: yes
        /// </summary>
        [NameInMap("DefaultAuthToAll")]
        [Validation(Required=false)]
        public int? DefaultAuthToAll { get; set; }

        /// <summary>
        /// Indicates whether pre-bound assets exist. If you select assets to bind when you purchase Security Center, pre-bound assets exist. Valid values:
        /// 
        /// *   **0**: no
        /// *   **1**: yes
        /// </summary>
        [NameInMap("HasPreBindSetting")]
        [Validation(Required=false)]
        public bool? HasPreBindSetting { get; set; }

        /// <summary>
        /// The most advanced edition that is used. Valid values:
        /// 
        /// *   **1**: Basic edition
        /// *   **3**: Enterprise edition
        /// *   **5**: Advanced edition
        /// *   **6**: Anti-virus edition
        /// *   **7**: Ultimate edition
        /// *   **10**: Value-added Plan edition
        /// 
        /// >  If you purchase Security Center Multi-edition, the value indicates the most advanced edition that is used. Otherwise, the value indicates the specific edition that is purchased.
        /// </summary>
        [NameInMap("HighestVersion")]
        [Validation(Required=false)]
        public int? HighestVersion { get; set; }

        /// <summary>
        /// Indicates whether Security Center Multi-edition is purchased. Valid values:
        /// 
        /// *   **0**: no
        /// *   **1**: yes
        /// </summary>
        [NameInMap("IsMultiVersion")]
        [Validation(Required=false)]
        public int? IsMultiVersion { get; set; }

        /// <summary>
        /// The statistics of the protection quota for assets.
        /// </summary>
        [NameInMap("Machine")]
        [Validation(Required=false)]
        public GetAuthSummaryResponseBodyMachine Machine { get; set; }
        public class GetAuthSummaryResponseBodyMachine : TeaModel {
            /// <summary>
            /// The number of cores of the assets that are bound to Security Center.
            /// </summary>
            [NameInMap("BindCoreCount")]
            [Validation(Required=false)]
            public int? BindCoreCount { get; set; }

            /// <summary>
            /// The number of the assets that are bound to Security Center.
            /// </summary>
            [NameInMap("BindEcsCount")]
            [Validation(Required=false)]
            public int? BindEcsCount { get; set; }

            /// <summary>
            /// The number of cores of the assets that are at risk.
            /// </summary>
            [NameInMap("RiskCoreCount")]
            [Validation(Required=false)]
            public int? RiskCoreCount { get; set; }

            /// <summary>
            /// The number of the assets that are at risk.
            /// </summary>
            [NameInMap("RiskEcsCount")]
            [Validation(Required=false)]
            public int? RiskEcsCount { get; set; }

            /// <summary>
            /// The total number of asset cores.
            /// </summary>
            [NameInMap("TotalCoreCount")]
            [Validation(Required=false)]
            public int? TotalCoreCount { get; set; }

            /// <summary>
            /// The total number of assets.
            /// </summary>
            [NameInMap("TotalEcsCount")]
            [Validation(Required=false)]
            public int? TotalEcsCount { get; set; }

            /// <summary>
            /// The number of cores of unbound assets.
            /// </summary>
            [NameInMap("UnBindCoreCount")]
            [Validation(Required=false)]
            public int? UnBindCoreCount { get; set; }

            /// <summary>
            /// The number of unbound assets.
            /// </summary>
            [NameInMap("UnBindEcsCount")]
            [Validation(Required=false)]
            public int? UnBindEcsCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The quota consumption statistics.
        /// </summary>
        [NameInMap("VersionSummary")]
        [Validation(Required=false)]
        public List<GetAuthSummaryResponseBodyVersionSummary> VersionSummary { get; set; }
        public class GetAuthSummaryResponseBodyVersionSummary : TeaModel {
            /// <summary>
            /// The type of the quota that is consumed. Valid values:
            /// 
            /// *   ASSET: quota of servers.
            /// *   CORE: quota of server cores.
            /// *   ASSET_AND_CORE: both.
            /// </summary>
            [NameInMap("AuthBindType")]
            [Validation(Required=false)]
            public string AuthBindType { get; set; }

            /// <summary>
            /// The index of the current edition. The smaller the value, the higher the edition. The index is used for sorting.
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// The total quota of server cores.
            /// 
            /// >  This parameter takes effect only if AuthBindType is set to CORE or ASSET_AND_CORE.
            /// </summary>
            [NameInMap("TotalCoreAuthCount")]
            [Validation(Required=false)]
            public int? TotalCoreAuthCount { get; set; }

            /// <summary>
            /// The total quota of servers in the current edition.
            /// 
            /// >  This parameter takes effect only if AuthBindType is set to ASSET or ASSET_AND_CORE.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// The total quota of servers.
            /// 
            /// >  This parameter takes effect only if AuthBindType is set to ASSET or ASSET_AND_CORE.
            /// </summary>
            [NameInMap("TotalEcsAuthCount")]
            [Validation(Required=false)]
            public int? TotalEcsAuthCount { get; set; }

            /// <summary>
            /// The remaining quota of servers.
            /// 
            /// >  This parameter takes effect only if AuthBindType is set to ASSET or ASSET_AND_CORE.
            /// </summary>
            [NameInMap("UnUsedCount")]
            [Validation(Required=false)]
            public int? UnUsedCount { get; set; }

            /// <summary>
            /// The remaining quota of server cores.
            /// 
            /// >  This parameter takes effect only if AuthBindType is set to CORE or ASSET_AND_CORE.
            /// </summary>
            [NameInMap("UnusedCoreAuthCount")]
            [Validation(Required=false)]
            public int? UnusedCoreAuthCount { get; set; }

            /// <summary>
            /// The remaining quota of servers.
            /// 
            /// >  This parameter takes effect only if AuthBindType is set to ASSET or ASSET_AND_CORE.
            /// </summary>
            [NameInMap("UnusedEcsAuthCount")]
            [Validation(Required=false)]
            public int? UnusedEcsAuthCount { get; set; }

            /// <summary>
            /// The consumed quota of server cores.
            /// 
            /// >  This parameter takes effect only if AuthBindType is set to CORE or ASSET_AND_CORE.
            /// </summary>
            [NameInMap("UsedCoreCount")]
            [Validation(Required=false)]
            public int? UsedCoreCount { get; set; }

            /// <summary>
            /// The used quota of servers.
            /// 
            /// >  This parameter takes effect only if AuthBindType is set to ASSET or ASSET_AND_CORE.
            /// </summary>
            [NameInMap("UsedEcsCount")]
            [Validation(Required=false)]
            public int? UsedEcsCount { get; set; }

            /// <summary>
            /// The edition of purchased Security Center. Valid values:
            /// 
            /// *   **1**: Basic edition
            /// *   **3**: Enterprise edition
            /// *   **5**: Advanced edition
            /// *   **6**: Anti-virus edition
            /// *   **7**: Ultimate edition
            /// *   **8**: Multi-edition
            /// *   **10**: Value-added Plan edition
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

    }

}
