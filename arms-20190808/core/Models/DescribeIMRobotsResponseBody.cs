// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeIMRobotsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned objects.</para>
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public DescribeIMRobotsResponseBodyPageBean PageBean { get; set; }
        public class DescribeIMRobotsResponseBodyPageBean : TeaModel {
            /// <summary>
            /// <para>The queried IM chatbots.</para>
            /// </summary>
            [NameInMap("AlertIMRobots")]
            [Validation(Required=false)]
            public List<DescribeIMRobotsResponseBodyPageBeanAlertIMRobots> AlertIMRobots { get; set; }
            public class DescribeIMRobotsResponseBodyPageBeanAlertIMRobots : TeaModel {
                /// <summary>
                /// <para>The time when the IM chatbot was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-16 17:21:48</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Indicates whether daily statistics are sent. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>false</c> (default): Daily statistics are not sent.</description></item>
                /// <item><description><c>true</c>: Daily statistics are sent.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DailyNoc")]
                [Validation(Required=false)]
                public bool? DailyNoc { get; set; }

                /// <summary>
                /// <para>The point in time at which the daily statistics are sent. The information that ARMS sends at the specified points in time includes the total number of alerts generated on the current day, the number of cleared alerts, and the number of alerts to be cleared.</para>
                /// 
                /// <b>Example:</b>
                /// <para>09:30,17:30</para>
                /// </summary>
                [NameInMap("DailyNocTime")]
                [Validation(Required=false)]
                public string DailyNocTime { get; set; }

                /// <summary>
                /// <para>The signature key of DingTalk. If you specify a signature key, DingTalk authentication is performed by using the signature key. If you do not specify a signature key, a whitelist is used for authentication by default. The keyword of the whitelist is <b>Alert</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("DingSignKey")]
                [Validation(Required=false)]
                public string DingSignKey { get; set; }

                /// <summary>
                /// <para>The notification policies.</para>
                /// </summary>
                [NameInMap("DispatchRules")]
                [Validation(Required=false)]
                public List<DescribeIMRobotsResponseBodyPageBeanAlertIMRobotsDispatchRules> DispatchRules { get; set; }
                public class DescribeIMRobotsResponseBodyPageBeanAlertIMRobotsDispatchRules : TeaModel {
                    /// <summary>
                    /// <para>The ID of the notification policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The name of the notification policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Notification policy test</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The webhook URL of the IM chatbot.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=e1a049121">https://oapi.dingtalk.com/robot/send?access_token=e1a049121</a>******</para>
                /// </summary>
                [NameInMap("RobotAddr")]
                [Validation(Required=false)]
                public string RobotAddr { get; set; }

                /// <summary>
                /// <para>The ID of the IM chatbot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("RobotId")]
                [Validation(Required=false)]
                public float? RobotId { get; set; }

                /// <summary>
                /// <para>The name of the IM chatbot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Chatbot name</para>
                /// </summary>
                [NameInMap("RobotName")]
                [Validation(Required=false)]
                public string RobotName { get; set; }

                /// <summary>
                /// <para>The type of the IM chatbot. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>dingding</c>: DingTalk chatbot</description></item>
                /// <item><description><c>wechat</c>: WeCom chatbot</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>dingding</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// <para>The number of IM chatbots returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The total number of queried IM chatbots.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4D6C358A-A58B-4F4B-94CE-F5AAF023****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
