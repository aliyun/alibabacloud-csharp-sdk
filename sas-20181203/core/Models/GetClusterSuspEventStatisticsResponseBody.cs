// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetClusterSuspEventStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each API request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACF97412-FD09-4D1F-994F-34DF12BR****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of alerts by severity level.</para>
        /// </summary>
        [NameInMap("SuspStatistics")]
        [Validation(Required=false)]
        public GetClusterSuspEventStatisticsResponseBodySuspStatistics SuspStatistics { get; set; }
        public class GetClusterSuspEventStatisticsResponseBodySuspStatistics : TeaModel {
            /// <summary>
            /// <para>The number of alerts with the reminder severity level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Remind")]
            [Validation(Required=false)]
            public int? Remind { get; set; }

            /// <summary>
            /// <para>The number of alerts with the urgent severity level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Serious")]
            [Validation(Required=false)]
            public int? Serious { get; set; }

            /// <summary>
            /// <para>The number of alerts with the suspicious severity level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Suspicious")]
            [Validation(Required=false)]
            public int? Suspicious { get; set; }

        }

    }

}
