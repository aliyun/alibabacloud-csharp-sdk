// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListEventRecordsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>7F40EAA1-6F1D-4DD9-8DB8-C5F00C4E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListEventRecordsResponseBodyResult Result { get; set; }
        public class ListEventRecordsResponseBodyResult : TeaModel {
            [NameInMap("result")]
            [Validation(Required=false)]
            public List<ListEventRecordsResponseBodyResultResult> Result { get; set; }
            public class ListEventRecordsResponseBodyResultResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("autoAlarm")]
                [Validation(Required=false)]
                public bool? AutoAlarm { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Instance.SpecModify</para>
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("dryRun")]
                [Validation(Required=false)]
                public bool? DryRun { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Info</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("mustOps")]
                [Validation(Required=false)]
                public bool? MustOps { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>elasticsearch</para>
                /// </summary>
                [NameInMap("product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-05-08 18:41:01</para>
                /// </summary>
                [NameInMap("scheduleExecuteTime")]
                [Validation(Required=false)]
                public string ScheduleExecuteTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-05-08 18:41:01</para>
                /// </summary>
                [NameInMap("scheduleFinishTime")]
                [Validation(Required=false)]
                public string ScheduleFinishTime { get; set; }

                [NameInMap("showContent")]
                [Validation(Required=false)]
                public ListEventRecordsResponseBodyResultResultShowContent ShowContent { get; set; }
                public class ListEventRecordsResponseBodyResultResultShowContent : TeaModel {
                    [NameInMap("actionSuggest")]
                    [Validation(Required=false)]
                    public ListEventRecordsResponseBodyResultResultShowContentActionSuggest ActionSuggest { get; set; }
                    public class ListEventRecordsResponseBodyResultResultShowContentActionSuggest : TeaModel {
                        [NameInMap("suggestActions")]
                        [Validation(Required=false)]
                        public List<string> SuggestActions { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>“”</para>
                        /// </summary>
                        [NameInMap("suggestText")]
                        [Validation(Required=false)]
                        public string SuggestText { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>promptText</para>
                        /// </summary>
                        [NameInMap("suggestType")]
                        [Validation(Required=false)]
                        public string SuggestType { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Instance.SpecModify</para>
                    /// </summary>
                    [NameInMap("desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Executed</para>
                    /// </summary>
                    [NameInMap("eventStatus")]
                    [Validation(Required=false)]
                    public string EventStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2025-05-08 18:31:01</para>
                    /// </summary>
                    [NameInMap("eventTime")]
                    [Validation(Required=false)]
                    public string EventTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2025-05-08 18:41:01</para>
                    /// </summary>
                    [NameInMap("executeFinishTime")]
                    [Validation(Required=false)]
                    public string ExecuteFinishTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2025-05-08 18:31:00</para>
                    /// </summary>
                    [NameInMap("executeStartTime")]
                    [Validation(Required=false)]
                    public string ExecuteStartTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>es-cn-a5cb2dece****</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>f183728022a1c769e97b4*****</para>
                    /// </summary>
                    [NameInMap("opsChangeId")]
                    [Validation(Required=false)]
                    public string OpsChangeId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>webConsole</para>
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Executed</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>UserOperator</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public string Total { get; set; }

        }

    }

}
