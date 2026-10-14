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
        /// <para>The near-origin traffic diversion configurations of the Anti-DDoS Pro and Anti-DDoS Premium instances.</para>
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<DescribeBlockStatusResponseBodyStatusList> StatusList { get; set; }
        public class DescribeBlockStatusResponseBodyStatusList : TeaModel {
            /// <summary>
            /// <para>The near-origin traffic diversion configurations.</para>
            /// </summary>
            [NameInMap("BlockStatusList")]
            [Validation(Required=false)]
            public List<DescribeBlockStatusResponseBodyStatusListBlockStatusList> BlockStatusList { get; set; }
            public class DescribeBlockStatusResponseBodyStatusListBlockStatusList : TeaModel {
                /// <summary>
                /// <para>The traffic blocking status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>areablock</b>: Blocked.</description></item>
                /// <item><description><b>normal</b>: Normal (not blocked).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>areablock</para>
                /// </summary>
                [NameInMap("BlockStatus")]
                [Validation(Required=false)]
                public string BlockStatus { get; set; }

                /// <summary>
                /// <para>The end time of the blocking. The value is a UNIX timestamp. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1540196323</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The type of the blocked line. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ct</b>: China Telecom international line.</description></item>
                /// <item><description><b>cut</b>: China Unicom international line.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cut</para>
                /// </summary>
                [NameInMap("Line")]
                [Validation(Required=false)]
                public string Line { get; set; }

                /// <summary>
                /// <para>The start time of the blocking. The value is a UNIX timestamp. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1540195323</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

            /// <summary>
            /// <para>The IP address of the Anti-DDoS Pro and Anti-DDoS Premium instance.</para>
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
