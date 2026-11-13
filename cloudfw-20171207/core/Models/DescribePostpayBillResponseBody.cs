// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePostpayBillResponseBody : TeaModel {
        /// <summary>
        /// <para>The aggregated Internet traffic. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AggregateInternetTraffic")]
        [Validation(Required=false)]
        public float? AggregateInternetTraffic { get; set; }

        /// <summary>
        /// <para>The aggregated NAT traffic. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AggregateNatTraffic")]
        [Validation(Required=false)]
        public float? AggregateNatTraffic { get; set; }

        /// <summary>
        /// <para>The aggregated sensitive data detection traffic. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AggregateSdlTraffic")]
        [Validation(Required=false)]
        public float? AggregateSdlTraffic { get; set; }

        /// <summary>
        /// <para>The aggregated total traffic. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("AggregateTotalTraffic")]
        [Validation(Required=false)]
        public float? AggregateTotalTraffic { get; set; }

        /// <summary>
        /// <para>The aggregated VPC traffic. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AggregateVpcTraffic")]
        [Validation(Required=false)]
        public float? AggregateVpcTraffic { get; set; }

        /// <summary>
        /// <para>The list of bills.</para>
        /// </summary>
        [NameInMap("BillList")]
        [Validation(Required=false)]
        public List<DescribePostpayBillResponseBodyBillList> BillList { get; set; }
        public class DescribePostpayBillResponseBodyBillList : TeaModel {
            /// <summary>
            /// <para>The end time. The time is a UNIX timestamp accurate to seconds, which represents an exact hour or day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1733710015</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The number of Internet instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("InternetInstanceCnt")]
            [Validation(Required=false)]
            public long? InternetInstanceCnt { get; set; }

            /// <summary>
            /// <para>The Internet traffic. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("InternetTraffic")]
            [Validation(Required=false)]
            public float? InternetTraffic { get; set; }

            /// <summary>
            /// <para>Indicates whether the fee is reduced. A value of 0 indicates that the fee is not reduced. A value greater than 0 indicates that the fee is reduced. If the fee is reduced, no bill is generated.</para>
            /// <remarks>
            /// <para>This parameter is valid only when you query hourly data.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsDerated")]
            [Validation(Required=false)]
            public int? IsDerated { get; set; }

            /// <summary>
            /// <para>The usage duration of Simple Log Service. Unit: TB×h.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("LogStorage")]
            [Validation(Required=false)]
            public long? LogStorage { get; set; }

            /// <summary>
            /// <para>The number of NAT instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NatInstanceCnt")]
            [Validation(Required=false)]
            public long? NatInstanceCnt { get; set; }

            /// <summary>
            /// <para>The NAT traffic. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NatTraffic")]
            [Validation(Required=false)]
            public float? NatTraffic { get; set; }

            /// <summary>
            /// <para>The usage duration of sensitive data leak detection. Unit: hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Sdl")]
            [Validation(Required=false)]
            public long? Sdl { get; set; }

            /// <summary>
            /// <para>The sensitive data detection traffic. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SdlTraffic")]
            [Validation(Required=false)]
            public float? SdlTraffic { get; set; }

            /// <summary>
            /// <para>The start time. The time is a UNIX timestamp accurate to seconds, which represents an exact hour or day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1710206070000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The usage duration of threat intelligence. Unit: hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ThreatIntelligence")]
            [Validation(Required=false)]
            public long? ThreatIntelligence { get; set; }

            /// <summary>
            /// <para>The number of VPC instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("VpcInstanceCnt")]
            [Validation(Required=false)]
            public long? VpcInstanceCnt { get; set; }

            /// <summary>
            /// <para>The VPC traffic. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("VpcTraffic")]
            [Validation(Required=false)]
            public float? VpcTraffic { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>133173B9-8010-5DF5-8B93-********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
