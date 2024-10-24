// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortFlowListResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned traffic data.</para>
        /// </summary>
        [NameInMap("PortFlowList")]
        [Validation(Required=false)]
        public List<DescribePortFlowListResponseBodyPortFlowList> PortFlowList { get; set; }
        public class DescribePortFlowListResponseBodyPortFlowList : TeaModel {
            /// <summary>
            /// <para>The bandwidth of attack traffic. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AttackBps")]
            [Validation(Required=false)]
            public long? AttackBps { get; set; }

            /// <summary>
            /// <para>The packet forwarding rate of attack traffic. Unit: pps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AttackPps")]
            [Validation(Required=false)]
            public long? AttackPps { get; set; }

            /// <summary>
            /// <para>The inbound bandwidth. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2176000</para>
            /// </summary>
            [NameInMap("InBps")]
            [Validation(Required=false)]
            public long? InBps { get; set; }

            /// <summary>
            /// <para>The packet forwarding rate of inbound traffic. Unit: packets per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2934</para>
            /// </summary>
            [NameInMap("InPps")]
            [Validation(Required=false)]
            public long? InPps { get; set; }

            /// <summary>
            /// <para>The index number of the returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            /// <summary>
            /// <para>The outbound bandwidth. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4389</para>
            /// </summary>
            [NameInMap("OutBps")]
            [Validation(Required=false)]
            public long? OutBps { get; set; }

            /// <summary>
            /// <para>The packet forwarding rate of outbound traffic. Unit: packets per second (pps).</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("OutPps")]
            [Validation(Required=false)]
            public long? OutPps { get; set; }

            /// <summary>
            /// <para>The source region of the traffic. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cn</b>: mainland China</description></item>
            /// <item><description><b>alb-ap-northeast-1-gf-x</b>: Japan (Tokyo)</description></item>
            /// <item><description><b>alb-ap-southeast-gf-x</b>: Singapore</description></item>
            /// <item><description><b>alb-cn-hongkong-gf-x</b>: Hong Kong (China)</description></item>
            /// <item><description><b>alb-eu-central-1-gf-x</b>: Germany (Frankfurt)</description></item>
            /// <item><description><b>alb-us-west-1-gf-x</b>: US (Silicon Valley)</description></item>
            /// </list>
            /// <remarks>
            /// <para>The values except <b>cn</b> are returned only when <b>RegionId</b> is set to <b>ap-southeast-1</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("SlaBpsDropBps")]
            [Validation(Required=false)]
            public long? SlaBpsDropBps { get; set; }

            [NameInMap("SlaBpsDropPps")]
            [Validation(Required=false)]
            public long? SlaBpsDropPps { get; set; }

            [NameInMap("SlaConnDropBps")]
            [Validation(Required=false)]
            public long? SlaConnDropBps { get; set; }

            [NameInMap("SlaConnDropPps")]
            [Validation(Required=false)]
            public long? SlaConnDropPps { get; set; }

            [NameInMap("SlaCpsDropBps")]
            [Validation(Required=false)]
            public long? SlaCpsDropBps { get; set; }

            [NameInMap("SlaCpsDropPps")]
            [Validation(Required=false)]
            public long? SlaCpsDropPps { get; set; }

            [NameInMap("SlaPpsDropBps")]
            [Validation(Required=false)]
            public long? SlaPpsDropBps { get; set; }

            [NameInMap("SlaPpsDropPps")]
            [Validation(Required=false)]
            public long? SlaPpsDropPps { get; set; }

            /// <summary>
            /// <para>The time when the data was collected. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1582992000</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFC77501-BDF8-4BC8-9BF5-B295FBC3189B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
