// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeElasticBillsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of bills for the on-demand WAF instance.</para>
        /// </summary>
        [NameInMap("Bills")]
        [Validation(Required=false)]
        public List<DescribeElasticBillsResponseBodyBills> Bills { get; set; }
        public class DescribeElasticBillsResponseBodyBills : TeaModel {
            /// <summary>
            /// <para>The total number of SCUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Cu")]
            [Validation(Required=false)]
            public double? Cu { get; set; }

            /// <summary>
            /// <para>The end time of the bill. This value is a UNIX timestamp that is in UTC. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1717084800000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The number of SCUs consumed by WAF features.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("FunctionCu")]
            [Validation(Required=false)]
            public double? FunctionCu { get; set; }

            /// <summary>
            /// <para>The start time of the bill. This value is a UNIX timestamp that is in UTC. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665484616000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The number of security capacity units (SCUs) consumed by traffic processing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TrafficCu")]
            [Validation(Required=false)]
            public double? TrafficCu { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6FBF08CB-8691-5B65-BBF8-***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
