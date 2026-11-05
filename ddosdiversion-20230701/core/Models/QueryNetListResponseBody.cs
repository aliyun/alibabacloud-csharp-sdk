// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DdosDiversion20230701.Models
{
    public class QueryNetListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <list type="bullet">
        /// <item><description><para>200: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>Other codes: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The CIDR blocks.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryNetListResponseBodyData Data { get; set; }
        public class QueryNetListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The CIDR blocks.</para>
            /// </summary>
            [NameInMap("Nets")]
            [Validation(Required=false)]
            public List<QueryNetListResponseBodyDataNets> Nets { get; set; }
            public class QueryNetListResponseBodyDataNets : TeaModel {
                /// <summary>
                /// <para>The DDoS mitigation configuration of the CIDR block.</para>
                /// </summary>
                [NameInMap("DDoSDefense")]
                [Validation(Required=false)]
                public QueryNetListResponseBodyDataNetsDDoSDefense DDoSDefense { get; set; }
                public class QueryNetListResponseBodyDataNetsDDoSDefense : TeaModel {
                    /// <summary>
                    /// <para>The configuration of traffic scrubbing.</para>
                    /// </summary>
                    [NameInMap("CleanTh")]
                    [Validation(Required=false)]
                    public QueryNetListResponseBodyDataNetsDDoSDefenseCleanTh CleanTh { get; set; }
                    public class QueryNetListResponseBodyDataNetsDDoSDefenseCleanTh : TeaModel {
                        /// <summary>
                        /// <para>The traffic scrubbing threshold in Mbit/s.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Mbps")]
                        [Validation(Required=false)]
                        public int? Mbps { get; set; }

                        /// <summary>
                        /// <para>The traffic scrubbing threshold in packets per second (pps).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Pps")]
                        [Validation(Required=false)]
                        public int? Pps { get; set; }

                    }

                    [NameInMap("CustomNetPolicy")]
                    [Validation(Required=false)]
                    public QueryNetListResponseBodyDataNetsDDoSDefenseCustomNetPolicy CustomNetPolicy { get; set; }
                    public class QueryNetListResponseBodyDataNetsDDoSDefenseCustomNetPolicy : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("PolicyName")]
                        [Validation(Required=false)]
                        public string PolicyName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>BROAD_TMPL_1710000000_0001</para>
                        /// </summary>
                        [NameInMap("TmplId")]
                        [Validation(Required=false)]
                        public string TmplId { get; set; }

                    }

                    /// <summary>
                    /// <para>The configuration of the mitigation policy.</para>
                    /// </summary>
                    [NameInMap("DjPolicy")]
                    [Validation(Required=false)]
                    public QueryNetListResponseBodyDataNetsDDoSDefenseDjPolicy DjPolicy { get; set; }
                    public class QueryNetListResponseBodyDataNetsDDoSDefenseDjPolicy : TeaModel {
                        /// <summary>
                        /// <para>The name of the mitigation policy.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>gf_origin_xxxxx</para>
                        /// </summary>
                        [NameInMap("PolicyName")]
                        [Validation(Required=false)]
                        public string PolicyName { get; set; }

                    }

                    /// <summary>
                    /// <para>The configuration of blackhole filtering.</para>
                    /// </summary>
                    [NameInMap("HoleTh")]
                    [Validation(Required=false)]
                    public QueryNetListResponseBodyDataNetsDDoSDefenseHoleTh HoleTh { get; set; }
                    public class QueryNetListResponseBodyDataNetsDDoSDefenseHoleTh : TeaModel {
                        /// <summary>
                        /// <para>The blackhole filtering threshold in Mbit/s. The value 0 indicates best-effort protection.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ThreshMbps")]
                        [Validation(Required=false)]
                        public int? ThreshMbps { get; set; }

                    }

                }

                /// <summary>
                /// <para>The advertising details.</para>
                /// </summary>
                [NameInMap("Declared")]
                [Validation(Required=false)]
                public List<QueryNetListResponseBodyDataNetsDeclared> Declared { get; set; }
                public class QueryNetListResponseBodyDataNetsDeclared : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the CIDR block is advertised. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>0: The CIDR block is not advertised.</para>
                    /// </description></item>
                    /// <item><description><para>1: The CIDR block is advertised.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Declared")]
                    [Validation(Required=false)]
                    public string Declared { get; set; }

                    /// <summary>
                    /// <para>The region in which the CIDR block is advertised. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>oe26: China (Hong Kong).</para>
                    /// </description></item>
                    /// <item><description><para>us50: US (Virginia).</para>
                    /// </description></item>
                    /// <item><description><para>oe24: US (Silicon Valley).</para>
                    /// </description></item>
                    /// <item><description><para>oe28: Singapore.</para>
                    /// </description></item>
                    /// <item><description><para>jp141: Japan (Tokyo).</para>
                    /// </description></item>
                    /// <item><description><para>Gb145: UK (London).</para>
                    /// </description></item>
                    /// <item><description><para>oi39: Germany (Frankfurt).</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oe26</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                }

                /// <summary>
                /// <para>The advertising status of the CIDR block. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: The CIDR block is not advertised.</para>
                /// </description></item>
                /// <item><description><para>1: The CIDR block is advertised.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DeclaredState")]
                [Validation(Required=false)]
                public int? DeclaredState { get; set; }

                /// <summary>
                /// <para>Indicates whether the forwarding configuration takes effect. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: The forwarding configuration does not take effect.</para>
                /// </description></item>
                /// <item><description><para>1: The forwarding configuration takes effect.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FwdEffect")]
                [Validation(Required=false)]
                public long? FwdEffect { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-05 13:52:50</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-05 13:59:55</para>
                /// </summary>
                [NameInMap("GmtModify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <para>The scheduling mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>netflow-auto</para>
                /// </description></item>
                /// <item><description><para>manual</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>manual</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The CIDR block of the anti-DDoS diversion instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.XX.XX/24</para>
                /// </summary>
                [NameInMap("Net")]
                [Validation(Required=false)]
                public string Net { get; set; }

                /// <summary>
                /// <para>Indicates whether the CIDR block needs to be extended. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: The CIDR block does not need to be extended.</para>
                /// </description></item>
                /// <item><description><para>1: The CIDR block needs to be extended.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NetExtend")]
                [Validation(Required=false)]
                public string NetExtend { get; set; }

                /// <summary>
                /// <para>The primary CIDR block of the anti-DDoS diversion instance for which an extended CIDR block is configured. If no extended CIDR blocks are configured for the anti-DDoS diversion instance, this parameter is left empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.XX.XX/22</para>
                /// </summary>
                [NameInMap("NetMain")]
                [Validation(Required=false)]
                public string NetMain { get; set; }

                /// <summary>
                /// <para>The type of the CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv4</para>
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// <para>The review status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: not reviewed.</para>
                /// </description></item>
                /// <item><description><para>1: reviewed.</para>
                /// </description></item>
                /// <item><description><para>2: under review.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Permit")]
                [Validation(Required=false)]
                public int? Permit { get; set; }

                /// <summary>
                /// <para>The ID of the anti-DDoS diversion instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ddos_diversion_public_cn-xxxxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("SaleId")]
                [Validation(Required=false)]
                public string SaleId { get; set; }

                /// <summary>
                /// <para>The reinjection type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>aliyun_line</para>
                /// </description></item>
                /// <item><description><para>pccw_line</para>
                /// </description></item>
                /// <item><description><para>gre_line</para>
                /// </description></item>
                /// <item><description><para>private_line</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun_line</para>
                /// </summary>
                [NameInMap("UpstreamType")]
                [Validation(Required=false)]
                public string UpstreamType { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>57690941xxxxxxxx</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Num")]
            [Validation(Required=false)]
            public long? Num { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The response parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24B652B5-AEFF-3F03-9114-00D053C42277</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
