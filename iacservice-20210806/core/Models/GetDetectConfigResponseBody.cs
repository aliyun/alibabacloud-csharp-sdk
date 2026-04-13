// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetDetectConfigResponseBody : TeaModel {
        [NameInMap("detectConfig")]
        [Validation(Required=false)]
        public GetDetectConfigResponseBodyDetectConfig DetectConfig { get; set; }
        public class GetDetectConfigResponseBodyDetectConfig : TeaModel {
            [NameInMap("alarmConfigs")]
            [Validation(Required=false)]
            public List<GetDetectConfigResponseBodyDetectConfigAlarmConfigs> AlarmConfigs { get; set; }
            public class GetDetectConfigResponseBodyDetectConfigAlarmConfigs : TeaModel {
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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>BF72A6FB-B071-5F2E-A036-9D62545B962C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
