// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListInsightsEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the event.</para>
        /// </summary>
        [NameInMap("InsightsEvents")]
        [Validation(Required=false)]
        public List<ListInsightsEventsResponseBodyInsightsEvents> InsightsEvents { get; set; }
        public class ListInsightsEventsResponseBodyInsightsEvents : TeaModel {
            /// <summary>
            /// <para>The time when the event occurred. The value is a timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1658890560</para>
            /// </summary>
            [NameInMap("Date")]
            [Validation(Required=false)]
            public long? Date { get; set; }

            /// <summary>
            /// <para>The description of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The overall response time of the [HTTP] service of the application [sd] spikes at [2022-07-27 10:57:00]</para>
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// <para>The severity of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>P3</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The ID of the application associated with the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dsv9zcel92@7da413b******</para>
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// <para>The problem identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>erep3o9zue@01ebe697ab70566|@1499161100890550|@cn-hangzhou|@1701841800000|@1701842040000|@daa6c51a-3c44-4d57-9548-4e212c******</para>
            /// </summary>
            [NameInMap("ProblemId")]
            [Validation(Required=false)]
            public string ProblemId { get; set; }

            /// <summary>
            /// <para>The title of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Average response-time spikes of application services</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The type of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtIncrease</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6F1174DC-6085-5353-AAE7-D4ADCD******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
