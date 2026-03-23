// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class QueryMailAddressByParamResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95A7D497-F8DD-4834-B81E-C1783236E55F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
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

                [NameInMap("AccountStatus")]
                [Validation(Required=false)]
                public string AccountStatus { get; set; }

                [NameInMap("ConfigSetId")]
                [Validation(Required=false)]
                public string ConfigSetId { get; set; }

                [NameInMap("ConfigSetName")]
                [Validation(Required=false)]
                public string ConfigSetName { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DailyCount")]
                [Validation(Required=false)]
                public string DailyCount { get; set; }

                [NameInMap("DailyReqCount")]
                [Validation(Required=false)]
                public string DailyReqCount { get; set; }

                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

                [NameInMap("MailAddressId")]
                [Validation(Required=false)]
                public string MailAddressId { get; set; }

                [NameInMap("MonthCount")]
                [Validation(Required=false)]
                public string MonthCount { get; set; }

                [NameInMap("MonthReqCount")]
                [Validation(Required=false)]
                public string MonthReqCount { get; set; }

                [NameInMap("ReplyAddress")]
                [Validation(Required=false)]
                public string ReplyAddress { get; set; }

                [NameInMap("ReplyStatus")]
                [Validation(Required=false)]
                public string ReplyStatus { get; set; }

                [NameInMap("Sendtype")]
                [Validation(Required=false)]
                public string Sendtype { get; set; }

            }

        }

    }

}
