// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class SenderStatisticsDetailByParamResponseBody : TeaModel {
        /// <summary>
        /// <para>Used for pagination. If there are more results, set this returned value to the NextStart in the next request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90f0243616#203#a***@example.net-1658817689#a***@example.net.247141122178</para>
        /// </summary>
        [NameInMap("NextStart")]
        [Validation(Required=false)]
        public string NextStart { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>B5AB8EBB-EE64-4BB2-B085-B92CC5DEDC41</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Detailed records</para>
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
                /// <para>Sending address</para>
                /// 
                /// <b>Example:</b>
                /// <para>s***@example.net</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>Detailed classification of error reasons: - SendOk - SmtpNxBox
                /// etc.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SendOk</para>
                /// </summary>
                [NameInMap("ErrorClassification")]
                [Validation(Required=false)]
                public string ErrorClassification { get; set; }

                /// <summary>
                /// <para>Update time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-04-28T17:11Z</para>
                /// </summary>
                [NameInMap("LastUpdateTime")]
                [Validation(Required=false)]
                public string LastUpdateTime { get; set; }

                /// <summary>
                /// <para>Delivery detail information</para>
                /// 
                /// <b>Example:</b>
                /// <para>250 Send Mail OK</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>Delivery status: 0 Success, 2 Invalid Address, 3 Spam, 4 Other Failures</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>Email subject</para>
                /// 
                /// <b>Example:</b>
                /// <para>test subject</para>
                /// </summary>
                [NameInMap("Subject")]
                [Validation(Required=false)]
                public string Subject { get; set; }

                /// <summary>
                /// <para>Recipient address</para>
                /// 
                /// <b>Example:</b>
                /// <para>b***@example.net</para>
                /// </summary>
                [NameInMap("ToAddress")]
                [Validation(Required=false)]
                public string ToAddress { get; set; }

                /// <summary>
                /// <para>UTC formatted update time</para>
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
