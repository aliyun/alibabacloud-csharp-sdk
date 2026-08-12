// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudClusterServersResponseBody : TeaModel {
        /// <summary>
        /// <para>The result list.</para>
        /// </summary>
        [NameInMap("ClusterServers")]
        [Validation(Required=false)]
        public List<DescribeHybridCloudClusterServersResponseBodyClusterServers> ClusterServers { get; set; }
        public class DescribeHybridCloudClusterServersResponseBodyClusterServers : TeaModel {
            /// <summary>
            /// <para>The continent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asiapacific</para>
            /// </summary>
            [NameInMap("Continents")]
            [Validation(Required=false)]
            public string Continents { get; set; }

            /// <summary>
            /// <para>The continent code of the protection cluster.</para>
            /// <remarks>
            /// <para>For the list of code values, see the supplementary description of response parameters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>410</para>
            /// </summary>
            [NameInMap("ContinentsValue")]
            [Validation(Required=false)]
            public int? ContinentsValue { get; set; }

            /// <summary>
            /// <para>The number of CPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The creation timestamp, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665987186000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>The node name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customTest</para>
            /// </summary>
            [NameInMap("CustomName")]
            [Validation(Required=false)]
            public string CustomName { get; set; }

            /// <summary>
            /// <para>The node group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// <para>The name of the node group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>groupTest</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The type of the hybrid cloud node group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>protect</b>: protection.</para>
            /// </description></item>
            /// <item><description><para><b>control</b>: management.</para>
            /// </description></item>
            /// <item><description><para><b>storage</b>: storage.</para>
            /// </description></item>
            /// <item><description><para><b>controlStorage</b>: management and storage.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>protect</para>
            /// </summary>
            [NameInMap("GroupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            /// <summary>
            /// <para>The hostname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qsh5-sec-waf-*****-6</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.*.*1</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The running status of the machine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            /// <summary>
            /// <para>The MAC address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b>:</b>:00:02:eb:c7</para>
            /// </summary>
            [NameInMap("Mac")]
            [Validation(Required=false)]
            public string Mac { get; set; }

            /// <summary>
            /// <para>The memory data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33547386880</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <para>The machine identifier (MID).</para>
            /// 
            /// <b>Example:</b>
            /// <para>28ab688cd403563e8e173*****79600</para>
            /// </summary>
            [NameInMap("Mid")]
            [Validation(Required=false)]
            public string Mid { get; set; }

            /// <summary>
            /// <para>The cloud service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>The operator value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OperatorValue")]
            [Validation(Required=false)]
            public int? OperatorValue { get; set; }

            /// <summary>
            /// <para>The region name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>beijing</para>
            /// </summary>
            [NameInMap("RegionCode")]
            [Validation(Required=false)]
            public string RegionCode { get; set; }

            /// <summary>
            /// <para>The region code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RegionCodeValue")]
            [Validation(Required=false)]
            public int? RegionCodeValue { get; set; }

            /// <summary>
            /// <para>The machine status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The last update timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1711953897000</para>
            /// </summary>
            [NameInMap("UpdateTimestamp")]
            [Validation(Required=false)]
            public long? UpdateTimestamp { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C3B0FDD2-11CE-59A5-BEB5-*****1A969</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
