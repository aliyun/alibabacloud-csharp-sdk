// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class MergeRobot : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58.789Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("extend")]
        [Validation(Required=false)]
        public MergeRobotExtend Extend { get; set; }
        public class MergeRobotExtend : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>incident-card-template</para>
            /// </summary>
            [NameInMap("cardTemplate")]
            [Validation(Required=false)]
            public string CardTemplate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("dailyNoc")]
            [Validation(Required=false)]
            public bool? DailyNoc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>09:00</para>
            /// </summary>
            [NameInMap("dailyNocTime")]
            [Validation(Required=false)]
            public string DailyNocTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc123</para>
            /// </summary>
            [NameInMap("dingSignKey")]
            [Validation(Required=false)]
            public string DingSignKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enableOutgoing")]
            [Validation(Required=false)]
            public bool? EnableOutgoing { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>token-abc123</para>
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58.789Z</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>robot-12345</para>
        /// </summary>
        [NameInMap("identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=abc123">https://oapi.dingtalk.com/robot/send?access_token=abc123</a></para>
        /// </summary>
        [NameInMap("webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

    }

}
