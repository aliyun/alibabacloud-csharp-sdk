// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class ListAlarmEventResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAlarmEventResponseBodyData Data { get; set; }
        public class ListAlarmEventResponseBodyData : TeaModel {
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
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The result set.</para>
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<ListAlarmEventResponseBodyDataRecords> Records { get; set; }
            public class ListAlarmEventResponseBodyDataRecords : TeaModel {
                /// <summary>
                /// <para>The alarm channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>webhook</para>
                /// </summary>
                [NameInMap("AlarmChannel")]
                [Validation(Required=false)]
                public string AlarmChannel { get; set; }

                /// <summary>
                /// <para>The alarm contacts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("AlarmContacts")]
                [Validation(Required=false)]
                public string AlarmContacts { get; set; }

                /// <summary>
                /// <para>The alarm message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>报警类型：任务执行失败报警
                /// 运行环境：cn-xx
                /// 集群：xxljob-b6ec1acfb2c
                /// 应用名：testApp
                /// 任务ID及名称：8(failedjob)
                /// 实例ID：1308
                /// 触发时间：2024-11-19 13:57:10
                /// 失败次数：187
                /// 运行机器：<a href="http://192.***.***.5:9999/">http://192.***.***.5:9999/</a>
                /// 失败原因：java.lang.reflect.InvocationTargetException</para>
                /// </summary>
                [NameInMap("AlarmMessage")]
                [Validation(Required=false)]
                public string AlarmMessage { get; set; }

                /// <summary>
                /// <para>The alarm status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AlarmStatus")]
                [Validation(Required=false)]
                public string AlarmStatus { get; set; }

                /// <summary>
                /// <para>The alarm type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>schedulerx3_fail_alarm</para>
                /// </summary>
                [NameInMap("AlarmType")]
                [Validation(Required=false)]
                public string AlarmType { get; set; }

                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-app</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The job name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-job</para>
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <para>The time the event occurred, in <c>yyyy-MM-dd HH:mm:ss</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-31 16:43:51</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

            /// <summary>
            /// <para>The total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter check error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. This unique identifier is generated by Alibaba Cloud for each request and can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27B1345D-5F71-5972-8E4C-AABA6C6232F0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
