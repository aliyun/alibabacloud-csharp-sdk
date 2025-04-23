// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetCloudMetricLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried performance metric data.</para>
        /// </summary>
        [NameInMap("MetricLogs")]
        [Validation(Required=false)]
        public GetCloudMetricLogsResponseBodyMetricLogs MetricLogs { get; set; }
        public class GetCloudMetricLogsResponseBodyMetricLogs : TeaModel {
            [NameInMap("MetricLog")]
            [Validation(Required=false)]
            public List<GetCloudMetricLogsResponseBodyMetricLogsMetricLog> MetricLog { get; set; }
            public class GetCloudMetricLogsResponseBodyMetricLogsMetricLog : TeaModel {
                /// <summary>
                /// <para>The name of the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vda1</para>
                /// </summary>
                [NameInMap("DiskDevice")]
                [Validation(Required=false)]
                public string DiskDevice { get; set; }

                /// <summary>
                /// <para>The hostname of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>compute000</para>
                /// </summary>
                [NameInMap("Hostname")]
                [Validation(Required=false)]
                public string Hostname { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp132g97g7zwnvta****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>A JSON-formatted serialized string that contains performance metric data of multiple categories.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;process|cpusage\&quot;:0,\&quot;process|cpuser\&quot;:0,\&quot;process|cpusys\&quot;:0,******}</para>
                /// </summary>
                [NameInMap("MetricData")]
                [Validation(Required=false)]
                public string MetricData { get; set; }

                /// <summary>
                /// <para>The name of the network interface.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eth1</para>
                /// </summary>
                [NameInMap("NetworkInterface")]
                [Validation(Required=false)]
                public string NetworkInterface { get; set; }

                /// <summary>
                /// <para>The timestamp of the log. The time is a timestamp. This value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1583907780</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public int? Time { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>015C2C4D-1884-4EB7-BCD3-C5BB8D7E56DB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
