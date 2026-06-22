// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAuthSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether on-demand authorization purchase is allowed during initial purchase. Valid values:</para>
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
        /// <para>Indicates whether upgrading to on-demand authorization purchase is allowed during an upgrade. Valid values:</para>
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
        /// <para>Indicates whether you can immediately unbind all bound assets. Valid values:</para>
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
        /// <para>Indicates whether new subscription assets are automatically bound when the host and container security subscription service is activated. Valid values:</para>
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
        /// <para>Indicates whether the cluster node requires machine version verification. Valid values:</para>
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
        /// <para>Indicates whether all assets are authorized by default. Valid values:</para>
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
        /// <para>Indicates whether a pre-bindingasset configuration exists. Pre-binding refers to the asset binding configuration that is selected in advance during purchase. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No.</description></item>
        /// <item><description><b>1</b>: Yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HasPreBindSetting")]
        [Validation(Required=false)]
        public bool? HasPreBindSetting { get; set; }

        /// <summary>
        /// <para>The highest edition of Security Center that is purchased. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition.</description></item>
        /// <item><description><b>3</b>: Enterprise Edition.</description></item>
        /// <item><description><b>5</b>: Premium Edition.</description></item>
        /// <item><description><b>6</b>: Anti-virus Edition.</description></item>
        /// <item><description><b>7</b>: Ultimate Edition.</description></item>
        /// <item><description><b>10</b>: Only value-added services are purchased.<remarks>
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
        /// <para>The binding validity status. Valid values:</para>
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
        /// <para>Indicates whether multiple versions exist. Valid values:</para>
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
            /// <para>The number of cores of assets that are bound with authorization.</para>
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
            /// <para>The number of cores of assets that are bound with pay-as-you-go authorization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PostPaidBindCoreCount")]
            [Validation(Required=false)]
            public int? PostPaidBindCoreCount { get; set; }

            /// <summary>
            /// <para>The number of assets that are bound with pay-as-you-go authorization.</para>
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
        /// <para>The protection edition of the host and container security pay-as-you-go service. This value indicates the highest protection edition among all bound hosts. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition. </description></item>
        /// <item><description><b>3</b>: Enterprise Edition.</description></item>
        /// <item><description><b>5</b>: Premium Edition.</description></item>
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
        /// <para>Indicates whether new hosts are automatically bound for the host and container security pay-as-you-go service. Valid values:</para>
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
        /// <para>The edition to which new assets are automatically bound for the host and container security pay-as-you-go service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition. </description></item>
        /// <item><description><b>3</b>: Enterprise Edition.</description></item>
        /// <item><description><b>5</b>: Premium Edition.</description></item>
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
        /// <para>The service authorization statistics for the host and container security pay-as-you-go service.</para>
        /// </summary>
        [NameInMap("PostPaidVersionSummary")]
        [Validation(Required=false)]
        public List<GetAuthSummaryResponseBodyPostPaidVersionSummary> PostPaidVersionSummary { get; set; }
        public class GetAuthSummaryResponseBodyPostPaidVersionSummary : TeaModel {
            /// <summary>
            /// <para>The type of authorization consumed during binding. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ASSET</b>: consumes authorized asset count.</description></item>
            /// <item><description><b>CORE</b>: consumes authorized core count.</description></item>
            /// <item><description><b>ASSET_AND_CORE</b>: consumes both authorized asset count and authorized core count.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ASSET</para>
            /// </summary>
            [NameInMap("AuthBindType")]
            [Validation(Required=false)]
            public string AuthBindType { get; set; }

            /// <summary>
            /// <para>The index of the current edition. A larger value indicates a higher edition. This parameter is used for sorting. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Free Edition. </description></item>
            /// <item><description><b>2</b>: Anti-virus Edition.    </description></item>
            /// <item><description><b>3</b>: Premium Edition.</description></item>
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
            /// <para>The number of authorized cores that are used.</para>
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
            /// <para>The number of authorized assets that are used.</para>
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
            /// <para>The pay-as-you-go edition that is bound to host assets. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Free Edition. </description></item>
            /// <item><description><b>3</b>: Enterprise Edition.</description></item>
            /// <item><description><b>5</b>: Premium Edition.</description></item>
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
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use the ID to troubleshoot issues.</para>
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
            /// <item><description>ASSET: consumes authorized asset count.</description></item>
            /// <item><description>CORE: consumes authorized core count.</description></item>
            /// <item><description>ASSET_AND_CORE: consumes both authorized asset count and authorized core count.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ASSET</para>
            /// </summary>
            [NameInMap("AuthBindType")]
            [Validation(Required=false)]
            public string AuthBindType { get; set; }

            /// <summary>
            /// <para>The index of the current edition. A larger value indicates a higher edition. This parameter is used for sorting. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Free Edition. </description></item>
            /// <item><description><b>2</b>: Anti-virus Edition.    </description></item>
            /// <item><description><b>3</b>: Premium Edition.</description></item>
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
            /// <para>The number of authorized cores that are used.</para>
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
            /// <para>The number of authorized assets that are used.</para>
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
            /// <item><description><b>1</b>: Free Edition. </description></item>
            /// <item><description><b>3</b>: Enterprise Edition.</description></item>
            /// <item><description><b>5</b>: Premium Edition.</description></item>
            /// <item><description><b>6</b>: Anti-virus Edition.    </description></item>
            /// <item><description><b>7</b>: Ultimate Edition.   </description></item>
            /// <item><description><b>8</b>: Multi-version.   </description></item>
            /// <item><description><b>10</b>: Only value-added services are purchased.</description></item>
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
