// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListDetectConfigsResponseBody : TeaModel {
        [NameInMap("detectConfigs")]
        [Validation(Required=false)]
        public List<ListDetectConfigsResponseBodyDetectConfigs> DetectConfigs { get; set; }
        public class ListDetectConfigsResponseBodyDetectConfigs : TeaModel {
            [NameInMap("alarmConfigs")]
            [Validation(Required=false)]
            public List<ListDetectConfigsResponseBodyDetectConfigsAlarmConfigs> AlarmConfigs { get; set; }
            public class ListDetectConfigsResponseBodyDetectConfigsAlarmConfigs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://metrichub-cms-cn-hangzhou.aliyuncs.com/event/notify?xxxxx">https://metrichub-cms-cn-hangzhou.aliyuncs.com/event/notify?xxxxx</a></para>
                /// </summary>
                [NameInMap("address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cms</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-04-10T02:30:04Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0 0 0 ? * 1</para>
            /// </summary>
            [NameInMap("cronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>this is a description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dc-xxxx</para>
            /// </summary>
            [NameInMap("detectConfigId")]
            [Validation(Required=false)]
            public string DetectConfigId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("detectConfigName")]
            [Validation(Required=false)]
            public string DetectConfigName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Cron</para>
            /// </summary>
            [NameInMap("triggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30BaZ9ekYWXJdqshYecA++coNg7qT1Zbm3RfLyFIZeY=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>79284133-D4BA-56B3-954C-D538256F7EAA</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>82</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
