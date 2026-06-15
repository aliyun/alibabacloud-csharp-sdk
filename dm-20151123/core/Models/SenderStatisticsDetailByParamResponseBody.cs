// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class SenderStatisticsDetailByParamResponseBody : TeaModel {
        /// <summary>
        /// <para>Used for paging. If more results are available, set the \<c>NextStart\\</c> parameter in your next request to this return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90f0243616#203#a***@example.net-1658817689#a***@example.net.247141122178</para>
        /// </summary>
        [NameInMap("NextStart")]
        [Validation(Required=false)]
        public string NextStart { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B5AB8EBB-EE64-4BB2-B085-B92CC5DEDC41</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public SenderStatisticsDetailByParamResponseBodyData Data { get; set; }
        public class SenderStatisticsDetailByParamResponseBodyData : TeaModel {
            [NameInMap("mailDetail")]
            [Validation(Required=false)]
            public List<SenderStatisticsDetailByParamResponseBodyDataMailDetail> MailDetail { get; set; }
            public class SenderStatisticsDetailByParamResponseBodyDataMailDetail : TeaModel {
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("ConfigSetId")]
                [Validation(Required=false)]
                public string ConfigSetId { get; set; }

                /// <summary>
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("ConfigSetName")]
                [Validation(Required=false)]
                public string ConfigSetName { get; set; }

                [NameInMap("ErrorClassification")]
                [Validation(Required=false)]
                public string ErrorClassification { get; set; }

                /// <summary>
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("IpPoolId")]
                [Validation(Required=false)]
                public string IpPoolId { get; set; }

                /// <summary>
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("IpPoolName")]
                [Validation(Required=false)]
                public string IpPoolName { get; set; }

                [NameInMap("LastUpdateTime")]
                [Validation(Required=false)]
                public string LastUpdateTime { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("Subject")]
                [Validation(Required=false)]
                public string Subject { get; set; }

                [NameInMap("ToAddress")]
                [Validation(Required=false)]
                public string ToAddress { get; set; }

                [NameInMap("UtcLastUpdateTime")]
                [Validation(Required=false)]
                public string UtcLastUpdateTime { get; set; }

            }

        }

    }

}
