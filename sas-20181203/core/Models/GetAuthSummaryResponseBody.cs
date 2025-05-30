// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAuthSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether you can purchase protection quota on demand when you purchase Security Center. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: no</description></item>
        /// <item><description><b>1</b>: yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AllowPartialBuy")]
        [Validation(Required=false)]
        public int? AllowPartialBuy { get; set; }

        /// <summary>
        /// <para>Indicates whether you can purchase protection quota on demand after an upgrade. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: no</description></item>
        /// <item><description><b>1</b>: yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AllowUpgradePartialBuy")]
        [Validation(Required=false)]
        public int? AllowUpgradePartialBuy { get; set; }

        /// <summary>
        /// <para>Indicates whether all bound assets can be immediately unbound. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: no</description></item>
        /// <item><description><b>1</b>: yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AllowUserUnbind")]
        [Validation(Required=false)]
        public int? AllowUserUnbind { get; set; }

        /// <summary>
        /// <para>Indicates whether automatic binding is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disabled</description></item>
        /// <item><description><b>1</b>: enabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoBind")]
        [Validation(Required=false)]
        public int? AutoBind { get; set; }

        /// <summary>
        /// <para>Indicates whether the protection quota is supported for all assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: no</description></item>
        /// <item><description><b>1</b>: yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DefaultAuthToAll")]
        [Validation(Required=false)]
        public int? DefaultAuthToAll { get; set; }

        /// <summary>
        /// <para>Indicates whether pre-bound assets exist. If you select assets to bind when you purchase Security Center, pre-bound assets exist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: no</description></item>
        /// <item><description><b>1</b>: yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HasPreBindSetting")]
        [Validation(Required=false)]
        public bool? HasPreBindSetting { get; set; }

        /// <summary>
        /// <para>The most advanced edition that is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Basic edition</description></item>
        /// <item><description><b>3</b>: Enterprise edition</description></item>
        /// <item><description><b>5</b>: Advanced edition</description></item>
        /// <item><description><b>6</b>: Anti-virus edition</description></item>
        /// <item><description><b>7</b>: Ultimate edition</description></item>
        /// <item><description><b>10</b>: Value-added Plan edition</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you purchase Security Center Multi-edition, the value indicates the most advanced edition that is used. Otherwise, the value indicates the specific edition that is purchased.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HighestVersion")]
        [Validation(Required=false)]
        public int? HighestVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether Security Center Multi-edition is purchased. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: no</description></item>
        /// <item><description><b>1</b>: yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsMultiVersion")]
        [Validation(Required=false)]
        public int? IsMultiVersion { get; set; }

        /// <summary>
        /// <para>The statistics of the protection quota for assets.</para>
        /// </summary>
        [NameInMap("Machine")]
        [Validation(Required=false)]
        public GetAuthSummaryResponseBodyMachine Machine { get; set; }
        public class GetAuthSummaryResponseBodyMachine : TeaModel {
            /// <summary>
            /// <para>The number of cores of the assets that are bound to Security Center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("BindCoreCount")]
            [Validation(Required=false)]
            public int? BindCoreCount { get; set; }

            /// <summary>
            /// <para>The number of the assets that are bound to Security Center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("BindEcsCount")]
            [Validation(Required=false)]
            public int? BindEcsCount { get; set; }

            /// <summary>
            /// <para>Bind the number of cores for postpaid authorization assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PostPaidBindCoreCount")]
            [Validation(Required=false)]
            public int? PostPaidBindCoreCount { get; set; }

            /// <summary>
            /// <para>The number of assets bound to the postpaid authorization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PostPaidBindEcsCount")]
            [Validation(Required=false)]
            public int? PostPaidBindEcsCount { get; set; }

            /// <summary>
            /// <para>The number of cores of the assets that are at risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RiskCoreCount")]
            [Validation(Required=false)]
            public int? RiskCoreCount { get; set; }

            /// <summary>
            /// <para>The number of the assets that are at risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RiskEcsCount")]
            [Validation(Required=false)]
            public int? RiskEcsCount { get; set; }

            /// <summary>
            /// <para>The total number of asset cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCoreCount")]
            [Validation(Required=false)]
            public int? TotalCoreCount { get; set; }

            /// <summary>
            /// <para>The total number of assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalEcsCount")]
            [Validation(Required=false)]
            public int? TotalEcsCount { get; set; }

            /// <summary>
            /// <para>The number of cores of unbound assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UnBindCoreCount")]
            [Validation(Required=false)]
            public int? UnBindCoreCount { get; set; }

            /// <summary>
            /// <para>The number of unbound assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UnBindEcsCount")]
            [Validation(Required=false)]
            public int? UnBindEcsCount { get; set; }

        }

        /// <summary>
        /// <para>Activate the pay-as-you-go service protection version for hosts and container security, which is the highest protection version among all bound hosts. Values:   - <b>1</b>: Free Edition  - <b>3</b>: Enterprise Edition - <b>5</b>: Advanced Edition - <b>6</b>: Antivirus Edition     - <b>7</b>: Flagship Edition</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PostPaidHighestVersion")]
        [Validation(Required=false)]
        public string PostPaidHighestVersion { get; set; }

        /// <summary>
        /// <para>The pay-as-you-go service for host and container security adds an automatic binding identifier for new hosts, with values: - <b>0</b>: Off - <b>1</b>: On</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PostPaidHostAutoBind")]
        [Validation(Required=false)]
        public string PostPaidHostAutoBind { get; set; }

        /// <summary>
        /// <para>The version for the pay-as-you-go service of host and container security to automatically bind new assets, with values: - <b>1</b>: Free Edition - <b>3</b>: Enterprise Edition - <b>5</b>: Advanced Edition - <b>6</b>: Antivirus Edition - <b>7</b>: Flagship Edition</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PostPaidHostAutoBindVersion")]
        [Validation(Required=false)]
        public string PostPaidHostAutoBindVersion { get; set; }

        /// <summary>
        /// <para>Statistics on pay-as-you-go service authorization for host and container security.</para>
        /// </summary>
        [NameInMap("PostPaidVersionSummary")]
        [Validation(Required=false)]
        public List<GetAuthSummaryResponseBodyPostPaidVersionSummary> PostPaidVersionSummary { get; set; }
        public class GetAuthSummaryResponseBodyPostPaidVersionSummary : TeaModel {
            /// <summary>
            /// <para>The type of authorization consumed during binding, with values: - <b>ASSET</b>: Consumes the number of authorized devices - <b>CORE</b>: Consumes the number of authorized cores - <b>ASSET_AND_CORE</b>: Consumes both the number of authorized devices and cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ASSET</para>
            /// </summary>
            [NameInMap("AuthBindType")]
            [Validation(Required=false)]
            public string AuthBindType { get; set; }

            /// <summary>
            /// <para>Current version index, the higher the number, the newer the version, used for sorting. Values: - <b>1</b>: Free Edition - <b>2</b>: Anti-virus Edition - <b>3</b>: Advanced Edition - <b>4</b>: Enterprise Edition - <b>5</b>: Flagship Edition</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// <para>Number of authorized cores used. &gt; This parameter is valid when AuthBindType is set to CORE or ASSET_AND_CORE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UsedCoreCount")]
            [Validation(Required=false)]
            public long? UsedCoreCount { get; set; }

            /// <summary>
            /// <para>Number of authorized devices used. &gt; This parameter is valid when AuthBindType is ASSET or ASSET_AND_CORE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UsedEcsCount")]
            [Validation(Required=false)]
            public long? UsedEcsCount { get; set; }

            /// <summary>
            /// <para>Bound host assets with postpaid versions, values:   - <b>1</b>: Free version  - <b>3</b>: Enterprise version - <b>5</b>: Advanced version - <b>6</b>: Anti-virus version     - <b>7</b>: Flagship version</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B48AB3C-***-B9270EF46038</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The quota consumption statistics.</para>
        /// </summary>
        [NameInMap("VersionSummary")]
        [Validation(Required=false)]
        public List<GetAuthSummaryResponseBodyVersionSummary> VersionSummary { get; set; }
        public class GetAuthSummaryResponseBodyVersionSummary : TeaModel {
            /// <summary>
            /// <para>The type of the quota that is consumed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ASSET: quota of servers.</description></item>
            /// <item><description>CORE: quota of server cores.</description></item>
            /// <item><description>ASSET_AND_CORE: both.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ASSET</para>
            /// </summary>
            [NameInMap("AuthBindType")]
            [Validation(Required=false)]
            public string AuthBindType { get; set; }

            /// <summary>
            /// <para>The index of the current edition. The smaller the value, the higher the edition. The index is used for sorting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// <para>The total quota of server cores.</para>
            /// <remarks>
            /// <para> This parameter takes effect only if AuthBindType is set to CORE or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCoreAuthCount")]
            [Validation(Required=false)]
            public int? TotalCoreAuthCount { get; set; }

            /// <summary>
            /// <para>The total quota of servers in the current edition.</para>
            /// <remarks>
            /// <para> This parameter takes effect only if AuthBindType is set to ASSET or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The total quota of servers.</para>
            /// <remarks>
            /// <para> This parameter takes effect only if AuthBindType is set to ASSET or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalEcsAuthCount")]
            [Validation(Required=false)]
            public int? TotalEcsAuthCount { get; set; }

            /// <summary>
            /// <para>The remaining quota of servers.</para>
            /// <remarks>
            /// <para> This parameter takes effect only if AuthBindType is set to ASSET or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UnUsedCount")]
            [Validation(Required=false)]
            public int? UnUsedCount { get; set; }

            /// <summary>
            /// <para>The remaining quota of server cores.</para>
            /// <remarks>
            /// <para> This parameter takes effect only if AuthBindType is set to CORE or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UnusedCoreAuthCount")]
            [Validation(Required=false)]
            public int? UnusedCoreAuthCount { get; set; }

            /// <summary>
            /// <para>The remaining quota of servers.</para>
            /// <remarks>
            /// <para> This parameter takes effect only if AuthBindType is set to ASSET or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UnusedEcsAuthCount")]
            [Validation(Required=false)]
            public int? UnusedEcsAuthCount { get; set; }

            /// <summary>
            /// <para>The consumed quota of server cores.</para>
            /// <remarks>
            /// <para> This parameter takes effect only if AuthBindType is set to CORE or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UsedCoreCount")]
            [Validation(Required=false)]
            public int? UsedCoreCount { get; set; }

            /// <summary>
            /// <para>The used quota of servers.</para>
            /// <remarks>
            /// <para> This parameter takes effect only if AuthBindType is set to ASSET or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UsedEcsCount")]
            [Validation(Required=false)]
            public int? UsedEcsCount { get; set; }

            /// <summary>
            /// <para>The edition of purchased Security Center. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Basic edition</description></item>
            /// <item><description><b>3</b>: Enterprise edition</description></item>
            /// <item><description><b>5</b>: Advanced edition</description></item>
            /// <item><description><b>6</b>: Anti-virus edition</description></item>
            /// <item><description><b>7</b>: Ultimate edition</description></item>
            /// <item><description><b>8</b>: Multi-edition</description></item>
            /// <item><description><b>10</b>: Value-added Plan edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

    }

}
