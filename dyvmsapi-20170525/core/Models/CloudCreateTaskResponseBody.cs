// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudCreateTaskResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CloudCreateTaskResponseBodyData Data { get; set; }
        public class CloudCreateTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("AgentTimeout")]
            [Validation(Required=false)]
            public string AgentTimeout { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("AnswerRate")]
            [Validation(Required=false)]
            public string AnswerRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoComplete")]
            [Validation(Required=false)]
            public long? AutoComplete { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoStart")]
            [Validation(Required=false)]
            public string AutoStart { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2016-04-11</para>
            /// </summary>
            [NameInMap("AutoStartDay")]
            [Validation(Required=false)]
            public string AutoStartDay { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>08:00:00</para>
            /// </summary>
            [NameInMap("AutoStartTime")]
            [Validation(Required=false)]
            public string AutoStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoStop")]
            [Validation(Required=false)]
            public string AutoStop { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("AutoStopDay")]
            [Validation(Required=false)]
            public string AutoStopDay { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>17:00:00</para>
            /// </summary>
            [NameInMap("AutoStopTime")]
            [Validation(Required=false)]
            public string AutoStopTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("Cnos")]
            [Validation(Required=false)]
            public string Cnos { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("Concurrency")]
            [Validation(Required=false)]
            public string Concurrency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("CustomerClids")]
            [Validation(Required=false)]
            public string CustomerClids { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("CustomerMoh")]
            [Validation(Required=false)]
            public string CustomerMoh { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("CustomerTimeout")]
            [Validation(Required=false)]
            public string CustomerTimeout { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("EnterpriseId")]
            [Validation(Required=false)]
            public string EnterpriseId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsRandom")]
            [Validation(Required=false)]
            public string IsRandom { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>330</para>
            /// </summary>
            [NameInMap("IvrId")]
            [Validation(Required=false)]
            public string IvrId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxWaitTime")]
            [Validation(Required=false)]
            public string MaxWaitTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("OverTime")]
            [Validation(Required=false)]
            public string OverTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("PredictAdjust")]
            [Validation(Required=false)]
            public string PredictAdjust { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.33</para>
            /// </summary>
            [NameInMap("Quotiety")]
            [Validation(Required=false)]
            public string Quotiety { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[{&quot;key1&quot;:&quot;value1&quot;},{&quot;key2&quot;:&quot;value2&quot;}]</para>
            /// </summary>
            [NameInMap("UserFields")]
            [Validation(Required=false)]
            public string UserFields { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Wrapup")]
            [Validation(Required=false)]
            public string Wrapup { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A9486641****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
