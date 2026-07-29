// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeNetworkLayerInterceptsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of interception log records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InterceptionRecordCount")]
        [Validation(Required=false)]
        public long? InterceptionRecordCount { get; set; }

        /// <summary>
        /// <para>The interception record details.</para>
        /// </summary>
        [NameInMap("InterceptionRecords")]
        [Validation(Required=false)]
        public List<DescribeNetworkLayerInterceptsResponseBodyInterceptionRecords> InterceptionRecords { get; set; }
        public class DescribeNetworkLayerInterceptsResponseBodyInterceptionRecords : TeaModel {
            /// <summary>
            /// <para>The destination IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.254.56.252</para>
            /// </summary>
            [NameInMap("DestinationIp")]
            [Validation(Required=false)]
            public string DestinationIp { get; set; }

            /// <summary>
            /// <para>The destination port in the interception log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("DestinationPort")]
            [Validation(Required=false)]
            public string DestinationPort { get; set; }

            /// <summary>
            /// <para>The interception action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>drop</para>
            /// </summary>
            [NameInMap("InterceptAction")]
            [Validation(Required=false)]
            public string InterceptAction { get; set; }

            /// <summary>
            /// <para>The number of interceptions within the specified time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InterceptCount")]
            [Validation(Required=false)]
            public long? InterceptCount { get; set; }

            /// <summary>
            /// <para>The end time of the interception.</para>
            /// <remarks>
            /// <para>The value is a Unix/POSIX timestamp. Unit: seconds.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1778830500</para>
            /// </summary>
            [NameInMap("InterceptEndTime")]
            [Validation(Required=false)]
            public long? InterceptEndTime { get; set; }

            /// <summary>
            /// <para>The packet interception module.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dip_blacklist</para>
            /// </summary>
            [NameInMap("InterceptModule")]
            [Validation(Required=false)]
            public string InterceptModule { get; set; }

            /// <summary>
            /// <para>The start time of the interception.</para>
            /// <remarks>
            /// <para>The value is a Unix/POSIX timestamp. Unit: seconds.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1778830500</para>
            /// </summary>
            [NameInMap("InterceptStartTime")]
            [Validation(Required=false)]
            public long? InterceptStartTime { get; set; }

            /// <summary>
            /// <para>The network protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("NetworkProtocol")]
            [Validation(Required=false)]
            public string NetworkProtocol { get; set; }

            /// <summary>
            /// <para>The network protocol number. This is a standard network protocol number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("ProtocolNumber")]
            [Validation(Required=false)]
            public string ProtocolNumber { get; set; }

            /// <summary>
            /// <para>The source IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>183.224.38.37</para>
            /// </summary>
            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            /// <summary>
            /// <para>The source port in the interception log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9998</para>
            /// </summary>
            [NameInMap("SourcePort")]
            [Validation(Required=false)]
            public string SourcePort { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4B379C2-9319-4C6B-B579-FE36831B09F4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of interception logs that match the current filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17</para>
        /// </summary>
        [NameInMap("TotalCnt")]
        [Validation(Required=false)]
        public string TotalCnt { get; set; }

    }

}
