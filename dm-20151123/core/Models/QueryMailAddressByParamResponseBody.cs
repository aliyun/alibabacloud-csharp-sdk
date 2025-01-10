// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class QueryMailAddressByParamResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>95A7D497-F8DD-4834-B81E-C1783236E55F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryMailAddressByParamResponseBodyData Data { get; set; }
        public class QueryMailAddressByParamResponseBodyData : TeaModel {
            [NameInMap("mailAddress")]
            [Validation(Required=false)]
            public List<QueryMailAddressByParamResponseBodyDataMailAddress> MailAddress { get; set; }
            public class QueryMailAddressByParamResponseBodyDataMailAddress : TeaModel {
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AccountStatus")]
                [Validation(Required=false)]
                public string AccountStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-09-29T13:28Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("DailyCount")]
                [Validation(Required=false)]
                public string DailyCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("DailyReqCount")]
                [Validation(Required=false)]
                public string DailyReqCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12122</para>
                /// </summary>
                [NameInMap("MailAddressId")]
                [Validation(Required=false)]
                public string MailAddressId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>300000</para>
                /// </summary>
                [NameInMap("MonthCount")]
                [Validation(Required=false)]
                public string MonthCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20000</para>
                /// </summary>
                [NameInMap("MonthReqCount")]
                [Validation(Required=false)]
                public string MonthReqCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:112@aliyun.com">112@aliyun.com</a></para>
                /// </summary>
                [NameInMap("ReplyAddress")]
                [Validation(Required=false)]
                public string ReplyAddress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ReplyStatus")]
                [Validation(Required=false)]
                public string ReplyStatus { get; set; }

                /// <summary>
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
