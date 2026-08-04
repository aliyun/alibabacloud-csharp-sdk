// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetScheduleTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Response message</para>
        /// 
        /// <b>Example:</b>
        /// <para>调用成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>F7E21065-6C21-1158-A2F9-AEFE5CAB7C94</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Service response parameters</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetScheduleTaskResponseBodyResult Result { get; set; }
        public class GetScheduleTaskResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Trigger behavior</para>
            /// </summary>
            [NameInMap("ActionTopicList")]
            [Validation(Required=false)]
            public List<GetScheduleTaskResponseBodyResultActionTopicList> ActionTopicList { get; set; }
            public class GetScheduleTaskResponseBodyResultActionTopicList : TeaModel {
                /// <summary>
                /// <para>Vendor-defined command</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;k1&quot;:&quot;v1&quot;,&quot;k2&quot;:{&quot;key&quot;:1}}</para>
                /// </summary>
                [NameInMap("CustomAction")]
                [Validation(Required=false)]
                public Dictionary<string, object> CustomAction { get; set; }

            }

            /// <summary>
            /// <para>Trigger Cron Expression</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 10 20 30 6 ? 2022</para>
            /// </summary>
            [NameInMap("Cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            /// <summary>
            /// <para>Validity Period - End Time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1659169473000</para>
            /// </summary>
            [NameInMap("ScheduleEndTime")]
            [Validation(Required=false)]
            public string ScheduleEndTime { get; set; }

            /// <summary>
            /// <para>Job ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567</para>
            /// </summary>
            [NameInMap("ScheduleId")]
            [Validation(Required=false)]
            public long? ScheduleId { get; set; }

            /// <summary>
            /// <para>Validity Period - Start Time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1656577473000</para>
            /// </summary>
            [NameInMap("ScheduleStartTime")]
            [Validation(Required=false)]
            public string ScheduleStartTime { get; set; }

            /// <summary>
            /// <para>Schedule Type</para>
            /// 
            /// <b>Example:</b>
            /// <para>ONCE</para>
            /// </summary>
            [NameInMap("ScheduleType")]
            [Validation(Required=false)]
            public string ScheduleType { get; set; }

        }

    }

}
