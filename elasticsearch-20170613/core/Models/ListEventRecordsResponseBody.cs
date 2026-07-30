// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListEventRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7F40EAA1-6F1D-4DD9-8DB8-C5F00C4E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListEventRecordsResponseBodyResult Result { get; set; }
        public class ListEventRecordsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The returned content.</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public List<ListEventRecordsResponseBodyResultResult> Result { get; set; }
            public class ListEventRecordsResponseBodyResultResult : TeaModel {
                /// <summary>
                /// <para>Indicates whether automatic alerting is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("autoAlarm")]
                [Validation(Required=false)]
                public bool? AutoAlarm { get; set; }

                /// <summary>
                /// <para>The display name of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Instance.SpecModify</para>
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>Indicates whether this is a dry run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("dryRun")]
                [Validation(Required=false)]
                public bool? DryRun { get; set; }

                /// <summary>
                /// <para>The event level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Info</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>Indicates whether O&amp;M processing is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("mustOps")]
                [Validation(Required=false)]
                public bool? MustOps { get; set; }

                /// <summary>
                /// <para>The product type of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>elasticsearch</para>
                /// </summary>
                [NameInMap("product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                /// <summary>
                /// <para>The scheduled execution time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-05-08 18:41:01</para>
                /// </summary>
                [NameInMap("scheduleExecuteTime")]
                [Validation(Required=false)]
                public string ScheduleExecuteTime { get; set; }

                /// <summary>
                /// <para>The scheduled end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-05-08 18:41:01</para>
                /// </summary>
                [NameInMap("scheduleFinishTime")]
                [Validation(Required=false)]
                public string ScheduleFinishTime { get; set; }

                /// <summary>
                /// <para>The event content.</para>
                /// </summary>
                [NameInMap("showContent")]
                [Validation(Required=false)]
                public ListEventRecordsResponseBodyResultResultShowContent ShowContent { get; set; }
                public class ListEventRecordsResponseBodyResultResultShowContent : TeaModel {
                    /// <summary>
                    /// <para>The suggested action.</para>
                    /// </summary>
                    [NameInMap("actionSuggest")]
                    [Validation(Required=false)]
                    public ListEventRecordsResponseBodyResultResultShowContentActionSuggest ActionSuggest { get; set; }
                    public class ListEventRecordsResponseBodyResultResultShowContentActionSuggest : TeaModel {
                        /// <summary>
                        /// <para>The suggested action.</para>
                        /// </summary>
                        [NameInMap("suggestActions")]
                        [Validation(Required=false)]
                        public List<string> SuggestActions { get; set; }

                        /// <summary>
                        /// <para>The text of the suggested action.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>“”</para>
                        /// </summary>
                        [NameInMap("suggestText")]
                        [Validation(Required=false)]
                        public string SuggestText { get; set; }

                        /// <summary>
                        /// <para>The type of the suggested action.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>promptText</para>
                        /// </summary>
                        [NameInMap("suggestType")]
                        [Validation(Required=false)]
                        public string SuggestType { get; set; }

                    }

                    /// <summary>
                    /// <para>The event description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Instance.SpecModify</para>
                    /// </summary>
                    [NameInMap("desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    /// <summary>
                    /// <para>The event status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Executed</para>
                    /// </summary>
                    [NameInMap("eventStatus")]
                    [Validation(Required=false)]
                    public string EventStatus { get; set; }

                    /// <summary>
                    /// <para>The time when the event occurred.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-05-08 18:31:01</para>
                    /// </summary>
                    [NameInMap("eventTime")]
                    [Validation(Required=false)]
                    public string EventTime { get; set; }

                    /// <summary>
                    /// <para>The end time of the O&amp;M execution for the event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-05-08 18:41:01</para>
                    /// </summary>
                    [NameInMap("executeFinishTime")]
                    [Validation(Required=false)]
                    public string ExecuteFinishTime { get; set; }

                    /// <summary>
                    /// <para>The start time of the O&amp;M execution for the event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-05-08 18:31:00</para>
                    /// </summary>
                    [NameInMap("executeStartTime")]
                    [Validation(Required=false)]
                    public string ExecuteStartTime { get; set; }

                    /// <summary>
                    /// <para>The instance ID of the instance on which the event occurred.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>es-cn-a5cb2dece****</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The execution ID of the cluster change.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>f183728022a1c769e97b4*****</para>
                    /// </summary>
                    [NameInMap("opsChangeId")]
                    [Validation(Required=false)]
                    public string OpsChangeId { get; set; }

                }

                /// <summary>
                /// <para>The source of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>webConsole</para>
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The event status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Executed</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The event type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UserOperator</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public string Total { get; set; }

        }

    }

}
