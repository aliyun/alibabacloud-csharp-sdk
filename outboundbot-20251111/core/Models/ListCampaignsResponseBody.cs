// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class ListCampaignsResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The paged query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCampaignsResponseBodyData Data { get; set; }
        public class ListCampaignsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of outbound campaigns.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListCampaignsResponseBodyDataList> List { get; set; }
            public class ListCampaignsResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The actual end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1634008800000</para>
                /// </summary>
                [NameInMap("ActualEndTime")]
                [Validation(Required=false)]
                public long? ActualEndTime { get; set; }

                /// <summary>
                /// <para>The actual start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1634008800000</para>
                /// </summary>
                [NameInMap("ActualStartTime")]
                [Validation(Required=false)]
                public long? ActualStartTime { get; set; }

                /// <summary>
                /// <para>The campaign ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7607dae1-91ad-47ea-ad76-3d81ac34f729</para>
                /// </summary>
                [NameInMap("CampaignId")]
                [Validation(Required=false)]
                public string CampaignId { get; set; }

                /// <summary>
                /// <para>The number of aborted cases.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CasesAborted")]
                [Validation(Required=false)]
                public int? CasesAborted { get; set; }

                /// <summary>
                /// <para>The number of connected cases.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("CasesConnected")]
                [Validation(Required=false)]
                public int? CasesConnected { get; set; }

                /// <summary>
                /// <para>The number of uncompleted cases.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CasesUncompleted")]
                [Validation(Required=false)]
                public int? CasesUncompleted { get; set; }

                /// <summary>
                /// <para>The number of cases that were attempted but not completed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CasesUncompletedAfterAttempted")]
                [Validation(Required=false)]
                public int? CasesUncompletedAfterAttempted { get; set; }

                /// <summary>
                /// <para>The completion rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("CompletedRate")]
                [Validation(Required=false)]
                public double? CompletedRate { get; set; }

                /// <summary>
                /// <para>The time when the campaign was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-07-27T11:25:15+08:00</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// <para>The fixed number of concurrent calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FixedQuota")]
                [Validation(Required=false)]
                public int? FixedQuota { get; set; }

                /// <summary>
                /// <para>The maximum number of retries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MaxAttemptCount")]
                [Validation(Required=false)]
                public int? MaxAttemptCount { get; set; }

                /// <summary>
                /// <para>The minimum retry interval.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("MinAttemptInterval")]
                [Validation(Required=false)]
                public int? MinAttemptInterval { get; set; }

                /// <summary>
                /// <para>The campaign name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Kiaconnect本月到期续费外呼话术-OPIO_20260727_102718</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The planned end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1634008800000</para>
                /// </summary>
                [NameInMap("PlannedEndTime")]
                [Validation(Required=false)]
                public long? PlannedEndTime { get; set; }

                /// <summary>
                /// <para>The planned start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1634008800000</para>
                /// </summary>
                [NameInMap("PlannedStartTime")]
                [Validation(Required=false)]
                public long? PlannedStartTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the campaign continues to run until the planned end time after all contacts have been called.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("RunUntilEndTime")]
                [Validation(Required=false)]
                public bool? RunUntilEndTime { get; set; }

                /// <summary>
                /// <para>The IVR flow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8a988bd4-6c6e-45c6-b3a5-3def5ca3bc6f</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                /// <summary>
                /// <para>The campaign status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Executing</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The total number of cases.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalCases")]
                [Validation(Required=false)]
                public int? TotalCases { get; set; }

                /// <summary>
                /// <para>The time when the campaign was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1760272478</para>
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

                /// <summary>
                /// <para>The weight of the campaign.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of error message parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
