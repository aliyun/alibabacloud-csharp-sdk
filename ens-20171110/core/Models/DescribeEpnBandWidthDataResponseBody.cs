// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEpnBandWidthDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The monitoring data of the instance.</para>
        /// </summary>
        [NameInMap("MonitorData")]
        [Validation(Required=false)]
        public DescribeEpnBandWidthDataResponseBodyMonitorData MonitorData { get; set; }
        public class DescribeEpnBandWidthDataResponseBodyMonitorData : TeaModel {
            /// <summary>
            /// <para>The bandwidth monitoring data.</para>
            /// </summary>
            [NameInMap("BandWidthMonitorData")]
            [Validation(Required=false)]
            public List<DescribeEpnBandWidthDataResponseBodyMonitorDataBandWidthMonitorData> BandWidthMonitorData { get; set; }
            public class DescribeEpnBandWidthDataResponseBodyMonitorDataBandWidthMonitorData : TeaModel {
                /// <summary>
                /// <para>The downstream bandwidth. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DownBandWidth")]
                [Validation(Required=false)]
                public long? DownBandWidth { get; set; }

                /// <summary>
                /// <para>The inbound public network traffic of the instance. Unit: bits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InternetRX")]
                [Validation(Required=false)]
                public long? InternetRX { get; set; }

                /// <summary>
                /// <para>The outbound public network traffic of the instance. Unit: bits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InternetTX")]
                [Validation(Required=false)]
                public long? InternetTX { get; set; }

                /// <summary>
                /// <para>The timestamp of the monitoring data. The time is in UTC and in the format of yyyy-MM-DDThh:mm:ssZ.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-10-12T05:45:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The upstream bandwidth. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UpBandWidth")]
                [Validation(Required=false)]
                public long? UpBandWidth { get; set; }

            }

            /// <summary>
            /// <para>The maximum downstream bandwidth within the queried time range. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16817468</para>
            /// </summary>
            [NameInMap("MaxDownBandWidth")]
            [Validation(Required=false)]
            public long? MaxDownBandWidth { get; set; }

            /// <summary>
            /// <para>The maximum upstream bandwidth within the queried time range. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>231008</para>
            /// </summary>
            [NameInMap("MaxUpBandWidth")]
            [Validation(Required=false)]
            public long? MaxUpBandWidth { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1D289DAA-F6DA-5FC4-AE47-F5C8B6277BFC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
