// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataCronClearTaskDetailListResponseBody : TeaModel {
        /// <summary>
        /// <para>The historical data cleansing tasks</para>
        /// </summary>
        [NameInMap("DataCronClearTaskDetailList")]
        [Validation(Required=false)]
        public List<GetDataCronClearTaskDetailListResponseBodyDataCronClearTaskDetailList> DataCronClearTaskDetailList { get; set; }
        public class GetDataCronClearTaskDetailListResponseBodyDataCronClearTaskDetailList : TeaModel {
            /// <summary>
            /// <para>The number of rows affected by the SQL task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ActualAffectRows")]
            [Validation(Required=false)]
            public long? ActualAffectRows { get; set; }

            /// <summary>
            /// <para>The time when the SQL task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-14 10:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the SQL task group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>432523</para>
            /// </summary>
            [NameInMap("DBTaskGroupId")]
            [Validation(Required=false)]
            public long? DBTaskGroupId { get; set; }

            /// <summary>
            /// <para>The state of the SQL task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>INIT</b>: The SQL task was initialized.</description></item>
            /// <item><description><b>PENDING</b>: The SQL task waited to be run.</description></item>
            /// <item><description><b>BE_SCHEDULED</b>: The SQL task waited to be scheduled.</description></item>
            /// <item><description><b>FAIL</b>: The SQL task failed.</description></item>
            /// <item><description><b>SUCCESS</b>: The SQL task was successful.</description></item>
            /// <item><description><b>PAUSE</b>: The SQL task was paused.</description></item>
            /// <item><description><b>DELETE</b>: The SQL task was deleted.</description></item>
            /// <item><description><b>RUNNING</b>: The SQL task was being run.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("jobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C1D39814-9808-47F8-AFE0-AF167239AC9B</para>
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

        /// <summary>
        /// <para>The total number of SQL tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
