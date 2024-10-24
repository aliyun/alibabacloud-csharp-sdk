// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeBlockStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C33EB3D5-AF96-43CA-9C7E-37A81BC06A1E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of details of the Diversion from Origin Server configurations of the instance.</para>
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<DescribeBlockStatusResponseBodyStatusList> StatusList { get; set; }
        public class DescribeBlockStatusResponseBodyStatusList : TeaModel {
            /// <summary>
            /// <para>An array that consists of details of the Diversion from Origin Server configuration.</para>
            /// </summary>
            [NameInMap("BlockStatusList")]
            [Validation(Required=false)]
            public List<DescribeBlockStatusResponseBodyStatusListBlockStatusList> BlockStatusList { get; set; }
            public class DescribeBlockStatusResponseBodyStatusListBlockStatusList : TeaModel {
                /// <summary>
                /// <para>The blocking status of the network traffic. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>areablock</b>: Network traffic is blocked.</description></item>
                /// <item><description><b>normal</b>: Network traffic is not blocked.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>areablock</para>
                /// </summary>
                [NameInMap("BlockStatus")]
                [Validation(Required=false)]
                public string BlockStatus { get; set; }

                /// <summary>
                /// <para>The end time of the blocking. This value is a UNIX timestamp. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1540196323</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The Internet service provider (ISP) line from which the traffic is blocked. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ct</b>: China Telecom (International)</description></item>
                /// <item><description><b>cut</b>: China Unicom (International)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cut</para>
                /// </summary>
                [NameInMap("Line")]
                [Validation(Required=false)]
                public string Line { get; set; }

                /// <summary>
                /// <para>The start time of the blocking. This value is a UNIX timestamp. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1540195323</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

            /// <summary>
            /// <para>The IP address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.XX.XX.88</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

        }

    }

}
