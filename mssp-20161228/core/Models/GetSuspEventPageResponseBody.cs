// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetSuspEventPageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetSuspEventPageResponseBodyData> Data { get; set; }
        public class GetSuspEventPageResponseBodyData : TeaModel {
            [NameInMap("AlarmEventType")]
            [Validation(Required=false)]
            public string AlarmEventType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5b1eeebe4f22daa2b177298234214fa3</para>
            /// </summary>
            [NameInMap("AlarmId")]
            [Validation(Required=false)]
            public long? AlarmId { get; set; }

            [NameInMap("AlarmName")]
            [Validation(Required=false)]
            public string AlarmName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUSP_EVENT</para>
            /// </summary>
            [NameInMap("AlarmSource")]
            [Validation(Required=false)]
            public string AlarmSource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1722515522000</para>
            /// </summary>
            [NameInMap("AlarmTime")]
            [Validation(Required=false)]
            public string AlarmTime { get; set; }

            [NameInMap("AnalysisResult")]
            [Validation(Required=false)]
            public string AnalysisResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1732515522000</para>
            /// </summary>
            [NameInMap("DealTime")]
            [Validation(Required=false)]
            public string DealTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>suspicious</para>
            /// </summary>
            [NameInMap("EventLevel")]
            [Validation(Required=false)]
            public string EventLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9947</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>shells-azhou</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>47.99.188.31</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>172.16.109.130</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            [NameInMap("OccurrenceTime")]
            [Validation(Required=false)]
            public string OccurrenceTime { get; set; }

            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>system error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetSuspEventPageResponseBodyPageInfo PageInfo { get; set; }
        public class GetSuspEventPageResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AFA6F7B7-7C4B-58BB-B8FB-E0FFA4483561</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
