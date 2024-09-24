// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeContactListByContactGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The alert contacts that receive alert notifications.</para>
        /// </summary>
        [NameInMap("Contacts")]
        [Validation(Required=false)]
        public DescribeContactListByContactGroupResponseBodyContacts Contacts { get; set; }
        public class DescribeContactListByContactGroupResponseBodyContacts : TeaModel {
            [NameInMap("Contact")]
            [Validation(Required=false)]
            public List<DescribeContactListByContactGroupResponseBodyContactsContact> Contact { get; set; }
            public class DescribeContactListByContactGroupResponseBodyContactsContact : TeaModel {
                /// <summary>
                /// <para>The alert notification methods.</para>
                /// </summary>
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public DescribeContactListByContactGroupResponseBodyContactsContactChannels Channels { get; set; }
                public class DescribeContactListByContactGroupResponseBodyContactsContactChannels : TeaModel {
                    /// <summary>
                    /// <para>The TradeManager ID of the alert contact.</para>
                    /// <remarks>
                    /// <para> This parameter can be returned only on the China site (aliyun.com).</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Alice</para>
                    /// </summary>
                    [NameInMap("AliIM")]
                    [Validation(Required=false)]
                    public string AliIM { get; set; }

                    /// <summary>
                    /// <para>The webhook URL of the DingTalk chatbot.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=9bf44f8189597d07dfdd7a123455ffc112">https://oapi.dingtalk.com/robot/send?access_token=9bf44f8189597d07dfdd7a123455ffc112</a>****</para>
                    /// </summary>
                    [NameInMap("DingWebHook")]
                    [Validation(Required=false)]
                    public string DingWebHook { get; set; }

                    /// <summary>
                    /// <para>The email address of the alert contact.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="mailto:alice@example.com">alice@example.com</a></para>
                    /// </summary>
                    [NameInMap("Mail")]
                    [Validation(Required=false)]
                    public string Mail { get; set; }

                    /// <summary>
                    /// <para>The mobile number of the alert contact.</para>
                    /// <remarks>
                    /// <para> This parameter can be returned only on the China site (aliyun.com).</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1333333****</para>
                    /// </summary>
                    [NameInMap("SMS")]
                    [Validation(Required=false)]
                    public string SMS { get; set; }

                }

                /// <summary>
                /// <para>The time when the alert contact was created.</para>
                /// <para>Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1552314252000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the alert contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS</para>
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <para>The name of the alert contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alice</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The time when the alert contact was modified.</para>
                /// <para>Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1552314252000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The group is not exists.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06D5ECC2-B9BE-42A4-8FA3-1A610FB08B83</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
