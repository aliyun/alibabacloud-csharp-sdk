// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallSummaryInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The remaining quota for VPC firewalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("AvailableVpcFirewallQuota")]
        [Validation(Required=false)]
        public int? AvailableVpcFirewallQuota { get; set; }

        /// <summary>
        /// <para>The number of VPCs connected using Cloud Enterprise Network (CEN) and Express Connect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("CenExpressConnectVpcCount")]
        [Validation(Required=false)]
        public int? CenExpressConnectVpcCount { get; set; }

        /// <summary>
        /// <para>The number of CEN VPCs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CenFirewallVpcCount")]
        [Validation(Required=false)]
        public int? CenFirewallVpcCount { get; set; }

        /// <summary>
        /// <para>The number of VPCs on the CEN transit router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("CenTrVpcCount")]
        [Validation(Required=false)]
        public int? CenTrVpcCount { get; set; }

        /// <summary>
        /// <para>The number of configured CEN firewalls that are disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ClosedCenFirewallCount")]
        [Validation(Required=false)]
        public int? ClosedCenFirewallCount { get; set; }

        /// <summary>
        /// <para>The number of configured Express Connect firewalls that are disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ClosedExpressConnectFirewallCount")]
        [Validation(Required=false)]
        public int? ClosedExpressConnectFirewallCount { get; set; }

        /// <summary>
        /// <para>The number of configured VPC firewalls that are disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ClosedVpcFirewallCount")]
        [Validation(Required=false)]
        public int? ClosedVpcFirewallCount { get; set; }

        /// <summary>
        /// <para>The number of configured CEN firewall instances of the Basic Edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ConfiguredCenFirewallCount")]
        [Validation(Required=false)]
        public int? ConfiguredCenFirewallCount { get; set; }

        /// <summary>
        /// <para>The number of regions where CEN firewalls are configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ConfiguredCenFirewallRegionCount")]
        [Validation(Required=false)]
        public int? ConfiguredCenFirewallRegionCount { get; set; }

        /// <summary>
        /// <para>The number of VPCs for which CEN firewalls are configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18</para>
        /// </summary>
        [NameInMap("ConfiguredCenFirewallVpcCount")]
        [Validation(Required=false)]
        public int? ConfiguredCenFirewallVpcCount { get; set; }

        /// <summary>
        /// <para>The number of configured CEN transit router firewall instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ConfiguredCenTrFirewallCount")]
        [Validation(Required=false)]
        public int? ConfiguredCenTrFirewallCount { get; set; }

        /// <summary>
        /// <para>The number of configured Express Connect circuits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ConfiguredExpressConnectFirewallCount")]
        [Validation(Required=false)]
        public int? ConfiguredExpressConnectFirewallCount { get; set; }

        /// <summary>
        /// <para>The number of VPCs for which Express Connect firewalls are configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ConfiguredExpressConnectVpcCount")]
        [Validation(Required=false)]
        public int? ConfiguredExpressConnectVpcCount { get; set; }

        /// <summary>
        /// <para>The number of configured VPC firewalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ConfiguredVpcFirewallCount")]
        [Validation(Required=false)]
        public int? ConfiguredVpcFirewallCount { get; set; }

        /// <summary>
        /// <para>The number of VPCs for which VPC firewalls are configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ConfiguredVpcFirewallVpcCount")]
        [Validation(Required=false)]
        public int? ConfiguredVpcFirewallVpcCount { get; set; }

        /// <summary>
        /// <para>The number of Express Connect VPCs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ExpressConnectVpcCount")]
        [Validation(Required=false)]
        public int? ExpressConnectVpcCount { get; set; }

        /// <summary>
        /// <para>The number of CEN firewalls that are not configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("NotConfiguredCenFirewallCount")]
        [Validation(Required=false)]
        public int? NotConfiguredCenFirewallCount { get; set; }

        /// <summary>
        /// <para>The number of CEN transit router firewall instances that are not configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("NotConfiguredCenTrFirewallCount")]
        [Validation(Required=false)]
        public int? NotConfiguredCenTrFirewallCount { get; set; }

        /// <summary>
        /// <para>The number of Express Connect firewalls that are not configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("NotConfiguredExpressConnectFirewallCount")]
        [Validation(Required=false)]
        public int? NotConfiguredExpressConnectFirewallCount { get; set; }

        /// <summary>
        /// <para>The number of VPC firewalls that are not configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("NotConfiguredVpcFirewallCount")]
        [Validation(Required=false)]
        public int? NotConfiguredVpcFirewallCount { get; set; }

        /// <summary>
        /// <para>The number of VPCs that are connected using CEN and Express Connect and have the firewall enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("OpenedCenExpressConnectVpcCount")]
        [Validation(Required=false)]
        public int? OpenedCenExpressConnectVpcCount { get; set; }

        /// <summary>
        /// <para>The number of enabled CEN firewalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("OpenedCenFirewallCount")]
        [Validation(Required=false)]
        public int? OpenedCenFirewallCount { get; set; }

        /// <summary>
        /// <para>The number of VPCs protected by CEN firewalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OpenedCenFirewallVpcCount")]
        [Validation(Required=false)]
        public int? OpenedCenFirewallVpcCount { get; set; }

        /// <summary>
        /// <para>The number of VPCs protected by the CEN transit router firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("OpenedCenTrFirewallVpcCount")]
        [Validation(Required=false)]
        public int? OpenedCenTrFirewallVpcCount { get; set; }

        /// <summary>
        /// <para>The number of enabled CEN Express Connect Routers (ECRs).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OpenedEcrCount")]
        [Validation(Required=false)]
        public int? OpenedEcrCount { get; set; }

        /// <summary>
        /// <para>The number of enabled Express Connect firewalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("OpenedExpressConnectFirewallCount")]
        [Validation(Required=false)]
        public int? OpenedExpressConnectFirewallCount { get; set; }

        /// <summary>
        /// <para>The number of VPCs protected by Express Connect firewalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("OpenedExpressConnectVpcCount")]
        [Validation(Required=false)]
        public int? OpenedExpressConnectVpcCount { get; set; }

        /// <summary>
        /// <para>The number of inter-region connections protected by the CEN transit router firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("OpenedPeerTrCount")]
        [Validation(Required=false)]
        public int? OpenedPeerTrCount { get; set; }

        /// <summary>
        /// <para>The number of Virtual Border Routers (VBRs) protected by the CEN transit router firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OpenedVbrCount")]
        [Validation(Required=false)]
        public int? OpenedVbrCount { get; set; }

        /// <summary>
        /// <para>The number of protected VPCs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17</para>
        /// </summary>
        [NameInMap("OpenedVpcCount")]
        [Validation(Required=false)]
        public int? OpenedVpcCount { get; set; }

        /// <summary>
        /// <para>The number of enabled VPC firewalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("OpenedVpcFirewallCount")]
        [Validation(Required=false)]
        public int? OpenedVpcFirewallCount { get; set; }

        /// <summary>
        /// <para>The number of VPN gateways protected by the CEN transit router firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("OpenedVpnCount")]
        [Validation(Required=false)]
        public int? OpenedVpnCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8AABEF64-7ABF-52CB-BA6C-0598E3DB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of ECRs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalEcrCount")]
        [Validation(Required=false)]
        public int? TotalEcrCount { get; set; }

        /// <summary>
        /// <para>The number of inter-region connections on the CEN transit router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalPeerTrCount")]
        [Validation(Required=false)]
        public int? TotalPeerTrCount { get; set; }

        /// <summary>
        /// <para>The number of VBRs on the CEN transit router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalVbrCount")]
        [Validation(Required=false)]
        public int? TotalVbrCount { get; set; }

        /// <summary>
        /// <para>The number of interconnected VPCs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalVpcCount")]
        [Validation(Required=false)]
        public int? TotalVpcCount { get; set; }

        /// <summary>
        /// <para>The total quota for VPC firewalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalVpcFirewallQuota")]
        [Validation(Required=false)]
        public int? TotalVpcFirewallQuota { get; set; }

        /// <summary>
        /// <para>The number of VPN gateways on the CEN transit router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalVpnCount")]
        [Validation(Required=false)]
        public int? TotalVpnCount { get; set; }

    }

}
