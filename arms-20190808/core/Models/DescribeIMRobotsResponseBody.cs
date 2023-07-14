// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeIMRobotsResponseBody : TeaModel {
        /// <summary>
        /// The returned objects.
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public DescribeIMRobotsResponseBodyPageBean PageBean { get; set; }
        public class DescribeIMRobotsResponseBodyPageBean : TeaModel {
            /// <summary>
            /// The queried IM chatbots.
            /// </summary>
            [NameInMap("AlertIMRobots")]
            [Validation(Required=false)]
            public List<DescribeIMRobotsResponseBodyPageBeanAlertIMRobots> AlertIMRobots { get; set; }
            public class DescribeIMRobotsResponseBodyPageBeanAlertIMRobots : TeaModel {
                /// <summary>
                /// The time when the IM chatbot was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// Indicates whether daily statistics are sent. Valid values:
                /// 
                /// *   `false` (default): Daily statistics are not sent.
                /// *   `true`: Daily statistics are sent.
                /// </summary>
                [NameInMap("DailyNoc")]
                [Validation(Required=false)]
                public bool? DailyNoc { get; set; }

                /// <summary>
                /// The point in time at which the daily statistics are sent. The information that ARMS sends at the specified points in time includes the total number of alerts generated on the current day, the number of cleared alerts, and the number of alerts to be cleared.
                /// </summary>
                [NameInMap("DailyNocTime")]
                [Validation(Required=false)]
                public string DailyNocTime { get; set; }

                /// <summary>
                /// The signature key of DingTalk. If you specify a signature key, DingTalk authentication is performed by using the signature key. If you do not specify a signature key, a whitelist is used for authentication by default. The keyword of the whitelist is **Alert**.
                /// </summary>
                [NameInMap("DingSignKey")]
                [Validation(Required=false)]
                public string DingSignKey { get; set; }

                /// <summary>
                /// The notification policies.
                /// </summary>
                [NameInMap("DispatchRules")]
                [Validation(Required=false)]
                public List<DescribeIMRobotsResponseBodyPageBeanAlertIMRobotsDispatchRules> DispatchRules { get; set; }
                public class DescribeIMRobotsResponseBodyPageBeanAlertIMRobotsDispatchRules : TeaModel {
                    /// <summary>
                    /// The ID of the notification policy.
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// The name of the notification policy.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// The webhook URL of the IM chatbot.
                /// </summary>
                [NameInMap("RobotAddr")]
                [Validation(Required=false)]
                public string RobotAddr { get; set; }

                /// <summary>
                /// The ID of the IM chatbot.
                /// </summary>
                [NameInMap("RobotId")]
                [Validation(Required=false)]
                public float? RobotId { get; set; }

                /// <summary>
                /// The name of the IM chatbot.
                /// </summary>
                [NameInMap("RobotName")]
                [Validation(Required=false)]
                public string RobotName { get; set; }

                /// <summary>
                /// The type of the IM chatbot. Valid values:
                /// 
                /// *   `dingding`: DingTalk chatbot
                /// *   `wechat`: WeCom chatbot
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// The number of IM chatbots returned per page.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The total number of queried IM chatbots.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
