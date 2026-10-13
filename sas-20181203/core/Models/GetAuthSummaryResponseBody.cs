// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAuthSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>Specifies whether pay-as-you-go authorization is allowed for new purchases. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not allowed.</description></item>
        /// <item><description><b>1</b>: Allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AllowPartialBuy")]
        [Validation(Required=false)]
        public int? AllowPartialBuy { get; set; }

        /// <summary>
        /// <para>Specifies whether upgrading to pay-as-you-go authorization is allowed during an upgrade. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not allowed.</description></item>
        /// <item><description><b>1</b>: Allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AllowUpgradePartialBuy")]
        [Validation(Required=false)]
        public int? AllowUpgradePartialBuy { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow immediate unbinding of all bound assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No.</description></item>
        /// <item><description><b>1</b>: Yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AllowUserUnbind")]
        [Validation(Required=false)]
        public int? AllowUserUnbind { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically bind newly added assets when the subscription service for host and container security is activated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoBind")]
        [Validation(Required=false)]
        public int? AutoBind { get; set; }

        /// <summary>
        /// <para>Specifies whether to verify the machine version for cluster nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No.</description></item>
        /// <item><description><b>1</b>: Yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ClusterNodeCheck")]
        [Validation(Required=false)]
        public int? ClusterNodeCheck { get; set; }

        /// <summary>
        /// <para>Specifies whether default authorization is applied to all assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No.</description></item>
        /// <item><description><b>1</b>: Yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DefaultAuthToAll")]
        [Validation(Required=false)]
        public int? DefaultAuthToAll { get; set; }

        /// <summary>
        /// <para>The EDR authorization summary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;BoundCount&quot;:&quot;0&quot;,&quot;PostPaidAutoBind&quot;:&quot;0&quot;,&quot;HybridPaidAutoBind&quot;:&quot;0&quot;}</para>
        /// </summary>
        [NameInMap("EdrSummary")]
        [Validation(Required=false)]
        public GetAuthSummaryResponseBodyEdrSummary EdrSummary { get; set; }
        public class GetAuthSummaryResponseBodyEdrSummary : TeaModel {
            /// <summary>
            /// <para>The number of bound EDR authorizations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BoundCount")]
            [Validation(Required=false)]
            public string BoundCount { get; set; }

            /// <summary>
            /// <para>The automatic binding status of hybrid billing EDR instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HybridPaidAutoBind")]
            [Validation(Required=false)]
            public string HybridPaidAutoBind { get; set; }

            /// <summary>
            /// <para>The automatic binding status of pay-as-you-go EDR instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PostPaidAutoBind")]
            [Validation(Required=false)]
            public string PostPaidAutoBind { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether pre-bound asset configurations exist. Pre-binding refers to the asset binding configurations selected in advance during purchase. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Does not exist.</description></item>
        /// <item><description><b>1</b>: Exists.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HasPreBindSetting")]
        [Validation(Required=false)]
        public bool? HasPreBindSetting { get; set; }

        /// <summary>
        /// <para>The highest purchased edition of Security Center. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition</description></item>
        /// <item><description><b>3</b>: Enterprise Edition</description></item>
        /// <item><description><b>5</b>: Advanced Edition</description></item>
        /// <item><description><b>6</b>: Anti-virus Edition</description></item>
        /// <item><description><b>7</b>: Ultimate Edition</description></item>
        /// <item><description><b>10</b>: Value-added services only<remarks>
        /// <para>If a single edition is purchased, this value indicates the corresponding edition. If multiple editions are purchased, this value indicates the highest edition among the sub-editions.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HighestVersion")]
        [Validation(Required=false)]
        public int? HighestVersion { get; set; }

        /// <summary>
        /// <para>The effective status of the binding. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NORMAL</b>: Valid.</description></item>
        /// <item><description><b>INVALID_NODE_VERSION</b>: Invalid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>INVALID_NODE_VERSION</para>
        /// </summary>
        [NameInMap("InvalidBindStatus")]
        [Validation(Required=false)]
        public string InvalidBindStatus { get; set; }

        /// <summary>
        /// <para>Specifies whether multiple versions are used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No.</description></item>
        /// <item><description><b>1</b>: Yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsMultiVersion")]
        [Validation(Required=false)]
        public int? IsMultiVersion { get; set; }

        /// <summary>
        /// <para>The asset authorization statistics information.</para>
        /// </summary>
        [NameInMap("Machine")]
        [Validation(Required=false)]
        public GetAuthSummaryResponseBodyMachine Machine { get; set; }
        public class GetAuthSummaryResponseBodyMachine : TeaModel {
            /// <summary>
            /// <para>The number of cores for assets bound with authorization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("BindCoreCount")]
            [Validation(Required=false)]
            public int? BindCoreCount { get; set; }

            /// <summary>
            /// <para>The number of bound assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("BindEcsCount")]
            [Validation(Required=false)]
            public int? BindEcsCount { get; set; }

            /// <summary>
            /// <para>The number of cores for assets bound with pay-as-you-go authorization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PostPaidBindCoreCount")]
            [Validation(Required=false)]
            public int? PostPaidBindCoreCount { get; set; }

            /// <summary>
            /// <para>The number of assets bound with pay-as-you-go authorization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PostPaidBindEcsCount")]
            [Validation(Required=false)]
            public int? PostPaidBindEcsCount { get; set; }

            /// <summary>
            /// <para>The number of cores for assets with security risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RiskCoreCount")]
            [Validation(Required=false)]
            public int? RiskCoreCount { get; set; }

            /// <summary>
            /// <para>The number of assets with security risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RiskEcsCount")]
            [Validation(Required=false)]
            public int? RiskEcsCount { get; set; }

            /// <summary>
            /// <para>The total number of cores for all assets.</para>
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
            /// <para>The number of cores for unbound assets.</para>
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
        /// <para>The protection edition of the pay-as-you-go service for host and container security, which is the highest protection edition among all bound hosts. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition </description></item>
        /// <item><description><b>3</b>: Enterprise Edition</description></item>
        /// <item><description><b>5</b>: Advanced Edition</description></item>
        /// <item><description><b>6</b>: Anti-virus Edition    </description></item>
        /// <item><description><b>7</b>: Ultimate Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PostPaidHighestVersion")]
        [Validation(Required=false)]
        public string PostPaidHighestVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically bind newly added hosts for the pay-as-you-go service of host and container security. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PostPaidHostAutoBind")]
        [Validation(Required=false)]
        public string PostPaidHostAutoBind { get; set; }

        /// <summary>
        /// <para>The edition to which newly added assets are automatically bound for the pay-as-you-go service of host and container security. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition </description></item>
        /// <item><description><b>3</b>: Enterprise Edition</description></item>
        /// <item><description><b>5</b>: Advanced Edition</description></item>
        /// <item><description><b>6</b>: Anti-virus Edition    </description></item>
        /// <item><description><b>7</b>: Ultimate Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PostPaidHostAutoBindVersion")]
        [Validation(Required=false)]
        public string PostPaidHostAutoBindVersion { get; set; }

        /// <summary>
        /// <para>The service authorization statistics for the pay-as-you-go service of host and container security.</para>
        /// </summary>
        [NameInMap("PostPaidVersionSummary")]
        [Validation(Required=false)]
        public List<GetAuthSummaryResponseBodyPostPaidVersionSummary> PostPaidVersionSummary { get; set; }
        public class GetAuthSummaryResponseBodyPostPaidVersionSummary : TeaModel {
            /// <summary>
            /// <para>The type of authorization consumed during binding. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ASSET</b>: Consumes the number of authorized assets.</description></item>
            /// <item><description><b>CORE</b>: Consumes the number of authorized cores.</description></item>
            /// <item><description><b>ASSET_AND_CORE</b>: Consumes both the number of authorized assets and the number of authorized cores.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ASSET</para>
            /// </summary>
            [NameInMap("AuthBindType")]
            [Validation(Required=false)]
            public string AuthBindType { get; set; }

            /// <summary>
            /// <para>The number of free authorized cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FreeCoreCount")]
            [Validation(Required=false)]
            public int? FreeCoreCount { get; set; }

            /// <summary>
            /// <para>The number of free authorized assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FreeEcsCount")]
            [Validation(Required=false)]
            public int? FreeEcsCount { get; set; }

            /// <summary>
            /// <para>The category identifier of the free quota.</para>
            /// </summary>
            [NameInMap("FreeType")]
            [Validation(Required=false)]
            public string FreeType { get; set; }

            /// <summary>
            /// <para>The index of the current edition. A larger value indicates a higher edition, which is used for sorting. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Free Edition </description></item>
            /// <item><description><b>2</b>: Anti-virus Edition    </description></item>
            /// <item><description><b>3</b>: Advanced Edition</description></item>
            /// <item><description><b>4</b>: Enterprise Edition</description></item>
            /// <item><description><b>5</b>: Ultimate Edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// <para>The number of used authorized cores.</para>
            /// <remarks>
            /// <para>This parameter is valid only when AuthBindType is set to CORE or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UsedCoreCount")]
            [Validation(Required=false)]
            public long? UsedCoreCount { get; set; }

            /// <summary>
            /// <para>The number of used authorized assets.</para>
            /// <remarks>
            /// <para>This parameter is valid only when AuthBindType is set to ASSET or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UsedEcsCount")]
            [Validation(Required=false)]
            public long? UsedEcsCount { get; set; }

            /// <summary>
            /// <para>The pay-as-you-go edition bound to the host assets. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Free Edition </description></item>
            /// <item><description><b>3</b>: Enterprise Edition</description></item>
            /// <item><description><b>5</b>: Advanced Edition</description></item>
            /// <item><description><b>6</b>: Anti-virus Edition    </description></item>
            /// <item><description><b>7</b>: Ultimate Edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. This is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B48AB3C-***-B9270EF46038</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The authorization usage statistics information.</para>
        /// </summary>
        [NameInMap("VersionSummary")]
        [Validation(Required=false)]
        public List<GetAuthSummaryResponseBodyVersionSummary> VersionSummary { get; set; }
        public class GetAuthSummaryResponseBodyVersionSummary : TeaModel {
            /// <summary>
            /// <para>The type of authorization consumed during binding. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ASSET: Consumes the number of authorized assets.</description></item>
            /// <item><description>CORE: Consumes the number of authorized cores.</description></item>
            /// <item><description>ASSET_AND_CORE: Consumes both the number of authorized assets and the number of authorized cores.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ASSET</para>
            /// </summary>
            [NameInMap("AuthBindType")]
            [Validation(Required=false)]
            public string AuthBindType { get; set; }

            /// <summary>
            /// <para>The index of the current edition. A larger value indicates a higher edition, which is used for sorting. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Free Edition </description></item>
            /// <item><description><b>2</b>: Anti-virus Edition    </description></item>
            /// <item><description><b>3</b>: Advanced Edition</description></item>
            /// <item><description><b>4</b>: Enterprise Edition</description></item>
            /// <item><description><b>5</b>: Ultimate Edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// <para>The total number of authorized cores.</para>
            /// <remarks>
            /// <para>This parameter is valid only when AuthBindType is set to CORE or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCoreAuthCount")]
            [Validation(Required=false)]
            public int? TotalCoreAuthCount { get; set; }

            /// <summary>
            /// <para>The total number of authorized assets for the current edition.</para>
            /// <remarks>
            /// <para>This parameter is valid only when AuthBindType is set to ASSET or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The total number of authorized assets.</para>
            /// <remarks>
            /// <para>This parameter is valid only when AuthBindType is set to ASSET or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalEcsAuthCount")]
            [Validation(Required=false)]
            public int? TotalEcsAuthCount { get; set; }

            /// <summary>
            /// <para>The number of unused authorized assets.</para>
            /// <remarks>
            /// <para>This parameter is valid only when AuthBindType is set to ASSET or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UnUsedCount")]
            [Validation(Required=false)]
            public int? UnUsedCount { get; set; }

            /// <summary>
            /// <para>The number of unused authorized cores.</para>
            /// <remarks>
            /// <para>This parameter is valid only when AuthBindType is set to CORE or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UnusedCoreAuthCount")]
            [Validation(Required=false)]
            public int? UnusedCoreAuthCount { get; set; }

            /// <summary>
            /// <para>The number of unused authorized assets.</para>
            /// <remarks>
            /// <para>This parameter is valid only when AuthBindType is set to ASSET or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UnusedEcsAuthCount")]
            [Validation(Required=false)]
            public int? UnusedEcsAuthCount { get; set; }

            /// <summary>
            /// <para>The number of used authorized cores.</para>
            /// <remarks>
            /// <para>This parameter is valid only when AuthBindType is set to CORE or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UsedCoreCount")]
            [Validation(Required=false)]
            public int? UsedCoreCount { get; set; }

            /// <summary>
            /// <para>The number of used authorized assets.</para>
            /// <remarks>
            /// <para>This parameter is valid only when AuthBindType is set to ASSET or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UsedEcsCount")]
            [Validation(Required=false)]
            public int? UsedEcsCount { get; set; }

            /// <summary>
            /// <para>The purchased edition of Security Center. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Free Edition </description></item>
            /// <item><description><b>3</b>: Enterprise Edition</description></item>
            /// <item><description><b>5</b>: Advanced Edition</description></item>
            /// <item><description><b>6</b>: Anti-virus Edition    </description></item>
            /// <item><description><b>7</b>: Ultimate Edition   </description></item>
            /// <item><description><b>8</b>: Multiple editions   </description></item>
            /// <item><description><b>10</b>: Value-added services only</description></item>
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
