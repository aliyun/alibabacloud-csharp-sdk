// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListAlarmHistoriesResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The details of the quota alert history records.</para>
        /// </summary>
        [NameInMap("AlarmHistories")]
        [Validation(Required=false)]
        public List<ListAlarmHistoriesResponseBodyAlarmHistories> AlarmHistories { get; set; }
        public class ListAlarmHistoriesResponseBodyAlarmHistories : Darabonba.Model {
            /// <summary>
            /// <para>The name of the quota alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>q_security-groups alarm</para>
            /// </summary>
            [NameInMap("AlarmName")]
            [Validation(Required=false)]
            public string AlarmName { get; set; }

            /// <summary>
            /// <para>The time when the quota alert was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-24T09:20:09Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The notification channels for the quota alert.</para>
            /// </summary>
            [NameInMap("NotifyChannels")]
            [Validation(Required=false)]
            public List<string> NotifyChannels { get; set; }

            /// <summary>
            /// <para>The notification recipients of the quota alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>accountContact</para>
            /// </summary>
            [NameInMap("NotifyTarget")]
            [Validation(Required=false)]
            public string NotifyTarget { get; set; }

            /// <summary>
            /// <para>The abbreviation of the cloud service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The quota ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>q_security-groups</para>
            /// </summary>
            [NameInMap("QuotaActionCode")]
            [Validation(Required=false)]
            public string QuotaActionCode { get; set; }

            /// <summary>
            /// <para>The quota usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>31</para>
            /// </summary>
            [NameInMap("QuotaUsage")]
            [Validation(Required=false)]
            public float? QuotaUsage { get; set; }

            /// <summary>
            /// <para>The value of the quota alert threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>29</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

            /// <summary>
            /// <para>The percentage of the quota alert threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("ThresholdPercent")]
            [Validation(Required=false)]
            public float? ThresholdPercent { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned for the current query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that marks the position of the returned query data. An empty value indicates that all data has been queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB38DDF9-B1E0-48C1-9966-19C443C2841E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned for the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

