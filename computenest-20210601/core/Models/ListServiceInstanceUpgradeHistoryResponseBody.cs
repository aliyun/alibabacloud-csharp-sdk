// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListServiceInstanceUpgradeHistoryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAfu+XtuBE55iRLHEYYuojI41</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE3EDF4E-B3B1-19B6-BD01-30D4D00F6E5D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("UpgradeHistory")]
        [Validation(Required=false)]
        public List<ListServiceInstanceUpgradeHistoryResponseBodyUpgradeHistory> UpgradeHistory { get; set; }
        public class ListServiceInstanceUpgradeHistoryResponseBodyUpgradeHistory : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-04-26T09:09:51Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FromVersion")]
            [Validation(Required=false)]
            public string FromVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;PreUpgradeExecutionId\&quot;:\&quot;exec-123\&quot;}</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public string Results { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-04-26T08:09:51Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>UpgradeFailed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ToVersion")]
            [Validation(Required=false)]
            public string ToVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Upgrade</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>exec-123</para>
            /// </summary>
            [NameInMap("UpgradeHistoryId")]
            [Validation(Required=false)]
            public string UpgradeHistoryId { get; set; }

        }

    }

}
