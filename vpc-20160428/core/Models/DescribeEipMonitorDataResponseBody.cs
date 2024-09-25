// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeEipMonitorDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed information about the monitoring data of the EIP.</para>
        /// </summary>
        [NameInMap("EipMonitorDatas")]
        [Validation(Required=false)]
        public DescribeEipMonitorDataResponseBodyEipMonitorDatas EipMonitorDatas { get; set; }
        public class DescribeEipMonitorDataResponseBodyEipMonitorDatas : TeaModel {
            [NameInMap("EipMonitorData")]
            [Validation(Required=false)]
            public List<DescribeEipMonitorDataResponseBodyEipMonitorDatasEipMonitorData> EipMonitorData { get; set; }
            public class DescribeEipMonitorDataResponseBodyEipMonitorDatasEipMonitorData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("EipBandwidth")]
                [Validation(Required=false)]
                public int? EipBandwidth { get; set; }

                /// <summary>
                /// <para>The sum of inbound and outbound traffic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>465</para>
                /// </summary>
                [NameInMap("EipFlow")]
                [Validation(Required=false)]
                public long? EipFlow { get; set; }

                /// <summary>
                /// <para>The number of packets.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3434</para>
                /// </summary>
                [NameInMap("EipPackets")]
                [Validation(Required=false)]
                public int? EipPackets { get; set; }

                /// <summary>
                /// <para>The inbound traffic. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>122</para>
                /// </summary>
                [NameInMap("EipRX")]
                [Validation(Required=false)]
                public long? EipRX { get; set; }

                /// <summary>
                /// <para>The outbound traffic. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>343</para>
                /// </summary>
                [NameInMap("EipTX")]
                [Validation(Required=false)]
                public long? EipTX { get; set; }

                /// <summary>
                /// <para>The timestamp of the monitoring data. Specify the time in the ISO8601 standard. Example: <c>2020-01-21T09:50:23Z</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-01-21T09:50:23Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C8B26B44-0189-443E-9816-D951F59623A9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
