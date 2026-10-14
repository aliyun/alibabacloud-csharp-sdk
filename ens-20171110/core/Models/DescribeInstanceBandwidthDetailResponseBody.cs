// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeInstanceBandwidthDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection of Internet bandwidth cap information.</para>
        /// </summary>
        [NameInMap("Bandwidths")]
        [Validation(Required=false)]
        public List<DescribeInstanceBandwidthDetailResponseBodyBandwidths> Bandwidths { get; set; }
        public class DescribeInstanceBandwidthDetailResponseBodyBandwidths : TeaModel {
            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1972653484384661</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The bandwidth business time. The bandwidth calculation granularity is 5 minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-11 00:00:00</para>
            /// </summary>
            [NameInMap("BizTime")]
            [Validation(Required=false)]
            public string BizTime { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-yichang-2</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The bandwidth type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: public network.</description></item>
            /// <item><description>2: internal network.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FlowType")]
            [Validation(Required=false)]
            public int? FlowType { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-6ecpqvkicnchxccozrpxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance type, such as vm, eip, single_tenant, or nc.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vm</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The IP address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.107.***</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The Internet service provider (ISP) of the IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cmcc</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <para>The inbound bandwidth. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>43795230</para>
            /// </summary>
            [NameInMap("RxBw")]
            [Validation(Required=false)]
            public long? RxBw { get; set; }

            /// <summary>
            /// <para>The service type, such as vm, eip, esk, or meta.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vm</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <para>The outbound bandwidth. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25415638</para>
            /// </summary>
            [NameInMap("TxBw")]
            [Validation(Required=false)]
            public long? TxBw { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C0003E8B-B930-4F59-ADC0-0E209A9012A8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
