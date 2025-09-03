// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class QueryMailAddressByParamResponseBody : TeaModel {
        /// <summary>
        /// <para>Current page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>95A7D497-F8DD-4834-B81E-C1783236E55F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total count</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>List of sending addresses</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryMailAddressByParamResponseBodyData Data { get; set; }
        public class QueryMailAddressByParamResponseBodyData : TeaModel {
            [NameInMap("mailAddress")]
            [Validation(Required=false)]
            public List<QueryMailAddressByParamResponseBodyDataMailAddress> MailAddress { get; set; }
            public class QueryMailAddressByParamResponseBodyDataMailAddress : TeaModel {
                /// <summary>
                /// <para>Sending address</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:sender@example.com">sender@example.com</a></para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>Account status, frozen: 1, normal: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AccountStatus")]
                [Validation(Required=false)]
                public string AccountStatus { get; set; }

                [NameInMap("ConfigSetId")]
                [Validation(Required=false)]
                public string ConfigSetId { get; set; }

                [NameInMap("ConfigSetName")]
                [Validation(Required=false)]
                public string ConfigSetName { get; set; }

                /// <summary>
                /// <para>Creation time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-09-29T13:28Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Daily quota limit</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("DailyCount")]
                [Validation(Required=false)]
                public string DailyCount { get; set; }

                /// <summary>
                /// <para>Daily quota</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("DailyReqCount")]
                [Validation(Required=false)]
                public string DailyReqCount { get; set; }

                /// <summary>
                /// <para>Domain status, 0 indicates normal, 1 indicates abnormal.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

                /// <summary>
                /// <para>Sending address ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>12122</para>
                /// </summary>
                [NameInMap("MailAddressId")]
                [Validation(Required=false)]
                public string MailAddressId { get; set; }

                /// <summary>
                /// <para>Monthly quota limit</para>
                /// 
                /// <b>Example:</b>
                /// <para>300000</para>
                /// </summary>
                [NameInMap("MonthCount")]
                [Validation(Required=false)]
                public string MonthCount { get; set; }

                /// <summary>
                /// <para>Monthly quota</para>
                /// 
                /// <b>Example:</b>
                /// <para>20000</para>
                /// </summary>
                [NameInMap("MonthReqCount")]
                [Validation(Required=false)]
                public string MonthReqCount { get; set; }

                /// <summary>
                /// <para>Reply address</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:test@example.com">test@example.com</a></para>
                /// </summary>
                [NameInMap("ReplyAddress")]
                [Validation(Required=false)]
                public string ReplyAddress { get; set; }

                /// <summary>
                /// <para>Reply address status</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ReplyStatus")]
                [Validation(Required=false)]
                public string ReplyStatus { get; set; }

                /// <summary>
                /// <para>Sending address type. Values:</para>
                /// <list type="bullet">
                /// <item><description>batch: bulk email</description></item>
                /// <item><description>trigger: triggered email</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>batch</para>
                /// </summary>
                [NameInMap("Sendtype")]
                [Validation(Required=false)]
                public string Sendtype { get; set; }

            }

        }

    }

}
