// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListDetectConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>List of drift detection configurations</para>
        /// </summary>
        [NameInMap("detectConfigs")]
        [Validation(Required=false)]
        public List<ListDetectConfigsResponseBodyDetectConfigs> DetectConfigs { get; set; }
        public class ListDetectConfigsResponseBodyDetectConfigs : TeaModel {
            /// <summary>
            /// <para>List of alerting addresses</para>
            /// </summary>
            [NameInMap("alarmConfigs")]
            [Validation(Required=false)]
            public List<ListDetectConfigsResponseBodyDetectConfigsAlarmConfigs> AlarmConfigs { get; set; }
            public class ListDetectConfigsResponseBodyDetectConfigsAlarmConfigs : TeaModel {
                /// <summary>
                /// <para>Alerting address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://metrichub-cms-cn-hangzhou.aliyuncs.com/event/notify?xxxxx">https://metrichub-cms-cn-hangzhou.aliyuncs.com/event/notify?xxxxx</a></para>
                /// </summary>
                [NameInMap("address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>Alerting method. Currently only <c>cms</c> is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cms</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Creation Time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-10T02:30:04Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Cron expression (UTC+8). Required when the trigger type is Cron.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 0 ? * 1</para>
            /// </summary>
            [NameInMap("cronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <para>Description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>this is a description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Drift detection configuration ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>dc-xxxx</para>
            /// </summary>
            [NameInMap("detectConfigId")]
            [Validation(Required=false)]
            public string DetectConfigId { get; set; }

            /// <summary>
            /// <para>Name of the drift detection configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("detectConfigName")]
            [Validation(Required=false)]
            public string DetectConfigName { get; set; }

            /// <summary>
            /// <para>Whether drift detection is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>Trigger type  </para>
            /// <list type="bullet">
            /// <item><description>Manual: Execute manually  </description></item>
            /// <item><description>Cron: Trigger on schedule</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Cron</para>
            /// </summary>
            [NameInMap("triggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

        }

        /// <summary>
        /// <para>Maximum number of records to retrieve in a single request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Paging nextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30BaZ9ekYWXJdqshYecA++coNg7qT1Zbm3RfLyFIZeY=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79284133-D4BA-56B3-954C-D538256F7EAA</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>82</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
