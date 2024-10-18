// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class QuerySendDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response code.</para>
        /// <para>If OK is returned, the request is successful. Other values indicate that the request failed. For more information, see <a href="https://help.aliyun.com/document_detail/101346.html?spm=a2c4g.419277.0.i11">Error codes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public List<QuerySendDetailsResponseBodyModel> Model { get; set; }
        public class QuerySendDetailsResponseBodyModel : TeaModel {
            /// <summary>
            /// <para>The content of the text message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203160</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The status code returned by the carrier.</para>
            /// <list type="bullet">
            /// <item><description>If the text message was delivered, &quot;DELIVERED&quot; is returned.</description></item>
            /// <item><description>If the text message failed to be sent, see <a href="https://help.aliyun.com/document_detail/101347.html?spm=a2c4g.419277.0.i8">Error codes</a> for more information.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DELIVERED</para>
            /// </summary>
            [NameInMap("ErrCode")]
            [Validation(Required=false)]
            public string ErrCode { get; set; }

            /// <summary>
            /// <para>The extension field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12131231</para>
            /// </summary>
            [NameInMap("OutId")]
            [Validation(Required=false)]
            public string OutId { get; set; }

            /// <summary>
            /// <para>The phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1390000****</para>
            /// </summary>
            [NameInMap("PhoneNum")]
            [Validation(Required=false)]
            public string PhoneNum { get; set; }

            /// <summary>
            /// <para>The date and time when the text message was received.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-08 16:44:13</para>
            /// </summary>
            [NameInMap("ReceiveDate")]
            [Validation(Required=false)]
            public string ReceiveDate { get; set; }

            /// <summary>
            /// <para>The date when the text message was sent. You can query text messages that were sent within the last 30 days.</para>
            /// <para>The date is in the yyyyMMdd format. Example: 20181225.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-08 16:44:13</para>
            /// </summary>
            [NameInMap("SendDate")]
            [Validation(Required=false)]
            public string SendDate { get; set; }

            /// <summary>
            /// <para>The delivery status of the text message.</para>
            /// <list type="bullet">
            /// <item><description>1: A delivery receipt is to be sent.</description></item>
            /// <item><description>2: The text message failed to be sent.</description></item>
            /// <item><description>3: The text message was sent.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("SendStatus")]
            [Validation(Required=false)]
            public long? SendStatus { get; set; }

            /// <summary>
            /// <para>The code of the text message template.</para>
            /// <para>Log on to the SMS console. In the left-side navigation pane, click <b>Go China</b> or <b>Go Globe</b>. You can view the text message template code in the <b>Template Code</b> column on the <b>Message Templates</b> tab.</para>
            /// <remarks>
            /// <para> The text message templates must be created on the Go Globe page and approved.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SMS_12231****</para>
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
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

        /// <summary>
        /// <para>The total number of entries in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
