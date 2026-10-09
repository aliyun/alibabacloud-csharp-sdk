// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAuthSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>Specifies whether pay-as-you-go authorization is allowed when purchasing. Valid values:</para>
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
        /// <para>Specifies whether immediately unbinding all bound assets is allowed. Valid values:</para>
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
        /// <para>Specifies whether newly added assets are automatically bound when you activate the subscription-based host and container security service. Valid values:</para>
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
        /// <para>Specifies whether cluster nodes require machine version verification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not required.</description></item>
        /// <item><description><b>1</b>: Required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ClusterNodeCheck")]
        [Validation(Required=false)]
        public int? ClusterNodeCheck { get; set; }

        /// <summary>
        /// <para>Specifies whether all assets are authorized by default. Valid values:</para>
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
        /// <para>The EDR authorization summary information.</para>
        /// </summary>
        [NameInMap("EdrSummary")]
        [Validation(Required=false)]
        public GetAuthSummaryResponseBodyEdrSummary EdrSummary { get; set; }
        public class GetAuthSummaryResponseBodyEdrSummary : TeaModel {
            /// <summary>
            /// <para>The number of EDR authorizations that have been bound.</para>
            /// </summary>
            [NameInMap("BoundCount")]
            [Validation(Required=false)]
            public string BoundCount { get; set; }

            /// <summary>
            /// <para>The automatic binding status of hybrid-paid EDR instances.</para>
            /// </summary>
            [NameInMap("HybridPaidAutoBind")]
            [Validation(Required=false)]
            public string HybridPaidAutoBind { get; set; }

            /// <summary>
            /// <para>The automatic binding status of pay-as-you-go EDR instances.</para>
            /// </summary>
            [NameInMap("PostPaidAutoBind")]
            [Validation(Required=false)]
            public string PostPaidAutoBind { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether a pre-binding asset configuration exists. Pre-binding refers to the asset binding configuration selected in advance at the time of purchase. Valid values:</para>
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
        /// <para>The highest edition of Security Center that you have purchased. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition.</description></item>
        /// <item><description><b>3</b>: Enterprise Edition.</description></item>
        /// <item><description><b>5</b>: Advanced Edition.</description></item>
        /// <item><description><b>6</b>: Anti-virus Edition.</description></item>
        /// <item><description><b>7</b>: Ultimate Edition.</description></item>
        /// <item><description><b>10</b>: Value-added services only.<remarks>
        /// <para>If you purchased a single edition, this value indicates that edition. If you purchased multiple editions, this value indicates the highest edition among all sub-editions.</para>
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
        /// <para>The binding effective status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NORMAL</b>: valid.</description></item>
        /// <item><description><b>INVALID_NODE_VERSION</b>: invalid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>INVALID_NODE_VERSION</para>
        /// </summary>
        [NameInMap("InvalidBindStatus")]
        [Validation(Required=false)]
        public string InvalidBindStatus { get; set; }

        /// <summary>
        /// <para>Specifies whether multiple versions exist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Does not exist.</description></item>
        /// <item><description><b>1</b>: Exists.</description></item>
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
            /// <para>The number of cores of assets that are bound to authorizations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("BindCoreCount")]
            [Validation(Required=false)]
            public int? BindCoreCount { get; set; }

            /// <summary>
            /// <para>The number of assets that are bound to authorizations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("BindEcsCount")]
            [Validation(Required=false)]
            public int? BindEcsCount { get; set; }

            /// <summary>
            /// <para>The number of cores of assets that are bound to pay-as-you-go authorizations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PostPaidBindCoreCount")]
            [Validation(Required=false)]
            public int? PostPaidBindCoreCount { get; set; }

            /// <summary>
            /// <para>The number of assets that are bound to pay-as-you-go authorizations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PostPaidBindEcsCount")]
            [Validation(Required=false)]
            public int? PostPaidBindEcsCount { get; set; }

            /// <summary>
            /// <para>The number of cores of assets that have security risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RiskCoreCount")]
            [Validation(Required=false)]
            public int? RiskCoreCount { get; set; }

            /// <summary>
            /// <para>The number of assets that have security risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RiskEcsCount")]
            [Validation(Required=false)]
            public int? RiskEcsCount { get; set; }

            /// <summary>
            /// <para>The total number of cores of all assets.</para>
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
            /// <para>The number of cores of assets that are not bound to authorizations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UnBindCoreCount")]
            [Validation(Required=false)]
            public int? UnBindCoreCount { get; set; }

            /// <summary>
            /// <para>The number of assets that are not bound to authorizations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UnBindEcsCount")]
            [Validation(Required=false)]
            public int? UnBindEcsCount { get; set; }

        }

        /// <summary>
        /// <para>The highest protection edition among all hosts bound to the pay-as-you-go host and container security service. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition. </description></item>
        /// <item><description><b>3</b>: Enterprise Edition.</description></item>
        /// <item><description><b>5</b>: Advanced Edition.</description></item>
        /// <item><description><b>6</b>: Anti-virus Edition.    </description></item>
        /// <item><description><b>7</b>: Ultimate Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PostPaidHighestVersion")]
        [Validation(Required=false)]
        public string PostPaidHighestVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether newly added hosts are automatically bound to the pay-as-you-go host and container security service. Valid values:</para>
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
        /// <para>The edition to which newly added assets are automatically bound under the pay-as-you-go host and container security service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition. </description></item>
        /// <item><description><b>3</b>: Enterprise Edition.</description></item>
        /// <item><description><b>5</b>: Advanced Edition.</description></item>
        /// <item><description><b>6</b>: Anti-virus Edition.    </description></item>
        /// <item><description><b>7</b>: Ultimate Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("PostPaidHostAutoBindVersion")]
        [Validation(Required=false)]
        public string PostPaidHostAutoBindVersion { get; set; }

        /// <summary>
        /// <para>The service authorization statistics for the pay-as-you-go host and container security service.</para>
        /// </summary>
        [NameInMap("PostPaidVersionSummary")]
        [Validation(Required=false)]
        public List<GetAuthSummaryResponseBodyPostPaidVersionSummary> PostPaidVersionSummary { get; set; }
        public class GetAuthSummaryResponseBodyPostPaidVersionSummary : TeaModel {
            /// <summary>
            /// <para>The type of authorization consumed when binding. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ASSET</b>: consumes authorization units.</description></item>
            /// <item><description><b>CORE</b>: consumes authorization cores.</description></item>
            /// <item><description><b>ASSET_AND_CORE</b>: consumes both authorization units and authorization cores.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ASSET</para>
            /// </summary>
            [NameInMap("AuthBindType")]
            [Validation(Required=false)]
            public string AuthBindType { get; set; }

            /// <summary>
            /// <para>The number of free authorization cores.</para>
            /// </summary>
            [NameInMap("FreeCoreCount")]
            [Validation(Required=false)]
            public int? FreeCoreCount { get; set; }

            /// <summary>
            /// <para>The number of free authorization units.</para>
            /// </summary>
            [NameInMap("FreeEcsCount")]
            [Validation(Required=false)]
            public int? FreeEcsCount { get; set; }

            /// <summary>
            /// <para>The type of free quota.</para>
            /// </summary>
            [NameInMap("FreeType")]
            [Validation(Required=false)]
            public string FreeType { get; set; }

            /// <summary>
            /// <para>The index of the current edition. A higher value indicates a higher edition. This field is used for sorting. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Free Edition. </description></item>
            /// <item><description><b>2</b>: Anti-virus Edition.    </description></item>
            /// <item><description><b>3</b>: Advanced Edition.</description></item>
            /// <item><description><b>4</b>: Enterprise Edition.</description></item>
            /// <item><description><b>5</b>: Ultimate Edition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// <para>The number of authorization cores that have been used.</para>
            /// <remarks>
            /// <para>This parameter is valid when AuthBindType is set to CORE or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UsedCoreCount")]
            [Validation(Required=false)]
            public long? UsedCoreCount { get; set; }

            /// <summary>
            /// <para>The number of authorization units that have been used.</para>
            /// <remarks>
            /// <para>This parameter is valid when AuthBindType is set to ASSET or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UsedEcsCount")]
            [Validation(Required=false)]
            public long? UsedEcsCount { get; set; }

            /// <summary>
            /// <para>The pay-as-you-go edition bound to the host asset. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Free Edition. </description></item>
            /// <item><description><b>3</b>: Enterprise Edition.</description></item>
            /// <item><description><b>5</b>: Advanced Edition.</description></item>
            /// <item><description><b>6</b>: Anti-virus Edition.    </description></item>
            /// <item><description><b>7</b>: Ultimate Edition.</description></item>
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
        /// <para>The ID of the request. The ID is a unique identifier generated by Alibaba Cloud for the request. You can use the ID to troubleshoot and locate issues.</para>
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
            /// <para>The type of authorization consumed when binding. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ASSET: consumes authorization units.</description></item>
            /// <item><description>CORE: consumes authorization cores.</description></item>
            /// <item><description>ASSET_AND_CORE: consumes both authorization units and authorization cores.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ASSET</para>
            /// </summary>
            [NameInMap("AuthBindType")]
            [Validation(Required=false)]
            public string AuthBindType { get; set; }

            /// <summary>
            /// <para>The index of the current edition. A higher value indicates a higher edition. This field is used for sorting. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Free Edition. </description></item>
            /// <item><description><b>2</b>: Anti-virus Edition.    </description></item>
            /// <item><description><b>3</b>: Advanced Edition.</description></item>
            /// <item><description><b>4</b>: Enterprise Edition.</description></item>
            /// <item><description><b>5</b>: Ultimate Edition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// <para>The total number of authorization cores.</para>
            /// <remarks>
            /// <para>This parameter is valid when AuthBindType is set to CORE or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCoreAuthCount")]
            [Validation(Required=false)]
            public int? TotalCoreAuthCount { get; set; }

            /// <summary>
            /// <para>The total number of authorization units for the current edition.</para>
            /// <remarks>
            /// <para>This parameter is valid when AuthBindType is set to ASSET or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The total number of authorization units.</para>
            /// <remarks>
            /// <para>This parameter is valid when AuthBindType is set to ASSET or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalEcsAuthCount")]
            [Validation(Required=false)]
            public int? TotalEcsAuthCount { get; set; }

            /// <summary>
            /// <para>The number of unused authorization units.</para>
            /// <remarks>
            /// <para>This parameter is valid when AuthBindType is set to ASSET or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UnUsedCount")]
            [Validation(Required=false)]
            public int? UnUsedCount { get; set; }

            /// <summary>
            /// <para>The number of unused authorization cores.</para>
            /// <remarks>
            /// <para>This parameter is valid when AuthBindType is set to CORE or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UnusedCoreAuthCount")]
            [Validation(Required=false)]
            public int? UnusedCoreAuthCount { get; set; }

            /// <summary>
            /// <para>The number of unused authorization units.</para>
            /// <remarks>
            /// <para>This parameter is valid when AuthBindType is set to ASSET or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UnusedEcsAuthCount")]
            [Validation(Required=false)]
            public int? UnusedEcsAuthCount { get; set; }

            /// <summary>
            /// <para>The number of authorization cores that have been used.</para>
            /// <remarks>
            /// <para>This parameter is valid when AuthBindType is set to CORE or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UsedCoreCount")]
            [Validation(Required=false)]
            public int? UsedCoreCount { get; set; }

            /// <summary>
            /// <para>The number of authorization units that have been used.</para>
            /// <remarks>
            /// <para>This parameter is valid when AuthBindType is set to ASSET or ASSET_AND_CORE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UsedEcsCount")]
            [Validation(Required=false)]
            public int? UsedEcsCount { get; set; }

            /// <summary>
            /// <para>The edition of Security Center that you have purchased. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Free Edition. </description></item>
            /// <item><description><b>3</b>: Enterprise Edition.</description></item>
            /// <item><description><b>5</b>: Advanced Edition.</description></item>
            /// <item><description><b>6</b>: Anti-virus Edition.    </description></item>
            /// <item><description><b>7</b>: Ultimate Edition.   </description></item>
            /// <item><description><b>8</b>: Multiple editions.   </description></item>
            /// <item><description><b>10</b>: Value-added services only.</description></item>
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
