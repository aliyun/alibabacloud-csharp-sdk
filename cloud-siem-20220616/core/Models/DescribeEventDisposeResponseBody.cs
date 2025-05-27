// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeEventDisposeResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEventDisposeResponseBodyData Data { get; set; }
        public class DescribeEventDisposeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>An array consisting of JSON objects that are configured for event handling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ playbookName: &quot;使用安全组封禁入方向IP&quot;, sophonTaskId: &quot;400442a5-4f98-45ed-97db-5ab117eb0b8f&quot;, … }</para>
            /// </summary>
            [NameInMap("EventDispose")]
            [Validation(Required=false)]
            public List<object> EventDispose { get; set; }

            /// <summary>
            /// <para>The JSON object that is configured for an alert recipient.</para>
            /// </summary>
            [NameInMap("ReceiverInfo")]
            [Validation(Required=false)]
            public DescribeEventDisposeResponseBodyDataReceiverInfo ReceiverInfo { get; set; }
            public class DescribeEventDisposeResponseBodyDataReceiverInfo : TeaModel {
                /// <summary>
                /// <para>The channel of the contact information. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>message</description></item>
                /// <item><description>mail</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>message</para>
                /// </summary>
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-06 16:37:29</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the recipient who receives the event handling result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The UUID of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
                /// </summary>
                [NameInMap("IncidentUuid")]
                [Validation(Required=false)]
                public string IncidentUuid { get; set; }

                /// <summary>
                /// <para>The message title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>siem event dealed message</para>
                /// </summary>
                [NameInMap("MessageTitle")]
                [Validation(Required=false)]
                public string MessageTitle { get; set; }

                /// <summary>
                /// <para>The contact information of the recipient.</para>
                /// 
                /// <b>Example:</b>
                /// <para>138xxxxxx</para>
                /// </summary>
                [NameInMap("Receiver")]
                [Validation(Required=false)]
                public string Receiver { get; set; }

                /// <summary>
                /// <para>Indicates whether the message is sent. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: not sent</description></item>
                /// <item><description>1: sent</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            /// <summary>
            /// <para>The description of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dealed</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The status of the event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: not handled</description></item>
            /// <item><description>1: handing</description></item>
            /// <item><description>5: handling failed</description></item>
            /// <item><description>10: handled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9AAA9ED9-78F4-5021-86DC-D51C7511****</para>
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
