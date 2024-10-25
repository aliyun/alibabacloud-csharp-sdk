// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeUserBandWidthDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned service code. 0 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The monitoring data.</para>
        /// </summary>
        [NameInMap("MonitorData")]
        [Validation(Required=false)]
        public DescribeUserBandWidthDataResponseBodyMonitorData MonitorData { get; set; }
        public class DescribeUserBandWidthDataResponseBodyMonitorData : TeaModel {
            /// <summary>
            /// <para>The bandwidth data.</para>
            /// </summary>
            [NameInMap("BandWidthMonitorData")]
            [Validation(Required=false)]
            public List<DescribeUserBandWidthDataResponseBodyMonitorDataBandWidthMonitorData> BandWidthMonitorData { get; set; }
            public class DescribeUserBandWidthDataResponseBodyMonitorDataBandWidthMonitorData : TeaModel {
                /// <summary>
                /// <para>The outbound bandwidth. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DownBandWidth")]
                [Validation(Required=false)]
                public long? DownBandWidth { get; set; }

                /// <summary>
                /// <para>The Internet traffic to the instance. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InternetRX")]
                [Validation(Required=false)]
                public long? InternetRX { get; set; }

                /// <summary>
                /// <para>The Internet traffic from the instance. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InternetTX")]
                [Validation(Required=false)]
                public long? InternetTX { get; set; }

                /// <summary>
                /// <para>The timestamp when the monitoring data was queried. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-10-12T05:45:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The inbound bandwidth. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UpBandWidth")]
                [Validation(Required=false)]
                public long? UpBandWidth { get; set; }

            }

            /// <summary>
            /// <para>The maximum outbound bandwidth within the queried time range. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16817468</para>
            /// </summary>
            [NameInMap("MaxDownBandWidth")]
            [Validation(Required=false)]
            public string MaxDownBandWidth { get; set; }

            /// <summary>
            /// <para>The maximum inbound bandwidth within the queried time range. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>231008</para>
            /// </summary>
            [NameInMap("MaxUpBandWidth")]
            [Validation(Required=false)]
            public string MaxUpBandWidth { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50373E71-7710-4620-8AAB-133CCE49451C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
