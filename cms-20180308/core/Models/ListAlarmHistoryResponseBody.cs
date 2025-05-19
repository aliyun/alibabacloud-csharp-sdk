// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class ListAlarmHistoryResponseBody : TeaModel {
        [NameInMap("AlarmHistoryList")]
        [Validation(Required=false)]
        public ListAlarmHistoryResponseBodyAlarmHistoryList AlarmHistoryList { get; set; }
        public class ListAlarmHistoryResponseBodyAlarmHistoryList : TeaModel {
            [NameInMap("AlarmHistory")]
            [Validation(Required=false)]
            public List<ListAlarmHistoryResponseBodyAlarmHistoryListAlarmHistory> AlarmHistory { get; set; }
            public class ListAlarmHistoryResponseBodyAlarmHistoryListAlarmHistory : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1548926982000</para>
                /// </summary>
                [NameInMap("AlarmTime")]
                [Validation(Required=false)]
                public long? AlarmTime { get; set; }

                [NameInMap("ContactGroups")]
                [Validation(Required=false)]
                public string ContactGroups { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;instanceId&quot;:&quot;XXX&quot;}</para>
                /// </summary>
                [NameInMap("Dimension")]
                [Validation(Required=false)]
                public string Dimension { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("EvaluationCount")]
                [Validation(Required=false)]
                public int? EvaluationCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1a775e37-dfba-430c-ab9f-7036475c8bfb_2dbe619b-0483-402e-9437-7c7a38fba7ed</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-demo</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2851651669</para>
                /// </summary>
                [NameInMap("LastTime")]
                [Validation(Required=false)]
                public long? LastTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CPUUtilization</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>acs_ecs_dashboard</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ALARM</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>84401454</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1DBBCE29-0F69-435C-B65C-53D1011D1D72</para>
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
