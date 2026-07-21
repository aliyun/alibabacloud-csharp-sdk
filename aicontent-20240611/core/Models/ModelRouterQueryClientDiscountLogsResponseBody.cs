// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterQueryClientDiscountLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of discount modification logs.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ModelRouterQueryClientDiscountLogsResponseBodyData> Data { get; set; }
        public class ModelRouterQueryClientDiscountLogsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The client ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("clientId")]
            [Validation(Required=false)]
            public long? ClientId { get; set; }

            /// <summary>
            /// <para>A flag that indicates whether the record is deleted. A value of 0 means the record is active.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("deleteTag")]
            [Validation(Required=false)]
            public long? DeleteTag { get; set; }

            /// <summary>
            /// <para>The discount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("discount")]
            [Validation(Required=false)]
            public float? Discount { get; set; }

            /// <summary>
            /// <para>The time when the discount took effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-09-01 00:00:00</para>
            /// </summary>
            [NameInMap("effectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <para>The time when the discount expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-09-10 00:00:00</para>
            /// </summary>
            [NameInMap("expireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The time when the record was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the record was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The record ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The remark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>备注</para>
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>未知错误</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The maximum number of results returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to use in a subsequent request to retrieve the next page of results. If this parameter is not returned, all results have been retrieved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxx-xxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx-xxxxxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates if the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
