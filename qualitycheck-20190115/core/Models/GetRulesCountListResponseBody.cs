// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetRulesCountListResponseBody : TeaModel {
        /// <summary>
        /// <para>Business type. This field has no practical meaning and can be ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>忽略</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public int? BusinessType { get; set; }

        /// <summary>
        /// <para>Result code. <b>200</b> indicates success. Any other value indicates failure. Use this field to identify the cause of failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRulesCountListResponseBodyData Data { get; set; }
        public class GetRulesCountListResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<string> Data { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error details if the request failed. Returns &quot;successful&quot; on success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Messages")]
        [Validation(Required=false)]
        public GetRulesCountListResponseBodyMessages Messages { get; set; }
        public class GetRulesCountListResponseBodyMessages : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public List<string> Message { get; set; }

        }

        /// <summary>
        /// <para>Current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of rows per page.</para>
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
        /// <para>9987D326-83D9-4A42-B9A5-0B27F9B40539</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. Use this field to determine request success: true means success; false or null means failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
