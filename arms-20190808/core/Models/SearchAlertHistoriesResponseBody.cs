// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchAlertHistoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned struct.</para>
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchAlertHistoriesResponseBodyPageBean PageBean { get; set; }
        public class SearchAlertHistoriesResponseBodyPageBean : TeaModel {
            /// <summary>
            /// <para>The information about alert records.</para>
            /// </summary>
            [NameInMap("AlarmHistories")]
            [Validation(Required=false)]
            public List<SearchAlertHistoriesResponseBodyPageBeanAlarmHistories> AlarmHistories { get; set; }
            public class SearchAlertHistoriesResponseBodyPageBeanAlarmHistories : TeaModel {
                /// <summary>
                /// <para>The content of the alert notification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;Alert name: Alert1\nAlert time: 2020-07-24 12:14:00\nAlert content: A total of four alerts are triggered: \<em>\</em>\<em>\</em>&quot;</para>
                /// </summary>
                [NameInMap("AlarmContent")]
                [Validation(Required=false)]
                public string AlarmContent { get; set; }

                /// <summary>
                /// <para>The response code returned after the alert notification was sent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("AlarmResponseCode")]
                [Validation(Required=false)]
                public int? AlarmResponseCode { get; set; }

                /// <summary>
                /// <para>The webhook URL, such as the webhook URL of a DingTalk chatbot.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=91f2f65002fefe0ab9b71e6590c5ca504348cad742ff01e9c8ab204439ca">https://oapi.dingtalk.com/robot/send?access_token=91f2f65002fefe0ab9b71e6590c5ca504348cad742ff01e9c8ab204439ca</a>****</para>
                /// </summary>
                [NameInMap("AlarmSources")]
                [Validation(Required=false)]
                public string AlarmSources { get; set; }

                /// <summary>
                /// <para>The time when the alert notification was sent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1595564179000</para>
                /// </summary>
                [NameInMap("AlarmTime")]
                [Validation(Required=false)]
                public long? AlarmTime { get; set; }

                /// <summary>
                /// <para>The type of the alert rule. Default value: 4. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>1</c>: a custom alert rule that is used to monitor drill-down data sets</description></item>
                /// <item><description><c>3</c>: a custom alert rule that is used to monitor tiled data sets</description></item>
                /// <item><description><c>4</c>: an alert rule that is used to monitor web pages, including the default alert rule for browser monitoring</description></item>
                /// <item><description><c>5</c>: an alert rule that is used to monitor applications, including the default alert rule for application monitoring</description></item>
                /// <item><description><c>6</c>: the default alert rule for browser monitoring</description></item>
                /// <item><description><c>7</c>: the default alert rule for application monitoring</description></item>
                /// <item><description><c>8</c>: a Tracing Analysis alert rule</description></item>
                /// <item><description><c>101</c>: a Prometheus alert rule</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("AlarmType")]
                [Validation(Required=false)]
                public int? AlarmType { get; set; }

                /// <summary>
                /// <para>The email address of the alert contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:someone@example.com">someone@example.com</a></para>
                /// </summary>
                [NameInMap("Emails")]
                [Validation(Required=false)]
                public string Emails { get; set; }

                /// <summary>
                /// <para>The ID of the alert notification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The mobile phone number of the alert contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1381111****</para>
                /// </summary>
                [NameInMap("Phones")]
                [Validation(Required=false)]
                public string Phones { get; set; }

                /// <summary>
                /// <para>The internal fields.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("StrategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

                /// <summary>
                /// <para>The internal fields.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                /// <summary>
                /// <para>The ID of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>113197164949****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

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
            /// <para>The total number of returned entries.</para>
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
        /// <para>2FC13182-B9AF-4E6B-BE51-72669B7C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
