// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListAuditTermsResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataNotExists</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Business data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAuditTermsResponseBodyData> Data { get; set; }
        public class ListAuditTermsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Exception statements</para>
            /// </summary>
            [NameInMap("ExceptionWord")]
            [Validation(Required=false)]
            public List<string> ExceptionWord { get; set; }

            /// <summary>
            /// <para>Task primary key ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Keyword</para>
            /// 
            /// <b>Example:</b>
            /// <para>龘</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>Suggested word</para>
            /// 
            /// <b>Example:</b>
            /// <para>龘(dá)</para>
            /// </summary>
            [NameInMap("SuggestWord")]
            [Validation(Required=false)]
            public string SuggestWord { get; set; }

            /// <summary>
            /// <para>Audit basis</para>
            /// 
            /// <b>Example:</b>
            /// <para>龙行龘龘出自四库本《玉篇》23龙部第8字，文字释义为群龙腾飞的样子，昂扬而热烈。</para>
            /// </summary>
            [NameInMap("TermsDesc")]
            [Validation(Required=false)]
            public string TermsDesc { get; set; }

            /// <summary>
            /// <para>Dictionary name</para>
            /// </summary>
            [NameInMap("TermsName")]
            [Validation(Required=false)]
            public string TermsName { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Maximum number of results returned</para>
        /// 
        /// <b>Example:</b>
        /// <para>77</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Error description</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Token for the next page</para>
        /// 
        /// <b>Example:</b>
        /// <para>x\&quot;x\&quot;x</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>F2F366D6-E9FE-1006-BB70-2C650896AAB5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Total count</para>
        /// 
        /// <b>Example:</b>
        /// <para>58</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
