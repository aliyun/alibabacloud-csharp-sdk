// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class QueryUsageStatisticsByTagIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. <b>OK</b> indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryUsageStatisticsByTagIdResponseBodyData> Data { get; set; }
        public class QueryUsageStatisticsByTagIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The authorization code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>g61I8UV5zd</para>
            /// </summary>
            [NameInMap("AuthorizationCode")]
            [Validation(Required=false)]
            public string AuthorizationCode { get; set; }

            /// <summary>
            /// <para>The numbers for which the query failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>71</para>
            /// </summary>
            [NameInMap("FailTotal")]
            [Validation(Required=false)]
            public long? FailTotal { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20230312</para>
            /// </summary>
            [NameInMap("GmtDateStr")]
            [Validation(Required=false)]
            public string GmtDateStr { get; set; }

            /// <summary>
            /// <para>The ID of the authorization code usage record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The industry name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Home security</para>
            /// </summary>
            [NameInMap("IndustryName")]
            [Validation(Required=false)]
            public string IndustryName { get; set; }

            /// <summary>
            /// <para>The customer product ID (PID).</para>
            /// 
            /// <b>Example:</b>
            /// <para>89</para>
            /// </summary>
            [NameInMap("PartnerId")]
            [Validation(Required=false)]
            public long? PartnerId { get; set; }

            /// <summary>
            /// <para>The scene name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Return visit</para>
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <para>The numbers for which the query succeeded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>93</para>
            /// </summary>
            [NameInMap("SuccessTotal")]
            [Validation(Required=false)]
            public long? SuccessTotal { get; set; }

            /// <summary>
            /// <para>The tag name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69</para>
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public long? TagId { get; set; }

            /// <summary>
            /// <para>The tag name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud Query</para>
            /// </summary>
            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

            /// <summary>
            /// <para>The total quantity of numbers that are involved in the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>41</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D45CC751-34DF-5797-81FB-9A2ED6DC024B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful.</para>
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

    }

}
