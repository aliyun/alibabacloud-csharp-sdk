// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallSummaryInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("AvailableVpcFirewallQuota")]
        [Validation(Required=false)]
        public int? AvailableVpcFirewallQuota { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("CenExpressConnectVpcCount")]
        [Validation(Required=false)]
        public int? CenExpressConnectVpcCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("CenFirewallVpcCount")]
        [Validation(Required=false)]
        public int? CenFirewallVpcCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("CenTrVpcCount")]
        [Validation(Required=false)]
        public int? CenTrVpcCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ClosedCenFirewallCount")]
        [Validation(Required=false)]
        public int? ClosedCenFirewallCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ClosedExpressConnectFirewallCount")]
        [Validation(Required=false)]
        public int? ClosedExpressConnectFirewallCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ClosedVpcFirewallCount")]
        [Validation(Required=false)]
        public int? ClosedVpcFirewallCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ConfiguredCenFirewallCount")]
        [Validation(Required=false)]
        public int? ConfiguredCenFirewallCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ConfiguredCenFirewallRegionCount")]
        [Validation(Required=false)]
        public int? ConfiguredCenFirewallRegionCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18</para>
        /// </summary>
        [NameInMap("ConfiguredCenFirewallVpcCount")]
        [Validation(Required=false)]
        public int? ConfiguredCenFirewallVpcCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ConfiguredCenTrFirewallCount")]
        [Validation(Required=false)]
        public int? ConfiguredCenTrFirewallCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ConfiguredExpressConnectFirewallCount")]
        [Validation(Required=false)]
        public int? ConfiguredExpressConnectFirewallCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ConfiguredExpressConnectVpcCount")]
        [Validation(Required=false)]
        public int? ConfiguredExpressConnectVpcCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ConfiguredVpcFirewallCount")]
        [Validation(Required=false)]
        public int? ConfiguredVpcFirewallCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ConfiguredVpcFirewallVpcCount")]
        [Validation(Required=false)]
        public int? ConfiguredVpcFirewallVpcCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ExpressConnectVpcCount")]
        [Validation(Required=false)]
        public int? ExpressConnectVpcCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("NotConfiguredCenFirewallCount")]
        [Validation(Required=false)]
        public int? NotConfiguredCenFirewallCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("NotConfiguredCenTrFirewallCount")]
        [Validation(Required=false)]
        public int? NotConfiguredCenTrFirewallCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("NotConfiguredExpressConnectFirewallCount")]
        [Validation(Required=false)]
        public int? NotConfiguredExpressConnectFirewallCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("NotConfiguredVpcFirewallCount")]
        [Validation(Required=false)]
        public int? NotConfiguredVpcFirewallCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("OpenedCenExpressConnectVpcCount")]
        [Validation(Required=false)]
        public int? OpenedCenExpressConnectVpcCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("OpenedCenFirewallCount")]
        [Validation(Required=false)]
        public int? OpenedCenFirewallCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OpenedCenFirewallVpcCount")]
        [Validation(Required=false)]
        public int? OpenedCenFirewallVpcCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("OpenedCenTrFirewallVpcCount")]
        [Validation(Required=false)]
        public int? OpenedCenTrFirewallVpcCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OpenedEcrCount")]
        [Validation(Required=false)]
        public int? OpenedEcrCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("OpenedExpressConnectFirewallCount")]
        [Validation(Required=false)]
        public int? OpenedExpressConnectFirewallCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("OpenedExpressConnectVpcCount")]
        [Validation(Required=false)]
        public int? OpenedExpressConnectVpcCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("OpenedPeerTrCount")]
        [Validation(Required=false)]
        public int? OpenedPeerTrCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OpenedVbrCount")]
        [Validation(Required=false)]
        public int? OpenedVbrCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>17</para>
        /// </summary>
        [NameInMap("OpenedVpcCount")]
        [Validation(Required=false)]
        public int? OpenedVpcCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("OpenedVpcFirewallCount")]
        [Validation(Required=false)]
        public int? OpenedVpcFirewallCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("OpenedVpnCount")]
        [Validation(Required=false)]
        public int? OpenedVpnCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8AABEF64-7ABF-52CB-BA6C-0598E3DB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalEcrCount")]
        [Validation(Required=false)]
        public int? TotalEcrCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalPeerTrCount")]
        [Validation(Required=false)]
        public int? TotalPeerTrCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalVbrCount")]
        [Validation(Required=false)]
        public int? TotalVbrCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalVpcCount")]
        [Validation(Required=false)]
        public int? TotalVpcCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalVpcFirewallQuota")]
        [Validation(Required=false)]
        public int? TotalVpcFirewallQuota { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalVpnCount")]
        [Validation(Required=false)]
        public int? TotalVpnCount { get; set; }

    }

}
