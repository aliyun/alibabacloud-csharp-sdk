// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeContactListResponseBody : TeaModel {
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
        /// <para>The alert contacts.</para>
        /// </summary>
        [NameInMap("Contacts")]
        [Validation(Required=false)]
        public DescribeContactListResponseBodyContacts Contacts { get; set; }
        public class DescribeContactListResponseBodyContacts : TeaModel {
            [NameInMap("Contact")]
            [Validation(Required=false)]
            public List<DescribeContactListResponseBodyContactsContact> Contact { get; set; }
            public class DescribeContactListResponseBodyContactsContact : TeaModel {
                /// <summary>
                /// <para>The alert notification method.</para>
                /// </summary>
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public DescribeContactListResponseBodyContactsContactChannels Channels { get; set; }
                public class DescribeContactListResponseBodyContactsContactChannels : TeaModel {
                    /// <summary>
                    /// <para>The TradeManager ID of the alert contact.</para>
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
                    /// <para><a href="mailto:Alice@example.com">Alice@example.com</a></para>
                    /// </summary>
                    [NameInMap("Mail")]
                    [Validation(Required=false)]
                    public string Mail { get; set; }

                    /// <summary>
                    /// <para>The phone number of the alert contac.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1333333****</para>
                    /// </summary>
                    [NameInMap("SMS")]
                    [Validation(Required=false)]
                    public string SMS { get; set; }

                }

                /// <summary>
                /// <para>The status of the alert notification method. Valid values: PENDING and OK.</para>
                /// <para>The email address must be activated after it is added as the value specified for the alert notification method. The value PENDING indicates that the email address is not activated. The value OK indicates that the email address is activated.</para>
                /// </summary>
                [NameInMap("ChannelsState")]
                [Validation(Required=false)]
                public DescribeContactListResponseBodyContactsContactChannelsState ChannelsState { get; set; }
                public class DescribeContactListResponseBodyContactsContactChannelsState : TeaModel {
                    /// <summary>
                    /// <para>The status of the TradeManager ID.</para>
                    /// <para>Valid value: OK. The value OK indicates that the TradeManager ID is valid and can receive alert notifications.</para>
                    /// <remarks>
                    /// <para> This parameter applies only to the Alibaba Cloud China site (aliyun.com).</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OK</para>
                    /// </summary>
                    [NameInMap("AliIM")]
                    [Validation(Required=false)]
                    public string AliIM { get; set; }

                    /// <summary>
                    /// <para>The status of the DingTalk chatbot.</para>
                    /// <para>Valid value: OK. The value OK indicates that the DingTalk chatbot is normal and alert notifications can be received in a DingTalk group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OK</para>
                    /// </summary>
                    [NameInMap("DingWebHook")]
                    [Validation(Required=false)]
                    public string DingWebHook { get; set; }

                    /// <summary>
                    /// <para>The status of the email address. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>PENDING: The phone number is not activated. Alert notifications can be sent to the phone number by using text messages only after the phone number is activated.</description></item>
                    /// <item><description>OK: The phone number is activated and can receive alert notifications.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PENDING</para>
                    /// </summary>
                    [NameInMap("Mail")]
                    [Validation(Required=false)]
                    public string Mail { get; set; }

                    /// <summary>
                    /// <para>The status of the phone number. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>PENDING: The phone number is not activated. Alert notifications can be sent to the phone number by using text messages only after the phone number is activated.</description></item>
                    /// <item><description>OK: The phone number is activated and can receive alert notifications.</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para> This parameter applies only to the Alibaba Cloud China site (aliyun.com).</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>OK</para>
                    /// </summary>
                    [NameInMap("SMS")]
                    [Validation(Required=false)]
                    public string SMS { get; set; }

                }

                /// <summary>
                /// <para>None.</para>
                /// </summary>
                [NameInMap("ContactGroups")]
                [Validation(Required=false)]
                public DescribeContactListResponseBodyContactsContactContactGroups ContactGroups { get; set; }
                public class DescribeContactListResponseBodyContactsContactContactGroups : TeaModel {
                    [NameInMap("ContactGroup")]
                    [Validation(Required=false)]
                    public List<string> ContactGroup { get; set; }

                }

                /// <summary>
                /// <para>The timestamp when the alert contact was created.</para>
                /// <para>Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1552356159000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <para>The language in which the alert information is displayed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>zh-cn: simplified Chinese</description></item>
                /// <item><description>en: English</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>zh-cn</para>
                /// </summary>
                [NameInMap("Lang")]
                [Validation(Required=false)]
                public string Lang { get; set; }

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
                /// <para>The timestamp when the alert contact was updated.</para>
                /// <para>Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1552356159000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Request is not authorization.</para>
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
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
