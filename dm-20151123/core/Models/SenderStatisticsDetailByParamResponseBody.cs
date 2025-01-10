// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class SenderStatisticsDetailByParamResponseBody : TeaModel {
        /// <summary>
        /// <para>The start position of the next page. The return value of the NextStart parameter indicates the start position of the next page. If you want to obtain more records, specify the return value in the next request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90f0243616#203#a***@example.net-1658817689#a***@example.net.247141122178</para>
        /// </summary>
        [NameInMap("NextStart")]
        [Validation(Required=false)]
        public string NextStart { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B5AB8EBB-EE64-4BB2-B085-B92CC5DEDC41</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public SenderStatisticsDetailByParamResponseBodyData Data { get; set; }
        public class SenderStatisticsDetailByParamResponseBodyData : TeaModel {
            [NameInMap("mailDetail")]
            [Validation(Required=false)]
            public List<SenderStatisticsDetailByParamResponseBodyDataMailDetail> MailDetail { get; set; }
            public class SenderStatisticsDetailByParamResponseBodyDataMailDetail : TeaModel {
                /// <summary>
                /// <para>The sender address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s***@example.net</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>Detailed classification of error causes:</para>
                /// <list type="bullet">
                /// <item><description>SendOk</description></item>
                /// <item><description>SmtpNxBox</description></item>
                /// </list>
                /// <para>etc.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SendOk</para>
                /// </summary>
                [NameInMap("ErrorClassification")]
                [Validation(Required=false)]
                public string ErrorClassification { get; set; }

                /// <summary>
                /// <para>The most recent update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-04-28T17:11Z</para>
                /// </summary>
                [NameInMap("LastUpdateTime")]
                [Validation(Required=false)]
                public string LastUpdateTime { get; set; }

                /// <summary>
                /// <para>The details of the email.</para>
                /// 
                /// <b>Example:</b>
                /// <para>250 Send Mail OK</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The delivery status. Valid values: 0: successful, 2 invalid email address, 3: spam, and 4: failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>the subject of email.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test subject</para>
                /// </summary>
                [NameInMap("Subject")]
                [Validation(Required=false)]
                public string Subject { get; set; }

                /// <summary>
                /// <para>The recipient address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>b***@example.net</para>
                /// </summary>
                [NameInMap("ToAddress")]
                [Validation(Required=false)]
                public string ToAddress { get; set; }

                /// <summary>
                /// <para>The most recent update time (timestamp format)</para>
                /// 
                /// <b>Example:</b>
                /// <para>1619601108</para>
                /// </summary>
                [NameInMap("UtcLastUpdateTime")]
                [Validation(Required=false)]
                public string UtcLastUpdateTime { get; set; }

            }

        }

    }

}
