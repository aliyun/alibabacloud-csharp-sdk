// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class QueryReceiverByParamResponseBody : TeaModel {
        /// <summary>
        /// <para>Used for paging. If more results are available, set this value as the NextStart parameter in your next request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6aec200853#102#1638894326#<a href="mailto:test@example.com">test@example.com</a></para>
        /// </summary>
        [NameInMap("NextStart")]
        [Validation(Required=false)]
        public string NextStart { get; set; }

        /// <summary>
        /// <para>Number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10A1AD70-E48E-476D-98D9-39BD92193837</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryReceiverByParamResponseBodyData Data { get; set; }
        public class QueryReceiverByParamResponseBodyData : TeaModel {
            [NameInMap("receiver")]
            [Validation(Required=false)]
            public List<QueryReceiverByParamResponseBodyDataReceiver> Receiver { get; set; }
            public class QueryReceiverByParamResponseBodyDataReceiver : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public string Count { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("ReceiverId")]
                [Validation(Required=false)]
                public string ReceiverId { get; set; }

                [NameInMap("ReceiversAlias")]
                [Validation(Required=false)]
                public string ReceiversAlias { get; set; }

                [NameInMap("ReceiversName")]
                [Validation(Required=false)]
                public string ReceiversName { get; set; }

                [NameInMap("ReceiversStatus")]
                [Validation(Required=false)]
                public string ReceiversStatus { get; set; }

                [NameInMap("UtcCreateTime")]
                [Validation(Required=false)]
                public long? UtcCreateTime { get; set; }

            }

        }

    }

}
