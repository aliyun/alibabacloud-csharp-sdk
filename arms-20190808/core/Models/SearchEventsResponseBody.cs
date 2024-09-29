// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>Specifies whether the alert event is triggered. If you do not set this parameter, all alert events are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>1</c>: The event is triggered.</description></item>
        /// <item><description><c>0</c>: The event is not triggered.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsTrigger")]
        [Validation(Required=false)]
        public int? IsTrigger { get; set; }

        /// <summary>
        /// <para>The struct returned.</para>
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchEventsResponseBodyPageBean PageBean { get; set; }
        public class SearchEventsResponseBodyPageBean : TeaModel {
            /// <summary>
            /// <para>The information about the alert events.</para>
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public List<SearchEventsResponseBodyPageBeanEvent> Event { get; set; }
            public class SearchEventsResponseBodyPageBeanEvent : TeaModel {
                /// <summary>
                /// <para>The ID of the alert rule that is associated with the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("AlertId")]
                [Validation(Required=false)]
                public long? AlertId { get; set; }

                /// <summary>
                /// <para>The name of the alert rule that is associated with the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alertName</para>
                /// </summary>
                [NameInMap("AlertName")]
                [Validation(Required=false)]
                public string AlertName { get; set; }

                /// <summary>
                /// <para>The condition of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;operator\&quot;:\&quot;&amp;\&quot;,\&quot;rules\&quot;:[{\&quot;aggregates\&quot;:\&quot;AVG\&quot;,\&quot;alias\&quot;:\&quot;JVM_线程总数\&quot;,\&quot;measure\&quot;:\&quot;appstat.jvm.ThreadCount\&quot;,\&quot;nValue\&quot;:1,\&quot;operator\&quot;:\&quot;HOH_DOWN\&quot;,\&quot;value\&quot;:50.0}]}</para>
                /// </summary>
                [NameInMap("AlertRule")]
                [Validation(Required=false)]
                public string AlertRule { get; set; }

                /// <summary>
                /// <para>The type of the alert rule. This parameter is not returned. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>1</c>: custom alert rules to monitor drill-down data sets</description></item>
                /// <item><description><c>3</c>: custom alert rules to monitor tiled data sets</description></item>
                /// <item><description><c>4</c>: alert rules to monitor the frontend, including the default frontend alert rules</description></item>
                /// <item><description><c>5</c>: alert rules to monitor applications, including the default application alert rules</description></item>
                /// <item><description><c>6</c>: the default frontend alert rules</description></item>
                /// <item><description><c>7</c>: the default application alert rules</description></item>
                /// <item><description><c>8</c>: Tracing Analysis alert rules</description></item>
                /// <item><description><c>101</c>: Prometheus alert rules</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public int? AlertType { get; set; }

                /// <summary>
                /// <para>The severity of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("EventLevel")]
                [Validation(Required=false)]
                public string EventLevel { get; set; }

                /// <summary>
                /// <para>The timestamp when the event occurred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1595569020000</para>
                /// </summary>
                [NameInMap("EventTime")]
                [Validation(Required=false)]
                public long? EventTime { get; set; }

                /// <summary>
                /// <para>The ID of the event record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The list of event URLs.</para>
                /// </summary>
                [NameInMap("Links")]
                [Validation(Required=false)]
                public List<string> Links { get; set; }

                /// <summary>
                /// <para>The event content. The parameter value is a JSON string. Each key indicates a dimension and each value indicates the alert content in the dimension.</para>
                /// 
                /// <b>Example:</b>
                /// <para>unknow紧急报警\nip：172.27.XX.XX\n应用名 = test\nRegion = cn-shenzhen\n异常信息 = {\&quot;timestamp\&quot;：\&quot;1615447972235\&quot;}</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32940175-181B-4B93-966E-4BB69176****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
